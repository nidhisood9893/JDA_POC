using System;
using System.Collections.ObjectModel;
using System.Windows.Input;

using Xamarin.Forms;

namespace POC.ViewModels
{
    public class AboutViewModel : BaseViewModel
    {
        public ObservableCollection<History> LeavesHistory { get; set; }

        public AboutViewModel()
        {
            Title = "EMP24012";
            LeavesHistory = new ObservableCollection<History>();
            PopulateStaticData();
            OpenWebCommand = new Command(() => Device.OpenUri(new Uri("https://xamarin.com/platform")));
        }

        /// <summary>
        /// Populating static data
        /// </summary>
        private void PopulateStaticData()
        {            
            LeavesHistory.Add(new History
            {
                Title="Casual Leaves",
                Leaves = 3,
                FromDate = "22 Aug 2018",
                ToDate = "24 Aug 2018",
                Status=ApprovalStatus.Pending
            });
            LeavesHistory.Add(new History
            {
                Title="Comp off",
                Leaves = 1,
                FromDate = "18 Jul 2018",
                ToDate = "18 Jul 2018",
                Status = ApprovalStatus.Rejected
            });
            LeavesHistory.Add(new History
            {
                Title="Sick Leave",
                Leaves = 1,
                FromDate = "06 Jun 2018",
                ToDate = "06 Jun 2018",
                Status = ApprovalStatus.Approved
            });
            LeavesHistory.Add(new History
            {
                Title="Leave without Pay",
                Leaves = 6,
                FromDate = "5 Feb 2018",
                ToDate = "10 Feb 2018",
                Status = ApprovalStatus.Approved
            });
            LeavesHistory.Add(new History
            {
                Title = "Casual Leaves",
                Leaves = 4,
                FromDate = "02 Jan 2018",
                ToDate = "06 Jan 2018",
                Status = ApprovalStatus.Approved
            });
        }

        public ICommand OpenWebCommand { get; }
    }
}