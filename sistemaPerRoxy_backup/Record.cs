using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace sistemaPerRoxy
{
    internal class Record
    {
        [JsonPropertyName("descrizione")]
        public string Descrizione { get; set; }

        [JsonPropertyName("recOp")]
        public string RecOp { get; set; }

        [JsonPropertyName("trattabili_ton")]
        public double? TrattabiliTon { get; set; }
        [JsonPropertyName("trattabili_mc")]
        public double? TrattabiliMc { get; set; }
        [JsonPropertyName("stoccabili_ton")]
        public double? StoccabiliTon { get; set; }
        [JsonPropertyName("stoccabili_mc")]

        public double? StoccabiliMc { get; set; }

        public override string ToString()
        {
            return
                   $"Descrizione rifiuto: {Descrizione}\n\n" +
        $"Operazioni di recupero: {RecOp}\n\n" +
        $"Trattabili (Ton): {(TrattabiliTon.HasValue ? TrattabiliTon.Value.ToString() : "--")}\n\n" +
        $"Trattabili (Mc): {(TrattabiliMc.HasValue ? TrattabiliMc.Value.ToString() : "--")}\n\n" +
        $"Stoccabili (Ton): {(StoccabiliTon.HasValue ? StoccabiliTon.Value.ToString() : "--")}\n\n" +
        $"Stoccabili (Mc): {(StoccabiliMc.HasValue ? StoccabiliMc.Value.ToString() : "--")}";
        }
    }
}
