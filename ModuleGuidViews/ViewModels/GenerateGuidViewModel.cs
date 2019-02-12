using Prism.Commands;
using Prism.Mvvm;
using System;
using System.Windows;

namespace ModuleGuidViews.ViewModels
{
    public class GenerateGuidViewModel : BindableBase
    {
        public DelegateCommand GenerateGuidCommand { get; private set; }

        public DelegateCommand CopyGuidToClipBoardCommand { get; private set; }


        public GenerateGuidViewModel()
        {
            GenerateGuidCommand = new DelegateCommand(GenerateGuid);

            CopyGuidToClipBoardCommand = new DelegateCommand(CopyGuidToClipboard);
        }

        private string _guid;
        public string Guid
        {
            get { return _guid; }
            set { SetProperty(ref _guid, value); }
        }

        private void GenerateGuid()
        {
            Guid guid = System.Guid.NewGuid();
            Guid = guid.ToString();
        }

        public void CopyGuidToClipboard()
        {
            Clipboard.SetText(Guid);
        }
    }
}
