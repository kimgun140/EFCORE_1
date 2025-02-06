using EFCORE_1.Model;
using Microsoft.Extensions.Options;
using Org.BouncyCastle.Crypto.Engines;
using Org.BouncyCastle.Crypto.Modes;
using Org.BouncyCastle.Crypto.Paddings;
using Org.BouncyCastle.Crypto.Parameters;
using System;
using System.Collections.Generic;
using System.DirectoryServices;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;


namespace EFCORE_1
{
    public class TestClass
    {
        public string LoginVerifying(int id)
        {
            using (var model = new ModelContext())
            {

                var userdata = (from Userinfo in model.AatestTablePks
                                where Userinfo.Id == id
                                select Userinfo).SingleOrDefault();

                if (userdata == null)
                {
                    MessageBox.Show("존재하지않는 아이디입니다.");
                    return "";
                }

                return userdata.Name;
                // Name이 그거 알고리즘을 통해서 암호화된 데이터 
            }
        }
        public byte[] Two_Way_verified(string key, string iv, string plaintext)
        // 양방향 암호화 해보자, 복호화해도 해보기 
        {
            // 암호화 엔진 설정
            var engine = new CbcBlockCipher(new SeedEngine());
            //seed알고리즘 사용 , CBC 암호 블록 연결 모드를 설정
            var cipher = new PaddedBufferedBlockCipher(engine, new Pkcs7Padding());
            // 패딩적용 데이터를 16바이트 블록 크기에 맞춤 
            var keyParam = new KeyParameter(Encoding.UTF8.GetBytes(key));
            var ivParam = new ParametersWithIV(keyParam, Encoding.UTF8.GetBytes(iv));
            // 키와 Iv를 각각 설정 
            cipher.Init(true, ivParam); // true: 암호화 모드

            byte[] inputBytes = Encoding.UTF8.GetBytes(plaintext);

            return cipher.DoFinal(inputBytes);
            // 암호화

        }
        public void LoginFailed()
        {

        }
        public void GetId()
        {

        }
        public void GetPw()
        {

        }
        public void Test_method(string SubjectId, string adminId, string adminpw)
        {

            using (var model = new ModelContext())
            {
                try
                {
                    IQueryable<Userinfo> query = model.Userinfos;

                    if (!string.IsNullOrEmpty(SubjectId))
                    {
                        query = query.Where(u => u.UserId == SubjectId);
                    }
                    var userinfo = query.SingleOrDefault();
                    if (userinfo == null)
                    {
                        MessageBox.Show("해당사용자를 찾을 수 없습니다.");
                        return;
                    }

                    string previousRole = userinfo.UserGrifid;
                    userinfo.UserGrifid = (userinfo.UserGrifid! != "SP") ? "SP" : "PD";

                    // 권한 변경 로그 기록
                    var log = new Permissionchangelog
                    {
                        UserId = int.Parse(adminId),
                        AccessIp = "1111",
                        SubjectId = userinfo.UserId,
                        SubjectName = userinfo.UserName,
                        PermissionChangeDetail = $"권한이 {previousRole} → {userinfo.UserGrifid}로 변경됨."
                    };
                    model.Permissionchangelogs.Add(log);

                    //  관리자 활동 로그 기록
                    var adminLog = new Adminactivitylog
                    {
                        AdminId = adminId,
                        AccessIp = "1111",
                        SubjectId = userinfo.UserId,
                        SubjectName = userinfo.UserName,
                        ActivityId = userinfo.UserGrifid,
                        ActivityDescription = "권한 변경 수행"
                    };
                    model.Adminactivitylogs.Add(adminLog);

                    // 5️⃣ 변경사항 저장 후 트랜잭션 커밋
                    model.SaveChanges();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("오류 발생: " + ex.Message);
                }
            }

        }
        public List<Adminactivitylog> Search(string AdminId, string SubjectId, string ActivityId)

        {
            // method syntax

            using (var model = new ModelContext())
            {
                try
                {
                    IQueryable<Adminactivitylog> query = model.Adminactivitylogs;

                    bool hasCondition = false;
                    // 검색 조건으로 입력 관리자 아이디가 있으면 쿼리에 추가 
                    if (!string.IsNullOrEmpty(AdminId))
                    {
                        query = query.Where(u => u.AdminId == AdminId);
                        hasCondition = true;
                    }

                    // 검색조건으로 입력된 정보주체 아이디가 
                    if (!string.IsNullOrEmpty(SubjectId))
                    {
                        query = query.Where(u =>
                        u.SubjectId == SubjectId
                        );
                        hasCondition = true;



                    }
                    if (!string.IsNullOrEmpty(ActivityId))
                    {
                        query = query.Where(u => u.ActivityId == ActivityId);
                        hasCondition = true;

                    }
                    // 아무 조건도 입력되지 않았다면 전체 조회
                    if (!hasCondition)
                    {
                        query = model.Adminactivitylogs;
                    }

                    var result = query.ToList();

                    return result;
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);

                    return null;
                }
            }
        }
        public List<Adminactivitylog> JoinTest(int id)// 
        {
            // query syntax
            using (var model = new ModelContext())
            {
                var query = from Actlog in model.Adminactivitylogs
                            join User in model.AatestTablePks on Actlog.AdminId equals User.Id.ToString()
                            where User.Id == id
                            select new Model.Adminactivitylog
                            {
                                AdminId = Actlog.AdminId,
                                ActivityDatetime = Actlog.ActivityDatetime,
                                SubjectId = Actlog.SubjectId,
                                ActivityDescription = Actlog.ActivityDescription
                            };

                return query.ToList();


            }

        }
        public void PermissionChange(string id, string adminid)// 로그남기기 96001
        {
            //id는 정보 주체 id   
            try
            {
                using (var model = new ModelContext())
                {
                    // 작업하는 관리자의 정보를 어디서 가져올지 생각, 세션에 저장할지  
                    var userinfo = (from data in model.Userinfos
                                    where data.UserId == id
                                    select data).SingleOrDefault();
                    // 선택한 아이디(subject)의 권한을 부여, 변경, 말소 
                    if (userinfo != null)
                    {
                        if (userinfo.UserGrifid != "SP")
                        {
                            userinfo.UserGrifid = "SP";
                        }
                        else { userinfo.UserGrifid = "PD"; }

                    }
                    else
                    {
                        MessageBox.Show("입력해주세요.");
                        return;
                        // 없으니까 종료 

                    }
                    // 작업을 한다면 세션이나 토큰에 로그인한 사용자 정보가 저장되어있으니까 사용할 수도 있겠네 
                    // 이것도
                    var log = new Permissionchangelog
                    // 권한 변경 로그 
                    {
                        //PermissionLogId = 5,
                        UserId = int.Parse(adminid),
                        AccessIp = "11111",
                        SubjectId = userinfo.UserId,
                        SubjectName = userinfo.UserName,
                        PermissionChangeDetail = "Test"
                    };
                    model.Permissionchangelogs.Add(log);

                    var Log = new Adminactivitylog
                    // 활동로그 
                    {
                        //LogId = 2,
                        AdminId = adminid,
                        AccessIp = "1",
                        SubjectId = userinfo.UserId,
                        SubjectName = userinfo.UserName,
                        ActivityId = userinfo.UserGrifid,
                        ActivityDescription = "Test"


                    };
                    model.Adminactivitylogs.Add(Log);

                    model.SaveChanges();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}
