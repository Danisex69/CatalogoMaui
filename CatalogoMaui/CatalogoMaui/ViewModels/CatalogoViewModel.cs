using System.Collections.Generic;
using CatalogoMaui.Models;

namespace CatalogoMaui.ViewModels;

public class CatalogoViewModel
{
    // Cada objeto de esta lista se convertirá en una tarjeta.
    public List<Producto> Productos { get; } = new()
    {
        new Producto
        {
            Nombre = "Mochila urbana",
            Descripcion = "Con espacio para laptop y cuadernos.",
            Precio = 499.00m,
            Foto = "mochila.png",
            Detalle = "Mochila para uso diario. Incluye un compartimento acolchado para laptop y un bolsillo frontal para objetos pequeños."
        },

        new Producto
        {
            Nombre = "Libreta A5",
            Descripcion = "80 hojas rayadas con pasta dura.",
            Precio = 89.50m,
            Foto = "libreta.png",
            Detalle = "Libreta de tamaño A5 con 80 hojas rayadas. Su pasta dura protege los apuntes dentro de la mochila."
        },

        new Producto
        {
            Nombre = "Termo de acero",
            Descripcion = "Botella reutilizable de 500 ml.",
            Precio = 219.00m,
            Foto = "termo.png",
            Detalle = "Termo de acero de 500 ml, con tapa de rosca. Su tamaño permite llevarlo fácilmente en una mochila."
        },

        // Cuarto producto agregado a la práctica.
        new Producto
        {
            Nombre = "Mouse gamer RGB",
            Descripcion = "Mouse con iluminación RGB y botones laterales.",
            Precio = 349.00m,
            Foto = "mouse.png",
            Detalle = "Mouse gamer con diseño ergonómico, iluminación RGB, sensor preciso y botones laterales. Ideal para jugar y trabajar en la computadora."
        }
    };
}
