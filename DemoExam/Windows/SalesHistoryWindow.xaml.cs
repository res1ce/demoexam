using DemoExam.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.ObjectModel;
using System.Linq;
using System.Windows;
using YourNamespace;

namespace DemoExam.Windows
{
    public partial class SalesHistoryWindow : Window
    {
        public ObservableCollection<Sales> SalesHistory { get; set; }

        public SalesHistoryWindow(Partner partner)
        {
            InitializeComponent();
            DataContext = this;

            var options = new DbContextOptionsBuilder<ApplicationDbContext>()
                .UseSqlite("Data Source=Partners.db")
                .Options;

            using (var context = new ApplicationDbContext(options))
            {
                SalesHistory = new ObservableCollection<Sales>(
                    context.Sales.Where(history => history.partner_id == partner.PartnerId).Include(s => s.product).ToList()
                );
            }
        }
    }
}
