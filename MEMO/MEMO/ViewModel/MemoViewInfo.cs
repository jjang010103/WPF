using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using MEMO.Model;
using Microsoft.Win32;
using System.Collections.ObjectModel;
using System.IO;
using System.Security.Cryptography;
using System.Windows.Input;

namespace MEMO.ViewModel
{
    internal partial class MemoViewInfo : ObservableObject
    {
        public ICommand Cmd_NewMemo { get; private set; }
        public ICommand Cmd_LoadMemo { get; private set; }
        public ICommand Cmd_CloseMemo { get; private set; }
        public ICommand Cmd_SaveMemo { get; private set; }
        public ICommand Cmd_TabControl_SelectionChanged { get; private set; }

        private int _selectedIndex;

        private ObservableCollection<MemoInfo> _memoList;

        public ObservableCollection<MemoInfo> MemoList
        {
            get { return _memoList; }
            set { SetProperty(ref _memoList, value); }
        }

        public MemoViewInfo()
        {
            this.Cmd_NewMemo = new RelayCommand(this.NewMemo);
            this.Cmd_LoadMemo = new RelayCommand(this.LoadMemo);
            this.Cmd_CloseMemo = new RelayCommand(this.CloseMemo);
            this.Cmd_SaveMemo = new RelayCommand(this.SaveMemo);
            this.Cmd_TabControl_SelectionChanged = new RelayCommand<int>(this.ChangeSelectedIndex);

            this._memoList = new ObservableCollection<MemoInfo>();
            this._memoList.Add(new MemoInfo());
        }

        private void NewMemo()
        {
            this.MemoList.Add(new MemoInfo());
        }

        private void LoadMemo()
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == true)
            {
                this.MemoList.Add(new MemoInfo(File.ReadAllText(ofd.FileName), ofd.FileName));
            }
        }

        private void CloseMemo()
        {
            if (this.MemoList.Count == 1) return;

            this.MemoList.RemoveAt(this._selectedIndex);
        }

        private void SaveMemo()
        {
            SaveFileDialog ofd = new SaveFileDialog();
            if (ofd.ShowDialog() == true)
            {
                File.WriteAllText(ofd.FileName, this.MemoList[this._selectedIndex].Content);

                this.MemoList[this._selectedIndex].ChangeFilePathData(ofd.FileName);
            }
        }

        private void ChangeSelectedIndex(int tabIndex)
        {
            this._selectedIndex = tabIndex;
        }
    }
}
