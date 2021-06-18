using System;
using System.Windows;

namespace DiagramDesigner
{
    public partial class Window1 : Window
    {
        public Window1()
        {
            InitializeComponent();
            this.MaxHeight = SystemParameters.MaximizedPrimaryScreenHeight;
        }

        #region HeaderButtons
        private void CloseApp(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            try
            {
                Close();
            }
            catch (Exception ex) { MessageBox.Show("Непредвиденная ошибка: " + ex.Message); }
        }
        private void MinimizeApp(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            try
            {
                this.WindowState = WindowState.Minimized;
            }
            catch (Exception ex) { MessageBox.Show("Непредвиденная ошибка: " + ex.Message); }
        }
        private void MaximizeWindow(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            try
            {
                if (this.WindowState == WindowState.Maximized)
                    this.WindowState = WindowState.Normal;
                else
                    this.WindowState = WindowState.Maximized;
            }
            catch (Exception ex) { MessageBox.Show("Непредвиденная ошибка: " + ex.Message); }
        }
        #endregion

        private void MoveWindow(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            if (e.GetPosition(this).X < this.Width - 40)
            if (e.LeftButton == System.Windows.Input.MouseButtonState.Pressed)
            {
                DragMove();
            }
        }
    }
}
