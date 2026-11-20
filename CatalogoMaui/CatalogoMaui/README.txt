PRACTICA 4 - CATALOGO DE PRODUCTOS CON TARJETAS EN .NET MAUI

Proyecto: CatalogoMaui
Plataforma configurada: Android
Framework objetivo: .NET 8

CONTENIDO
- Models/Producto.cs: modelo Producto con Nombre, Descripcion, Precio, Foto y Detalle.
- ViewModels/CatalogoViewModel.cs: lista con mochila, libreta, termo y el cuarto producto Mouse gamer RGB.
- MainPage.xaml: CollectionView y DataTemplate del catalogo.
- MainPage.xaml.cs: BindingContext y navegacion al detalle.
- Views/ProductoDetallePage.xaml: pantalla de detalle.
- Views/ProductoDetallePage.xaml.cs: recibe el producto seleccionado.
- AppShell.xaml.cs: registra la ruta producto-detalle.
- Resources/Images: cuatro imagenes ilustrativas incluidas.

ABRIR Y EJECUTAR
1. Extrae el ZIP.
2. Abre CatalogoMaui.csproj con Visual Studio 2022.
3. Asegurate de tener instalado el workload/desarrollo de .NET MAUI y el SDK de .NET 8.
4. Selecciona un emulador Android o conecta un dispositivo Android con depuracion USB.
5. Restaura los paquetes NuGet y ejecuta con F5.

NOTAS
- Las imagenes incluidas son ilustraciones sencillas para que el proyecto tenga recursos locales y pueda mostrar las cuatro tarjetas. Puedes reemplazarlas por fotos propias manteniendo los nombres mochila.png, libreta.png, termo.png y mouse.png.
- El cuarto objeto agregado es Mouse gamer RGB (MX$ 349.00).
- La estructura del catalogo y la navegacion siguen la guia de la Practica 4.
- El proyecto no se pudo compilar en este entorno porque no tiene instalado el SDK de .NET ni las cargas de trabajo de MAUI. La compilacion debe verificarse en Visual Studio con MAUI instalado.
