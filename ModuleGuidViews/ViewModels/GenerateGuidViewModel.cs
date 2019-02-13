using Prism.Commands;
using Prism.Mvvm;
using System;
using System.Windows;

namespace GuidGeneratorViews.ViewModels
{
    public class GenerateGuidViewModel : BindableBase
    {
        public DelegateCommand GenerateGuidCommand { get; private set; }

        public DelegateCommand CopyGuidToClipBoardCommand { get; private set; }


        public GenerateGuidViewModel()
        {
            GenerateGuidCommand = new DelegateCommand(GenerateGuid);
            CopyGuidToClipBoardCommand = new DelegateCommand(CopyGuidToClipboard);

            IsLowerCase = true;
        }

        private string _guid;
        public string Guid
        {
            get { return _guid; }
            set { SetProperty(ref _guid, value); }
        }

        private bool _isLowerCase;
        public bool IsLowerCase
        {
            get { return _isLowerCase; }
            set { SetProperty(ref _isLowerCase, value); }
        }

        private void GenerateGuid()
        {
            Guid guid = System.Guid.NewGuid();
            Guid = IsLowerCase ? guid.ToString() : guid.ToString().ToUpper();
        }

        public void CopyGuidToClipboard()
        {
            Clipboard.SetText(Guid);
        }
    }
}
