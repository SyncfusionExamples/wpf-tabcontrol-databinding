# WPF TabControl Databinding

This sample demonstrates how to bind data to **Syncfusion TabControlExt** in a WPF application. The `TabControlExt` control allows you to create tabbed interfaces with advanced features like header editing, image support, and custom templates.

## Features in This Sample
- **Data Binding**: The `ItemsSource` property of `TabControlExt` is bound to a collection of tab items in the `ViewModel`.
- **Editable Headers**: Users can edit tab headers at runtime using the `EnableLabelEdit` property and `EditHeaderTemplate`.
- **Custom Header Template**: Displays the tab header using a `TextBlock` bound to the `Header` property.
- **Image Support**: Each tab can display an image with customizable size and alignment.
- **MVVM Pattern**: The sample uses a `ViewModel` as the `DataContext` for clean separation of UI and logic.

## Key Properties Used
- **ItemsSource**: Binds the tab items collection from the ViewModel.
- **HeaderTemplate**: Defines how the tab header is displayed.
- **EditHeaderTemplate**: Provides a template for editing the header text.
- **Image, ImageHeight, ImageWidth**: Displays an image in the tab header.
- **ImageAlignment**: Aligns the image relative to the header text.

## XAML Overview
```xml
<syncfusion:TabControlExt ItemsSource="{Binding TabItems}" EnableLabelEdit="True">
    <syncfusion:TabControlExt.ItemContainerStyle>
        <Style TargetType="syncfusion:TabItemExt">
            <Setter Property="HeaderTemplate">
                <Setter.Value>
                    <DataTemplate>
                        <TextBlock Text="{Binding Header}" />
                    </DataTemplate>
                </Setter.Value>
            </Setter>
            <Setter Property="Content" Value="{Binding Content}" />
            <Setter Property="Image" Value="{Binding Image}" />
            <Setter Property="ImageHeight" Value="21" />
            <Setter Property="ImageWidth" Value="21" />
            <Setter Property="ImageAlignment" Value="{Binding ImageAlignment}" />
        </Style>
    </syncfusion:TabControlExt.ItemContainerStyle>
    <syncfusion:TabControlExt.EditHeaderTemplate>
        <DataTemplate>
            <TextBox Text="{Binding Header}" />
        </DataTemplate>
    </syncfusion:TabControlExt.EditHeaderTemplate>
</syncfusion:TabControlExt>
```

## How It Works
1. The `ViewModel` contains an `ObservableCollection<TabItemExt>` named `TabItems`.
2. Each `TabItemExt` has properties like `Header`, `Content`, `Image`, and `ImageAlignment`.
3. The `TabControlExt` binds to this collection, automatically generating tabs.

## Documentation
For more details, refer to the official Syncfusion documentation:  
[TabControl Data Binding](https://help.syncfusion.com/wpf/tabcontrol/databinding#tabitem-content)
