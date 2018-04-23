Imports Microsoft.VisualBasic
Imports System.ComponentModel
Imports System.Windows
Imports System.Windows.Input
Imports DevExpress.Xpf.Core.Commands
' ...

Namespace WpfApplication1
	Public Class MainWindowViewModel
		Private buttonContent_Renamed As String = "Press me!"
		Public Property ButtonContent() As String
			Get
				Return buttonContent_Renamed
			End Get
			Set(ByVal value As String)
				buttonContent_Renamed = value
				RaisePropertyChanged("ButtonContent")
			End Set
		End Property

		Private privateDoWork As ICommand
		Public Property DoWork() As ICommand
			Get
				Return privateDoWork
			End Get
			Private Set(ByVal value As ICommand)
				privateDoWork = value
			End Set
		End Property

		Public Sub New()
			DoWork = New DevExpress.Xpf.Mvvm.DelegateCommand(Of Object)(Function(ignore) MessageBox.Show("The custom button has been clicked."))
		End Sub

		#Region "INotifyPropertyChanged"
		Public Event PropertyChanged As PropertyChangedEventHandler
		Private Sub RaisePropertyChanged(ByVal propertyName As String)
			RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs(propertyName))
		End Sub
		#End Region

	End Class
End Namespace