Imports Microsoft.VisualBasic
Imports System.Windows
' ...

Namespace WpfApplication1
	''' <summary>
	''' Interaction logic for MainWindow.xaml
	''' </summary>
	Partial Public Class MainWindow
		Inherits Window
		Public Sub New()
			InitializeComponent()
			DataContext = New MainWindowViewModel()
		End Sub
	End Class
End Namespace
