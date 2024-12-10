using Avalonia.Controls;
using System.IO;
using Avalonia.Interactivity;
using Avalonia.Platform.Storage;
using System.Collections.Generic;
using System;
using System.Runtime.CompilerServices;
using System.Reflection;

namespace is_fortytwo;

public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
    }

    public void Button_Exit_Click(object sender, RoutedEventArgs e){
        Environment.Exit(-1);
    }
    public void Button_Click(object sender, RoutedEventArgs e){
            GrdResult.IsVisible = true;
            GrdEdit.IsVisible = false;
        try{
            if(Convert.ToInt32(TbNumber.Text) == 42){
            
                LblResult.Content = "Congratulations!\nYour number is equal to 42!";
            } else {
                LblResult.Content = "Sadly, your number is NOT equal to 42! :(";
            }
        } catch {
            LblResult.Content = "You did it wrong!\nPlease enter a NUMBER, nothing else...";
        }
        
    }
}