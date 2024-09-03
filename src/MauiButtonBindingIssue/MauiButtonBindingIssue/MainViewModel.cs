using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace MauiButtonBindingIssue;

public partial class MainViewModel : ObservableObject
{
    private const string _defaultButtonAText = "A";
    private const string _defaultButtonBText = "B";
    
    [ObservableProperty] 
    private string _buttonAText = _defaultButtonAText;

    [ObservableProperty] 
    private string _buttonBText = _defaultButtonBText;
    
    [RelayCommand]
    private void ClearButtonAText()
    {
        ButtonAText = " ";
    }
    
    [RelayCommand]
    private void ClearButtonBText()
    {
        ButtonBText = " ";
    }
    
    [RelayCommand]
    private void ResetButtonsText()
    {
        ButtonAText = _defaultButtonAText;
        ButtonBText = _defaultButtonBText;
    }
}