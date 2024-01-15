using CommunityToolkit.Mvvm.ComponentModel;

namespace MEMO.Model
{
    public class MemoInfo : ObservableObject
    {
        private string _content;
        private string _filePath;
        private string _title;

        public string Content
        {
            get { return _content; }
            set { SetProperty(ref _content, value); }
        }

        public string FilePath
        {
            get { return _filePath; }
            set { SetProperty(ref _filePath, value); }
        }

        public string Title
        {
            get { return _title; }
            set { SetProperty(ref _title, value); }
        }

        public MemoInfo(string content, string filePath)
        {
            this._content = content;
            this._filePath = filePath;
            this._title = System.IO.Path.GetFileName(filePath);
        }

        public MemoInfo()
        {
            this._content = string.Empty;
            this._filePath = "/";
            this._title = "No Title";
        }
    }
}
