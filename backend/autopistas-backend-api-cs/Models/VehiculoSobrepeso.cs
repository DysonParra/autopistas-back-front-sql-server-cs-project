/*
 * @fileoverview    {VehiculoSobrepeso}
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
 * TODO: Definición de {@code VehiculoSobrepeso}.
 *
 * @author Dyson Parra
 */
namespace Project.Models {

    public class VehiculoSobrepeso {

        [Key]
        public Int64? IntIdRepeso { get; set; }
        public Int32? IntPesoMaximo { get; set; }
        public Int32? IntDiferenciaPeso { get; set; }
        public String? StrPlacaVehiculo { get; set; }
        public Boolean? BitBorrado { get; set; }
        public Int64? IntIdDinamica { get; set; }

    }

}