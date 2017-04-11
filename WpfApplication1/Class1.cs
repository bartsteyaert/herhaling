using System;

public class Class1
{
    // een reeks elementen overlopen
    foreach (FrameworkElement kind in boxen.Children)
        {
            if (kind is RadioButton) { }
            if (kind is CheckBox) { }
        }
//SolidColorBrush van string
Button knop = (Button)sender;
SolidColorBrush kleur = (SolidColorBrush)new BrushConverter().ConvertFromString(knop.Tag.ToString());

//focus van een element opvragen via een ander element
    <label Target = "{Binding ElementName=psdBox}" />

//absolute uri
        Source = "pack://application:,,,/Images/bold.png" >
//absolute uri referenced assembly (ander project waar huidig project reference heeft)
        pack://authoriteit/referencedAssembly;component/pad
        bv. ="pack://application:,,,/CommonLibrary;component/Images/bold.png"

    //image koppelen aan uri
    Image t = new Image();
t.Source = new BitmapImage(new Uri("pack://application:,,,/images/bold.png", UriKind.Absolute));

//DisplayMemberPath="Naam" --  SelectedValuePath="Naam"

//load comboboxes,listbox  - Window_Loaded event

// sort descriptions - using System.ComponentModel
ListBoxHobbies.Items.SortDescriptions.Add(new SortDescription("Activiteit", ListSortDirection.Ascending));

//itemtemplate
<ListBox>
    <ListBox.ItemTemplate>
        <DataTemplate>
            <Border>, stackpanel,...
        </DataTemplate>
    </ListBox.ItemTemplate>
</ListBox>

//ItemsPanelTemplate 
<ListBox>
    <ListBox.ItemsPanel>
        <ItemsPanelTemplate>
            <StackPanel Orientation = "Horizontal" />
        </ ItemsPanelTemplate >
    </ ListBox.ItemsPanel >
 </ ListBox >
 //ControlTemplate - past heel control uiterlijk aan

//resultaat van messagebox
if(MessageBox.Show("melding", "titel", MessageBoxButton.YesNo, MEsageBoxImage.Information, MessageBoxResult.No)==MessageBoxResult.Yes) {}


//shortcuts toevoegen (RoutedCommand)
xmlns:custom="clr-namespace:Bars"
    //visueel 
    <MenuItem InputGestureText = "Ctrl+B" />
    //functioneel
    public static RoutedCommand mijnRouteCtrlI = new RoutedCommand();
    <Window.CommandBindings>
        <CommandBinding Command = "{x:Static custom:BarWindow.mijnRouteCtrlI}" Executed="ctrlIExecuted" /> 
    </ Window.CommandBindings >
    <Window.InputBindings>
        <KeyBinding Key = "I" Modifiers="Control" Command="{x:Static custom:Barwindow.mijnRouteCtrlI}" />
    </Window.InputBindings>
    private void ctrlIExecuted(object sender, ExecutedRoutedEventArgs e) { }

//lettertypes toevoegen aan een combobox
<ComboBox ItemsSource = "{Binding Source={x:Static Member=Fonts.systemFontFamilies}}" >
    < ComboBox.ItemTemplate >
        < DataTemplate >
            < TextBlock FontFamily="{Binding}" Text="{Binding}"/>
        </DataTemplate>
    </ComboBox.ItemTemplate>
</ComboBox>

//Bestandsoperaties - Common dialog box - using Microsoft.Win32
//Save
try
    {
    SaveFileDialog dlg = new SaveFileDialog();
dlg.FileName="Document";
    dlg.DefaultExt=".txt";
    dlg.Filter = "Text documents |*.txt";

    if(dlg.ShowDialog()==true) 
        {
            using (StreamWriter bestand = new StreamWriter(dlg.FileName)) {}
        }
    }    catch {}

//bij openenen - converter van string naar fontweight of fontstyle
TypeConverter convertBold = TypeDescriptor.GetConvertor(typeof(FontWeight));
TextBoxVoorbeeld.FontWeight= (FontWeight)convertBold.ConvertFromString(bestand.ReadLine());

//print
PrintDialog afdrukken = new PrintDialog();
if (afdrukken.ShowDialog()== true)
    {
    afdrukken.PrintDocument(StelAfdrukSamen().DocumentPaginator, "Tekstbox");
    }
    private FixedDocument StelAfdrukSamen()
{
    FixedDocument document = new FixedDocument();
    document.DocumentPaginator.PageSize = new System.Windows.Size(breedte, hoogte);
    PageContent inhoud = new PageContent();
    document.Pages.Add(inhoud);
    FixedPage page = new FixedPage();
    inhoud.Child = page;
    page.Children.Add(TextBlock);
    page.Children.Add(Image); //.Margin = new Thickness()
}

//print preview -DocumentViewer
    //2e window AfdrukVoorbeeld.xaml
    <Window>
        <DocumentViewer Name = "printpreview" />
    </ Window >
    //codebehind 
    public IDocumentPaginatorSource AfdrukDocument
{
    get { return printpreview.Document; }
    set { printpreview.Document = value; }
}
//in eerste venster
AfdrukVoorbeeld preview = new AfdrukVoorbeeld();
preview.Owner = this;
preview.AfdrukDocument = StelAfdrukSamen(); //FixedDocument
preview.ShowDialog();


// afsluiten
Window_Closing -- if (messagebox.Show(...)==MessageBoxResult.No)
    e.Cancel = true;
}

