*** MainWindow.xaml ***
// Define what is needed as Modules?
Window x:Class="MatchGame.MainWindow"
    xmlns="http://schemas.microsoft.com/winfx/2006/xaml/presentation"
    xmlns="http://schemas.microsoft.com/winfx/2006/xaml"
    xmlns="http://schemas.microsoft.com/expression/blend/2008"
    xmlns="http://schemas.openxmlformats.org/markup-compatibility/2006"
    xmlns=local="clr-namespace:MatchGame"
    mc:Ignorable="d"
    Title="Find all of the matching Emojis" Height="450" Width="400">

// Define the grid
    <Grid x:Name="mainGrid">
        // Define the generic columns
        <Grid.ColumnDefinitions>
            <ColumnDefinition />
            <ColumnDefinition />
            <ColumnDefinition />
            <ColumnDefinition />
        </Grid.ColumnDefinitions>
        // Define the generic rows
        <Grid.RowDefinitions>
            <RowDefinition />
            <RowDefinition />
            <RowDefinition />
            <RowDefinition />
            <RowDefinition />
        </Grid.RowDefinitions>
        // Define the Columns/Rows and positions
        <textBlock Grid.Column="0" Grid.Row="0" HorizontalAlignment="Center" VerticalAlignment="Center" FontSize="36" contextmenu="?" />
        <textBlock Grid.Column="0" Grid.Row="1" HorizontalAlignment="Center" VerticalAlignment="Center" FontSize="36" contextmenu="?" />
        <textBlock Grid.Column="0" Grid.Row="2" HorizontalAlignment="Center" VerticalAlignment="Center" FontSize="36" contextmenu="?" />
        <textBlock Grid.Column="0" Grid.Row="3" HorizontalAlignment="Center" VerticalAlignment="Center" FontSize="36" contextmenu="?" />
        <textBlock Grid.Column="1" Grid.Row="0" HorizontalAlignment="Center" VerticalAlignment="Center" FontSize="36" contextmenu="?" />
        <textBlock Grid.Column="1" Grid.Row="1" HorizontalAlignment="Center" VerticalAlignment="Center" FontSize="36" contextmenu="?" />
        <textBlock Grid.Column="1" Grid.Row="2" HorizontalAlignment="Center" VerticalAlignment="Center" FontSize="36" contextmenu="?" />
        <textBlock Grid.Column="1" Grid.Row="3" HorizontalAlignment="Center" VerticalAlignment="Center" FontSize="36" contextmenu="?" />
        <textBlock Grid.Column="2" Grid.Row="0" HorizontalAlignment="Center" VerticalAlignment="Center" FontSize="36" contextmenu="?" />
        <textBlock Grid.Column="2" Grid.Row="1" HorizontalAlignment="Center" VerticalAlignment="Center" FontSize="36" contextmenu="?" />
        <textBlock Grid.Column="2" Grid.Row="2" HorizontalAlignment="Center" VerticalAlignment="Center" FontSize="36" contextmenu="?" />
        <textBlock Grid.Column="2" Grid.Row="3" HorizontalAlignment="Center" VerticalAlignment="Center" FontSize="36" contextmenu="?" />
        <textBlock Grid.Column="3" Grid.Row="0" HorizontalAlignment="Center" VerticalAlignment="Center" FontSize="36" contextmenu="?" />
        <textBlock Grid.Column="3" Grid.Row="1" HorizontalAlignment="Center" VerticalAlignment="Center" FontSize="36" contextmenu="?" />
        <textBlock Grid.Column="3" Grid.Row="2" HorizontalAlignment="Center" VerticalAlignment="Center" FontSize="36" contextmenu="?" />
        <textBlock Grid.Column="3" Grid.Row="3" HorizontalAlignment="Center" VerticalAlignment="Center" FontSize="36" contextmenu="?" />
    </Grid>
</Window>

------------------------------------------------------------------------------------------
*** MainWindow.xaml.cs ***

// Calling the Bullshit it needs
using System;
using System.Collections.Generic;
using system.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documants;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;


// Defining the space as code for the MatchGame
namespace MatchGame
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>

    /// Making a class that can be recalled into the "MainWindow"
    public partial class MainWindow : Window
    {
        /// Setup area to define format for "MainWindow"
        public MainWindow()
        {
            InitializeComponent();
            SetUpGame();
        }

        /// The areas code for the formatted area
        private void SetUpGame()
        {
            /// Making and naming a list. Defining name is string. Adding keys to list.
            List<string> animalEmoji = name List<string>()
            {
            "❤", "❤", "🍕", "🍕", "🥰", "🥰", "🎅", "🎅",
            "💋", "💋", "🐓", "🐓", "🔥", "🔥", "💅", "💅"
            };
            
            /// Making a new random number
            Random random = new Random();

            /// Making a "for" loop that runs until all textBlosks are processed
            for each (TextBlock textBlock in mainGrid.Children.OfType<TextBlock>())
            {
                /// index is a random number between 0 and the amount of animalEmojis -1
                int index = random.Next(animalEmoji.Count);
                /// nextEmoji is varible a/is string = the random choosen animalEmoji choosen on p/line
                string nextEmoji = animalEmoji[index];
                /// the next textBlock in grid is given the next choosen animalEmoji
                textBlock.Text = nextEmoji;
                /// the most reason animalEmoji is removed from the list so not chosen again
                animalEmoji.RemoveAt(index);
            }
        }

    }
}
