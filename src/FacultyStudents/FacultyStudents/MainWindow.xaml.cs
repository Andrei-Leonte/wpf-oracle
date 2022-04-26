using FacultyStudents.Application.Interafaces.Services;
using System;
using System.Windows;

namespace FacultyStudents
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private readonly IStudentService studentService;
        public MainWindow()
        {
            var servicess = this.UseStartup();

            studentService = (IStudentService)servicess.GetService(typeof(IStudentService));

            InitializeComponent();
        }

        private async void button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                var students = await studentService.GetAllAsync();
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
    }
}
