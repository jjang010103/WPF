using CommunityToolkit.Mvvm.ComponentModel;
using KinderGarten.Model;
using KinderGarten.Store;
using System.Collections.ObjectModel;

namespace KinderGarten.ViewModel
{
    public class Page1ViewModel : ObservableObject
    {
        private ChildrenStore _childList;

        public ChildrenStore ChildList
        {
            get
            {
                return this._childList;
            }
            set
            {
                this.SetProperty(ref this._childList, value);
            }
        }

        public Page1ViewModel(ChildrenStore store)
        {
            this._childList = store;
        }
    }
}
