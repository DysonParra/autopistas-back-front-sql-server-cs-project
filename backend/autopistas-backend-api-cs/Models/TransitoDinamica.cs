/*
 * @fileoverview    {TransitoDinamica} se encarga de realizar tareas específicas.
 *
 * @version         2.0
 *
 * @author          Dyson Arley Parra Tilano <dysontilano@gmail.com>
 *
 * @copyright       Dyson Parra
 * @see             github.com/DysonParra
 *
 * History
 * @version 1.0     Implementación realizada.
 * @version 2.0     Documentación agregada.
 */
using System;
using System.ComponentModel.DataAnnotations;

/**
 * TODO: Definición de {@code TransitoDinamica}.
 *
 * @author Dyson Parra
 */
namespace Project.Models {

    public class TransitoDinamica {

        [Key]
        public Int64? IntIdDinamica { get; set; }
        public Int32? IntIdCategoria { get; set; }
        public String? StrPlacaVehiculo { get; set; }
        public DateTime? DtFechaHoraTransito { get; set; }
        public Int32? IntPesoGeneral { get; set; }
        public String? StrPesoEjes { get; set; }
        public Single? FltVelocidad { get; set; }
        public String? TxtBase64Placa { get; set; }

    }

}