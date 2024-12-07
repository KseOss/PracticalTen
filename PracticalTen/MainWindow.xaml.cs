using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace PracticalTen
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        //код
        private void btnCount_Click(object sender, RoutedEventArgs e)
        {
            //инициализация массива значениями в диапазоне [0; 10]
            int[] numbers = { 5, 5, 10, 5, 7, 7, 7, 4, 8, 5 };
            //исп. обобщенное коллекции для хранения резултатов 
            List<int> results = new List<int>(numbers);
            //подсчет количества значений 5 и 7
            int countFive = results.Count(n => n == 5); //подсчет количества 5
            int countSeven = results.Count(n => n == 7); // подсчет количества 7
            //отображение результата в текстовом блоке
            resultTB.Text = $"Кол-во 5: {countFive}\nКол-во 7: {countSeven}";
        }

        private void Exit_Click(object sender, RoutedEventArgs e) //Создание кнопки для меню "Справка" - выход
        {
            this.Close();
        }

        // Обработчик кнопки "О программе"
        private void About_Click(object sender, RoutedEventArgs e) //Создание кнопки для меню "Справка" - о программе
        {
            MessageBox.Show("Разработчик: Сухомяткина Ксения\nНомер работы: 8\nЗадание: Создать интерфейсы - автомобиль, пассажирский транспорт. Создать класс автобус. Класс должен включать конструктор, функцию для формирования строки информации об автобусе. Сравнение производить по вместимости пассажиров.", "О программе");
        }
    }
}