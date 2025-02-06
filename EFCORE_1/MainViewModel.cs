using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace EFCORE_1
{
    public class MainViewModel : INotifyPropertyChanged
    {
        private string _selectedOption;  // 선택된 값을 저장하는 변수
        public ObservableCollection<string> Options { get; set; }

        public string SelectedOption
        {
            get { return _selectedOption; }
            set
            {
                _selectedOption = value;
                OnPropertyChanged(nameof(SelectedOption)); // UI 업데이트
            }
        }
        public ICommand ExecuteCommand { get; }
        public MainViewModel()
        {
            Options = new ObservableCollection<string>
            {
                "SP",
                "PD",
                "Option 3"
            };
            ExecuteCommand = new RelayCommand(param => ExecuteMethod());
            // 버튼 눌렀을 때 실행 될 수 있게하는 객체 생성 
        }
        private void ExecuteMethod()
        {
            var TestClass = new TestClass();
            TestClass.PermissionChange();
        }

        public event PropertyChangedEventHandler? PropertyChanged;
        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
