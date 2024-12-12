using Avalonia.Controls;
using System.IO;
using Avalonia.Interactivity;
using Avalonia.Platform.Storage;
using System.Collections.Generic;
using System;
using System.Runtime.CompilerServices;
using System.Reflection;
using Avalonia.Input;

namespace is_fortytwo;

public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
        this.KeyDown += KeyEvent;
    }

    public void KeyEvent(object sender, KeyEventArgs e){
        if(e.Key == Key.Enter){
            Button_Click(null,null);
        }
    }


    public void Button_Exit_Click(object sender, RoutedEventArgs e){
        Environment.Exit(-1);
    }

    
    public void Button_Restart_Click(object sender, RoutedEventArgs e){
        GrdResult.IsVisible = false;
        GrdEdit.IsVisible = true;

        TbNumber.Focus();
    }
    public void Button_Click(object sender, RoutedEventArgs e){
            GrdResult.IsVisible = true;
            GrdEdit.IsVisible = false;
        try{
            if(Convert.ToInt64(TbNumber.Text) == 42){
            
                LblResult.Content = "Congratulations!\nYour number is equal to 42";
            } else {
                LblResult.Content = "Sadly, your number is NOT equal to 42 :(";
            }
        } catch {
            LblResult.Content = "You did it wrong!\nPlease enter a NUMBER, nothing else...";
        }
        
    }
}