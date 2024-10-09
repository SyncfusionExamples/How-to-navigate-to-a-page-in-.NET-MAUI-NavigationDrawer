# How-to-navigate-to-a-page-in-.NET-MAUI-NavigationDrawer
This section explains, how to navigate to a page in .NET MAUI NavigationDrawer

**XAML**
```
<navigationdrawer:SfNavigationDrawer x:Name="navigationDrawer">
        <navigationdrawer:SfNavigationDrawer.DrawerSettings>
            <navigationdrawer:DrawerSettings DrawerWidth="250"
                                     DrawerHeaderHeight="160">
                <navigationdrawer:DrawerSettings.DrawerHeaderView>
                    <Grid BackgroundColor="#6750A4" RowDefinitions="120,40">
                        <Image Source="user.png"
                       HeightRequest="110"
                       Margin="0,10,0,0"
                       BackgroundColor="#6750A4"
                       VerticalOptions="Center"
                       HorizontalOptions="Center"/>
                        <Label Text="James Pollock"
                       Grid.Row="1"
                       HorizontalTextAlignment="Center"
                       HorizontalOptions="Center"
                       FontSize="20"
                       TextColor="White"/>
                    </Grid>
                </navigationdrawer:DrawerSettings.DrawerHeaderView>
                <navigationdrawer:DrawerSettings.DrawerContentView>
                    <ListView x:Name="listView"
                      ItemSelected="listView_ItemSelected">
                        <ListView.ItemTemplate>
                            <DataTemplate>
                                <ViewCell>
                                    <VerticalStackLayout HeightRequest="40">
                                        <Label Margin="10,7,0,0"
                                       Text="{Binding}"
                                       FontSize="16"
                                       TextColor="Black"/>
                                    </VerticalStackLayout>
                                </ViewCell>
                            </DataTemplate>
                        </ListView.ItemTemplate>
                    </ListView>
                </navigationdrawer:DrawerSettings.DrawerContentView>
            </navigationdrawer:DrawerSettings>
        </navigationdrawer:SfNavigationDrawer.DrawerSettings>
        <navigationdrawer:SfNavigationDrawer.ContentView>
            <Grid x:Name="mainContentView" 
      BackgroundColor="White" RowDefinitions="Auto,*">
                <HorizontalStackLayout BackgroundColor="#6750A4" Spacing="10" Padding="5,0,0,0">
                    <ImageButton x:Name="hamburgerButton"
                         HeightRequest="50"
                         WidthRequest="50"
                         HorizontalOptions="Start"
                         Source="hamburgericon.png"
                         BackgroundColor="#6750A4"
                         Clicked="hamburgerButton_Clicked"/>
                    <Label x:Name="headerLabel" 
               HeightRequest="50" 
               HorizontalTextAlignment="Center" 
               VerticalTextAlignment="Center" 
               Text="Home" FontSize="16" 
               TextColor="White" 
               BackgroundColor="#6750A4"/>
                </HorizontalStackLayout>
                <StackLayout Grid.Row="1">                 
                    <Button Text="Next_Page"                            
                        VerticalOptions="CenterAndExpand"
                        HorizontalOptions="CenterAndExpand"
                        Clicked="Button_Clicked" />
                </StackLayout>
            </Grid>
        </navigationdrawer:SfNavigationDrawer.ContentView>
    </navigationdrawer:SfNavigationDrawer>
```
**C#**
```
 private void hamburgerButton_Clicked(object sender, EventArgs e) 
 {
     navigationDrawer.ToggleDrawer();
 }
 private async void Button_Clicked(object sender, EventArgs e) 
 {
      await Navigation.PushAsync(new NewPage());
 }
```
**New Page**

**C#**

```
public NewPage()
{
	Content = new VerticalStackLayout
	{
		Children = {
			new Label { HorizontalOptions = LayoutOptions.Center, 
				VerticalOptions = LayoutOptions.Center, 
				Text = "Welcome to .NET MAUI!"
			}
		}
	};
}
```