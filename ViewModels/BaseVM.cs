using CommunityToolkit.Mvvm.ComponentModel;

namespace Mock.ViewModels
{
    public class BaseVM : ObservableRecipient
    {
        /// <summary>
        /// Cancels the operation
        /// </summary>
        public virtual void Cancel()
        {
            return;
        }

        /// <summary>
        /// Checks if the children are valid
        /// </summary>
        /// <returns></returns>
        public virtual bool IsChildrenValid()
        {
            return true;
        }

        /// <summary>
        /// Adds children
        /// </summary>
        public virtual void AddChildren()
        {
            _children = new List<BaseVM>();
        }


        public List<BaseVM> _children = new();
    }
}
