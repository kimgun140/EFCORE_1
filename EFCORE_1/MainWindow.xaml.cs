using EFCORE_1.Model;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel;
using System.Runtime.Intrinsics.Arm;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Security.Cryptography;
using Org.BouncyCastle.Crypto.Modes;
using Org.BouncyCastle.Crypto.Engines;
using Org.BouncyCastle.Crypto.Paddings;
using Org.BouncyCastle.Crypto.Parameters;
using Org.BouncyCastle.Crypto.Operators;
using System.Windows.Media.TextFormatting;

namespace EFCORE_1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        //private BackgroundWorker worker;
        public MainWindow()
        {
            InitializeComponent();
            DataContext = new MainViewModel();

     
        }
        void read(string id)
        {

            using (var model = new ModelContext())
            {


                // 입력한 아이디가 유저테이블에 있는지 있다면 권한이 SP인지 확인 (로그인)

                var userdata = (from Userinfo in model.Userinfos
                                where Userinfo.UserId == id && Userinfo.UserGrifid == "SP"
                                select Userinfo).SingleOrDefault();
                if (userdata != null)
                {
                    ss.Text += userdata.UserName;
                }

                //foreach (var item in userdata)
                //{
                //    ss.Text += item.UserName;
                //}

                //var  admin = from Userinfo in model.Userinfos where Userinfo.UserGrifid == "SP" select Userinfo;
                //foreach( var data in admin)
                //{
                //    ss.Text += data.UserName +"\n";
                //}

                //ss.Text = admin.ToString();

            }
        }
       
        private void Work_Btn_Click(object sender, RoutedEventArgs e)
        {
            var TestClass = new TestClass();
            string id = ChagePermision.Text;
            string adminid = text_id.Text;
            string adminpw = PW_text.Text;
            // 입력한 권한으로 변경 여기서 동적쿼리
            TestClass.PermissionChange(id, adminid);


        }
        private void Button_Click(object sender, RoutedEventArgs e)
        // 아이디 비밀번호 입력받아서 저장하기 (회원가입테스트 ) 
        {
            string id = text_id.Text;
            string pw = PW_text.Text;

            Create_User(id, pw);


        }
        public string Encryption(string pw, string salt)
        {

            using (SHA256 sha256 = SHA256.Create())
            {

                byte[] inputBytes = Encoding.UTF8.GetBytes(pw + salt);// 
                // 입력한 비밀번호+ 솔트
                byte[] hashBytes = sha256.ComputeHash(inputBytes);// 비밀번호를 256비트 (32바이트) 해시 값으로 변환 , 해당 값을 문자열로 변환하게 되면 64자리 16진수 문자열 (64바이트)가 된다. 

                StringBuilder hashString = new StringBuilder();
                foreach (byte b in hashBytes)
                {
                    hashString.Append(b.ToString("x2"));
                }
                ss.Text = hashString.ToString(); // 해싱 데이터 문자열로 변환한거 확인하기 
                int bytecount = System.Text.Encoding.Default.GetByteCount(ss.Text);
                ChagePermision.Text = bytecount.ToString();

                return hashString.ToString();
                //64바이트네 문자열로 변환하면 
            };
        }
        void Create_User(string id, string pw)
        // 단방향 암호화 사용(sha256)해 문자열로 변환해 저장
        {
            string salt = GenerateSalt();
            // 입력받은 비밀번호랑 생성된 솔트를 
            string password = Encryption(pw, salt);

            int Rid = int.Parse(id);
            using (var model = new ModelContext())
            {
                var new_userinfo = new AatestTablePk
                {
                    Id = Rid,
                    Name = password,// 입력 비밀번호+ 솔트를 암호화한 데이터 저장됨 
                    //CreatedDate = DateTime.Now,
                    Description = salt,
                    //salt 저장해봐야함 
                    //Url = pw,

                };
                model.AatestTablePks.Add(new_userinfo);
                model.SaveChanges();

            }
        }
        public static string GenerateSalt()
        // 무작위 솔트 생성 
        {
            byte[] saltBytes = new byte[16]; // 16바이트 솔트
            using (RandomNumberGenerator rng = RandomNumberGenerator.Create())
            {
                rng.GetBytes(saltBytes);
            }
            return Convert.ToBase64String(saltBytes); // Base64로 변환하여 저장, 문자열로 변환해 반환 
        }
        void savePN()
        {
            string key = "1234567890123456";  // 16바이트 (128비트) 대칭키 16바이트이어야함 

            string iv = "1234567890123456"; // 16바이트 초기화 벡터 CBC(Cipher Block Chaining) 모드는 블록 암호화 방식에서 이전 암호화된 블록의 결과를 다음 블록 암호화에 사용합니다.

        }
        static byte[] yangEncrypt(string key, string iv, string plaintext)
        //양방향 암호화 
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
        static string Decrypt(byte[] cipherText, string key, string iv)
        {
            var engine = new CbcBlockCipher(new SeedEngine()); // SEED 알고리즘 + CBC 모드
            var cipher = new PaddedBufferedBlockCipher(engine, new Pkcs7Padding());
            var keyParam = new KeyParameter(Encoding.UTF8.GetBytes(key));
            var ivParam = new ParametersWithIV(keyParam, Encoding.UTF8.GetBytes(iv));

            cipher.Init(false, ivParam); // false: 복호화 모드

            byte[] outputBytes = cipher.DoFinal(cipherText);
            return Encoding.UTF8.GetString(outputBytes);
        }

        private void LoginTest_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                var asdf = new TestClass();
                var testInputid = int.Parse(text_id.Text);

                var saveddata = asdf.LoginVerifying(testInputid);
                // 입력된 아이디가 디비에 있는지 확인 없으면 "" 반환 , 회원가입된 경우 아이디 반환 

                using (var model = new ModelContext())
                {
                    var Saved_saltdata = (from Userinfo in model.AatestTablePks
                                          where Userinfo.Id == testInputid
                                          select Userinfo).SingleOrDefault();

                    if (Saved_saltdata == null)
                    // 입력한 아이디 없을때 
                    {
                        MessageBox.Show("일치하는 아이디 없습니다.");
                    }
                    // 아이디는 일치하는 데이터가 있지만 비밀번호가 틀린경우 


                    var salt = Saved_saltdata.Description;
                    var inputpw = LoginTestText.Text;// 로그인할 때 사용 할 비밀번호 

                    var outputPw = Encryption(inputpw, salt);
                    // 아이디에 해당하는 솔트를 찾아서 비밀번호 검증에 사용 
                    if (outputPw == saveddata)
                    {
                        MessageBox.Show(outputPw);
                        MessageBox.Show(saveddata);
                        MessageBox.Show("good");
                        Saved_saltdata.Url = "0";
                        // 로그인 성공 했을 때 초기화 
                    }
                    else
                    {
                        int Failed_count = int.Parse(Saved_saltdata.Url);
                        ++Failed_count;
                        Saved_saltdata.Url = Failed_count.ToString();
                    }
                    model.SaveChanges();


                }
            }
            catch (Exception ex)

            {

                MessageBox.Show(ex.Message);
            }


        }

        private void Serach_Btn_click(object sender, RoutedEventArgs e)// 검색버튼 
        {
            var search = new TestClass();
            var activityid = serach_activityid.Text;
            var adminid = serach_adminid.Text;
            var subjectid = serach_subjectid.Text;
            var result = search.Search(adminid, subjectid, activityid);

            foreach (var item in result)
            {
                searchresult.Text += $"ID: {item.AdminId}, SubjectId: {item.SubjectId}, ActivityId: {item.ActivityId} \n";

            }
        }

        private void JoinTest_Click(object sender, RoutedEventArgs e)
        {
            var search = new TestClass();
            var id = int.Parse(serach_adminid.Text);
            var adminactivitylogs = search.JoinTest(id);

            foreach (var item in adminactivitylogs)
                searchresult.Text += $"ID: {item.AdminId}, SubjectId: {item.SubjectId},DateTime: {item.ActivityDatetime} , ActivityDescription: {item.ActivityDescription} \n";

        }
    }
}