//Resources
    //in window zelf
    <Window.Resources>
      <Color x:Key="paarsColor" ... />
      <SolidColorBrush x:Key="paarBrush" Color="{StaticResource paarsColor}">
    </Window.Resources>
    //in resource dictionary
    //bij app.xaml
    <Application.Resources>
      <ResourceDictionary>
        <ResourceDictionary.MergedDictionaries>
          <ResourceDictionary Source = "resource/.." />
          < ResourceDictionary Source="resource/.." />
        </ResourceDictionary.MergedDictionaries>
      </ResourceDictionary>
    </Application.Resources>


//kleuren invullen in eigen klasse Kleur- bij constructor
foreach (PropertyInfo info in typeof(Colors).GetProperties()) 
{
    BrushConverter bc = new BrushConverter();
SolidColorBrush deKleur = (SolidColorBrush)bc.ConvertFromString(info.Name);
Kleur kleurke = new Kleur();
kleurke.Borstel = deKleur; //Solidcolorbrush
    kleurke.Naam = Info.Naam;
    kleurke.Hex = deKleur.ToString();
    kleurke.Rood =deKleur.Color.R;
    ..
}

//kleur van rgb waarden bij bvb slider gebruiken
rechthoek.Fill = new SolidColorBrush(Color.FromRgb(Convert.ToByte(labelRed.Content.ToString()), Convert.ToByte(labelGreen.Content.ToString()), Convert.ToByte(labelBlue.Content.ToString())));

//style
<Style x:Key="buttonKleur" TargetType="{x:Type Button}" >
    <Setter Property = "Foreground" Value="Blue" />
    <Style.Triggers>
        <Trigger Property = "IsMouseOver" Value="True">
            <Setter Property = "Foreground" Value="Red" />
        </Trigger>
    </Style.Triggers>
</Style>

    //toepassen
    <Button Style = "{StaticResource buttonKleur}".. />

//Binding
Mode = OneWay,
UpdateSourceTrigger = PropertyChanged,

//DataContext
<ComboBox Name = "lettertypeComboBox" Width="180"
Style="{StaticResource baseControlStijl}"
DataContext="{x:Static Member=Fonts.SystemFontFamilies}"
ItemsSource="{Binding}">
  <ComboBox.ItemTemplate>
    <DataTemplate>
      <TextBlock FontFamily = "{Binding}" Text="{Binding}"/>
    </DataTemplate>
  </ComboBox.ItemTemplate>
</ComboBox>

//INotifyPropertyChanged
klasse implmenteerd INotifyPropertyChanged
public event PropertyChangedEventHandler PropertyChanged;
set
    {
    Naam =value;
    RaisePropertyChanged("Naam");
    }
private void RaisePropertyChanged(String info)
{
    if (PropertyChanged != null)
    {
        PropertyChanged(this, new PropertyChangedEventArgs(info));
    }
}

//ConverterCulture
xmlns:global="clr-namespace:System.Globalization;assembly=mscorlib"
Text="{Binding Path=Wedde, StringFormat=C, ConverterCulture={x:Static global:CultureInfo.CurrentCulture}}

//DragDrop
    //Drag
private Rectangle sleeprechthoek = new Rectangle();
private void Rectangle_MouseMove(object sender, MouseEventArgs e)
{
    sleeprechthoek = (Rectangle)sender;
    if (e.LeftButton = MouseButtonState.Pressed)
    {
        DataObject sleepkleur = new DataObject("deKleur", sleeprechthoek.Fill);
        DragDrop.DoDragDrop(sleeprechthoek, sleepkleur, DragDropEffects.Move);
    }
}
//Drop
events=DragEnter, DragLeave, Drop
    properties - AllowDrop = "true"
    private void Rectangle_Drop(object sender, DragEventArgs e)
{
    if (e.Data.GetDataPresent("deKleur")) //controleren dat juiste object gesleept wordt 
    {
        Brush gesleeptekleur = (Brush)e.Data.GetData("deKleur");
        ...
    }


    //Drag bij ListBoxItem
private ListBoxItem VindListBoxItem(object sleepitem)
{
    DependecyObject keuze = (DependecyObject)sleepitem;
    while (keuze != null)
    {
        if (keuze is ListBoxItem)
            return keuze;
        keuze = VisualTreeHelper.GetParent(keuze);
    }
    return null;
}
private ListBox draglijst
private void DragListBox_MouseMove(object sender, MouseEventArgs e)
{
    if (e.LeftButton == MouseButtonState.Pressed)
    {
        draglijst = (ListBox)sender;
        ListBoxItem programmaitem = VindListBoxItem(e.OriginalSource);
        if (draglijst.SelectedIndex >= 0 && programmaitem != null)
        {
            DataObject sleepdata = new DataObject("mijnprogramma", programmaitem.Content);
            DragDrop.DoDragdrop(programmaitem, sleepdata, DragDropEffects.Move);
        }
    }
}

//