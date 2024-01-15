using CommunityToolkit.Mvvm.ComponentModel;
using MEMO.Model;
using System.Collections.ObjectModel;

namespace MEMO.ViewModel
{
    internal class MemoViewInfo : ObservableObject
    {
        private ObservableCollection<MemoInfo> _memoList;

        public ObservableCollection<MemoInfo> MemoList
        {
            get { return _memoList; }
            set { SetProperty(ref _memoList, value); }
        }

        public MemoViewInfo()
        {
            this._memoList = new ObservableCollection<MemoInfo>();
            this._memoList.Add(new MemoInfo());
        }

        public void AddMemo()
        {
            this.MemoList.Add(new MemoInfo());
        }
    }
}
