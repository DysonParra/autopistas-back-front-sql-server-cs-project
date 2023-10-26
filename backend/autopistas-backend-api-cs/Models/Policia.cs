/*
 * @fileoverview    {Policia}
 *
 * @version         2.0
 *
 * @author          Dyson Arley Parra Tilano <dysontilano@gmail.com>
 *
 * @copyright       Dyson Parra
 * @see             github.com/DysonParra
 *
 * History
 * @version 1.0     Implementation done.
 * @version 2.0     Documentation added.
 */
using System;
using System.ComponentModel.DataAnnotations;

/**
 * TODO: Definición de {@code Policia}.
 *
 * @author Dyson Parra
 */
namespace Project.Models {

    public class Policia {

        [Key]
        public Int64? IntIdPolicia { get; set; }
        public String? StrNombrePolicia { get; set; }
        public String? StrApellidoPolicia { get; set; }
        public String? StrTelefono { get; set; }

    }

}