
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MirrorDataBase.Model
{
    [Table("CLIENTES")]
    public class Cliente
    {
        [Key]
        public string CodCliente { get; set; }
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public string RazonSocial { get; set; }
        public string Direccion { get; set; }
        public string Telefonos { get; set; }
        public string FAX { get; set; }
        public string Celular { get; set; }
        public string WebPage { get; set; }
        public string Distrito { get; set; }
        public string Barrio { get; set; }
        public string CodTipoCliente { get; set; }
        public string CodVendedor { get; set; }
        public string CodSupervisor { get; set; }
        public string CodColector { get; set; }
        public string CodDescuento { get; set; }
        public DateTime FechaIngreso { get; set; }
        public decimal LimiteCredito { get; set; }
        public DateTime FinalContrato { get; set; }
        public decimal? SaldoUltimoCorte { get; set; }
        public decimal? NuevoSaldoAcumulado { get; set; }
        public decimal? Interes { get; set; }
        public DateTime FechaUltCorte { get; set; }
        public string CuentaCliente { get; set; }
        public string CalcMora { get; set; }
        public string Empresa { get; set; }
        public bool? Exonerado { get; set; }
        public string Email { get; set; }
        public string CuentaAnticipado { get; set; }
        public decimal? CreditoCantidad { get; set; }
        public decimal CreditoDias { get; set; }
        public string TarjetaCredito { get; set; }
        public string NumDocumento { get; set; }
        public string PrecioAutorizado { get; set; }
        public string Activo { get; set; }
        public string CodDepartamento { get; set; }
        public string CodMunicipio { get; set; }
        public string Credito { get; set; }
        public string Consignatario { get; set; }
        public string IncluirObservacion { get; set; }
        public string CodBarrio { get; set; }
        public string codcolector2 { get; set; }
        public string CodDistrito { get; set; }
        public string ruta { get; set; }
        public string UsuarioRegistro { get; set; }
        public string MaquinaRegistro { get; set; }
        public DateTime FechaRegistro { get; set; }
        public DateTime fechanac { get; set; }
        public string clasi_cliente { get; set; }
        public decimal porcent_mora { get; set; }
        public string Version { get; set; }
        public int CodTipoIdentificacion { get; set; }
        public int CodPais { get; set; }
        public int CodGenero { get; set; }
        public int CodSector { get; set; }
        public int CodRuta { get; set; }
        public int CodAtencion { get; set; }
        public int CodMoneda { get; set; }
        public string Telefono1 { get; set; }
        public string Telefono2 { get; set; }
        public string Telefono3 { get; set; }
        public string Horario { get; set; }
        public string Nombre_Representante { get; set; }
        public string Profesion_Representante { get; set; }
        public string Identificacion_Representante { get; set; }
        public string Telefonos_Representante { get; set; }
        public int CodEstadoCivil_Representante { get; set; }
        public string Email_Representante { get; set; }
        public string AcumulaPuntos { get; set; }
        public decimal Porcen_Descuento { get; set; }
        public string Forma_Pago { get; set; }
        public int Dia_Pago { get; set; }
        public string PagaLun { get; set; }
        public string PagaMar { get; set; }
        public string PagaMie { get; set; }
        public string PagaJue { get; set; }
        public string PagaVie { get; set; }
        public string PagaSab { get; set; }
        public string PagaDom { get; set; }
        public string VisitaLun { get; set; }
        public string VisitaMar { get; set; }
        public string VisitaMie { get; set; }
        public string VisitaJue { get; set; }
        public string VisitaVie { get; set; }
        public string VisitaSab { get; set; }
        public string VisitaDom { get; set; }
        public string Comentario { get; set; }
        public int CodTratamientoClienteFactura { get; set; }
        public int CodTratamientoCredito { get; set; }
        public int CodTratamientoLimiteCredito { get; set; }
        public string Carnet_Frecuente { get; set; }
        public int IdDescuento { get; set; }
        public string Bodega { get; set; }
        public int NCopiasF { get; set; }
        public string Aplica_Consignacion { get; set; }
        public string Aplica_Devolucion { get; set; }
        public string ObservacionesE { get; set; }
        public string DirEnvio1 { get; set; }
        public string DirEnvio2 { get; set; }
        public string CodMunicipioE { get; set; }
        public string TelefonoE { get; set; }
        public string ContactoE { get; set; }
        public string EmailE { get; set; }
        public string Envio { get; set; }
        public string Aplica_PlanPago { get; set; }
        public string CodReferencia { get; set; }
        public string Ubicacion { get; set; }
        public decimal Longitud { get; set; }
        public decimal Latitud { get; set; }
        public int Radio { get; set; }
        public string EnvioFactura { get; set; }
        public string Ciudad { get; set; }
        public int CodCliFre { get; set; }
    }

    [Table("FACTURA")]
    public class Factura
    {
        [Key]
        public string NoFactura { get; set; }

        public string Serie { get; set; }

        public string Tipo { get; set; }

        public string Modo { get; set; }

        public DateTime FechaFactura { get; set; }

        public string Moneda { get; set; }

        public decimal Efectivo { get; set; }

        public decimal Tarjeta { get; set; }

        public decimal Cheque { get; set; }

        public decimal? RetencionIR { get; set; }

        public decimal? RetencionALMA { get; set; }

        public decimal? SubTotal { get; set; }

        public decimal? Descuento { get; set; }

        public decimal? Iva { get; set; }

        public decimal MontoExonerado { get; set; }

        public decimal? TotalPago { get; set; }

        public string CodListaPrecio { get; set; }

        public string Sucursal { get; set; }

        public string CodCli { get; set; }

        public string Nombrede { get; set; }

        public string Ruta { get; set; }

        public string Rutero { get; set; }

        public string CentroVenta { get; set; }

        public string Supervisor { get; set; }

        public string Colector { get; set; }

        public string Anulado { get; set; }

        public decimal valtas { get; set; }

        public DateTime Fecha_Vence { get; set; }

        public DateTime RegistroFecha { get; set; }

        public string RegistroUsuario { get; set; }

        public string RegistroMaquina { get; set; }

        public string Exonerado { get; set; }

        public string ReferenciaExoneracion { get; set; }

        public string Consignatario { get; set; }

        public decimal Plazo { get; set; }

        public string FormaPago { get; set; }

        public decimal MontoPrima { get; set; }

        public DateTime FechaPagoPrima { get; set; }

        public int Cuotas { get; set; }

        public decimal Financiamiento { get; set; }

        public string TipoCasa { get; set; }

        public string TiempoResidir { get; set; }

        public string CodTipoCliente { get; set; }

        public string NoIdentificacion { get; set; }

        public string clientecontado { get; set; }

        public string revertida { get; set; }

        public string NumOrden { get; set; }

        public string numprecierre { get; set; }

        public string imprimir { get; set; }

        public int numero { get; set; }

        public int conteo { get; set; }

        public string noapartado { get; set; }

        public string caja { get; set; }

        public string numcierre { get; set; }

        public string NoRecerva { get; set; }

        public string Version { get; set; }

        public int NoTransaccionInv { get; set; }

        public int CodClienteSucursal { get; set; }

        public string Cajero { get; set; }

        public string Observacion { get; set; }

        public string VerComoPreventa { get; set; }

        public int TipoServicio { get; set; }

        public decimal Transporte { get; set; }

        public decimal Propina { get; set; }

        public int Agente { get; set; }

        public string NombreSubCliente { get; set; }

        public string ClientePadre { get; set; }

        public string NumeroExoneracion { get; set; }

        public int IdentificadorPreventa { get; set; }

        public int ReferenciaPreventa { get; set; }

        public int IdEstado { get; set; }

        public DateTime FechaRetorno { get; set; }

        public string MotivoRevertida { get; set; }

        public DateTime HoraRevertida { get; set; }

        public DateTime HoraEnviado { get; set; }

        public int CantidadCupones { get; set; }

        public string Referencia { get; set; }

        public string NoPedido { get; set; }

        public string EtiquetaInformativa { get; set; }

        public decimal Longitud { get; set; }

        public decimal Latitud { get; set; }

        public int IdProgramacion { get; set; }

        public string AplicaGarantia { get; set; }

        public DateTime RegistroFechaApp { get; set; }

        public decimal? Impuesto1 { get; set; }
        public decimal? Impuesto2 { get; set; }
        public decimal? Impuesto3 { get; set; }
        public decimal? Impuesto4 { get; set; }
        public decimal? Impuesto5 { get; set; }

        public string NumeroTrasladoConsignado { get; set; }

        public string BodDestino { get; set; }

        public string BodDestinoConsignacion { get; set; }

        public string NoConsignacionCLiente { get; set; }

        public string PlanDePago { get; set; }

        public string ROCPRIMA { get; set; }

        public int NoPlanPago { get; set; }

        public decimal ValorInteres { get; set; }

        public string IdPromocion { get; set; }
    }

    [Table("DET_FACTURA")]
    public class DetFactura
    {
        public string Sucursal { get; set; }

        [Key]
        public string NoFactura { get; set; }

        public string Serie { get; set; }

        public string Tipo { get; set; }

        public string Modo { get; set; }

        public DateTime FechaFactura { get; set; }

        public string Producto { get; set; }

        public string UMedida { get; set; }

        public decimal? Cantidad { get; set; }

        public decimal Bonificacion { get; set; }

        public decimal Financiamiento { get; set; }

        public decimal? Precio { get; set; }

        public decimal? Porcen_Descto { get; set; }

        public decimal? Descuento { get; set; }

        public decimal? Iva { get; set; }

        public decimal Costo { get; set; }

        public decimal? Exonerado { get; set; }

        public string Bod_Descargue { get; set; }

        public string CodPrecio { get; set; }

        public string Registro_Usuario { get; set; }

        public string Registro_Maquina { get; set; }

        public DateTime? Registro_Fecha { get; set; }

        public string nombre_producto { get; set; }

        public string Tipodesc { get; set; }

        public string tipofac { get; set; }

        public int Numero { get; set; }

        public decimal? valor { get; set; }

        public string cod_combo { get; set; }

        public int orden { get; set; }

        public int indice { get; set; }

        public decimal Porcentaje_ComisionLista { get; set; }

        public string TipoComponente { get; set; }

        public string Gravado { get; set; }

        public string MedidaCosteo { get; set; }

        public string MedidaMovimiento { get; set; }

        public decimal? CantidadMovimiento { get; set; }

        public string Medida_Bonificacion { get; set; }

        public decimal Bonificacion_Movimiento { get; set; }

        public decimal saldo { get; set; }

        public decimal PrecioDeLista { get; set; }

        public string DescuentoFijo { get; set; }

        public int PrioridadDescuento { get; set; }

        public int TipoServicio { get; set; }

        public int Cupones { get; set; }

        public string Lote { get; set; }

        public DateTime Vencimiento { get; set; }

        public string Receta { get; set; }

        public int Ruta { get; set; }

        public int IdProgramacion { get; set; }

        public DateTime RegistroFechaApp { get; set; }

        public string num_parte { get; set; }

        public string OrdenServicio { get; set; }

        public int CentroCosto2 { get; set; }

        public int CentroCosto3 { get; set; }

        public decimal? Impuesto1 { get; set; }

        public decimal? Impuesto2 { get; set; }

        public decimal? Impuesto3 { get; set; }

        public decimal? Impuesto4 { get; set; }

        public decimal? Impuesto5 { get; set; }

        public string ProductoConsignado { get; set; }

        public string NumeroTrasladoConsignado { get; set; }
    }

    [Table("PROFORMA")]
    public class Proforma
    {
        [Key]
        public string NoFactura { get; set; }

        public string Sucursal { get; set; }

        public DateTime FechaFactura { get; set; }

        public string Serie { get; set; }

        public string Tipo { get; set; }

        public string Modo { get; set; }

        public string Moneda { get; set; }

        public decimal Efectivo { get; set; }

        public decimal Tarjeta { get; set; }

        public decimal Cheque { get; set; }

        public decimal? RetencionIR { get; set; }

        public decimal? RetencionALMA { get; set; }

        public decimal? SubTotal { get; set; }

        public decimal? Descuento { get; set; }

        public decimal? Iva { get; set; }

        public decimal MontoExonerado { get; set; }

        public decimal? TotalPago { get; set; }

        public string CodListaPrecio { get; set; }

        public string CodCli { get; set; }

        public string Nombrede { get; set; }

        public string Ruta { get; set; }

        public string Rutero { get; set; }

        public string CentroVenta { get; set; }

        public string Supervisor { get; set; }

        public string Colector { get; set; }

        public string Anulado { get; set; }

        public decimal Valtas { get; set; }

        public DateTime Fecha_Vence { get; set; }

        public DateTime RegistroFecha { get; set; }

        public string RegistroUsuario { get; set; }

        public string RegistroMaquina { get; set; }

        public string Exonerado { get; set; }

        public string ReferenciaExoneracion { get; set; }

        public string Consignatario { get; set; }

        public decimal Plazo { get; set; }

        public string FormaPago { get; set; }

        public decimal MontoPrima { get; set; }

        public DateTime FechaPagoPrima { get; set; }

        public int Cuotas { get; set; }

        public decimal Financiamiento { get; set; }

        public string TipoCasa { get; set; }

        public string TiempoResidir { get; set; }

        public string CodTipoCliente { get; set; }

        public string NoIdentificacion { get; set; }

        public string Clientecontado { get; set; }

        public string Facturado { get; set; }

        public DateTime FechaFacturado { get; set; }

        public string Factu { get; set; }

        public string Observaciones { get; set; }

        public string MODENA { get; set; }

        public string Ref_licitacion { get; set; }

        public string Telatencion { get; set; }

        public string Atencionde { get; set; }

        public DateTime FechaValida { get; set; }

        public int CodClienteSucursal { get; set; }

        public int Detalle_canje_anticipo { get; set; }

        public int Detalle_canje_anticipo_tempo { get; set; }

        public string NombreSubCliente { get; set; }

        public string ClientePadre { get; set; }

        public string Rpt { get; set; }

        public string TiempoEntrega { get; set; }

        public string LugarEntrega { get; set; }

        public decimal Impuesto1 { get; set; }

        public decimal Impuesto2 { get; set; }

        public decimal Impuesto3 { get; set; }

        public decimal Impuesto4 { get; set; }
        
        public decimal Impuesto5 { get; set; }

        public string LeyendaInformativa { get; set; }
    }

    [Table("Productos")]
    public class Producto
    {
        [Key]
        public string CodProducto { get; set; }
        public string Descripcion { get; set; }
        public int CodProveedor { get; set; }
        public string Referencia { get; set; }
        public string Cod_Linea { get; set; }
        public string CodUm { get; set; }
        public decimal CostoFOB { get; set; }
        public decimal Costo { get; set; }
        public decimal Precio1 { get; set; }
        public decimal Precio2 { get; set; }
        public decimal Precio3 { get; set; }
        public decimal Precio4 { get; set; }
        public decimal Existencia { get; set; }
        public bool NoExistencia { get; set; }
        public string Activo { get; set; }
        public decimal InventMinimo { get; set; }
        public string CuentaProducto { get; set; }
        public string Gravable { get; set; }
        public decimal PorcComision { get; set; }
        public bool Consignacion { get; set; }
        public string Moneda { get; set; }
        public string CodDescuento { get; set; }
        public string CodTipoProducto { get; set; }
        public string CodUbicacion { get; set; }
        public decimal DiasDevolucion { get; set; }
        public string PrecioXDefecto { get; set; }
        public string Referencia1 { get; set; }
        public string Referencia2 { get; set; }
        public string Referencia3 { get; set; }
        public string Uso { get; set; }
        public decimal? Promocion { get; set; }
        public decimal? Promocion2 { get; set; }
        public decimal? CostoMP { get; set; }
        public string ParaVenta { get; set; }
        public string CtaVenta { get; set; }
        public string Ctainventario { get; set; }
        public string CtaCosto { get; set; }
        public string Codigogrupo { get; set; }
        public string Codigomarca { get; set; }
        public string ICS { get; set; }
        public string MaquinaRegistro { get; set; }
        public string UsuarioRegistro { get; set; }
        public DateTime FechaRegistro { get; set; }
        public string Controlaexistencia { get; set; }
        public string CodBarra { get; set; }
        public string CodSAP { get; set; }
        public string Modelo { get; set; }
        public string Eficiencia { get; set; }
        public string Capacidad { get; set; }
        public string Watt { get; set; }
        public string Tecnologia { get; set; }
        public int StockMIN { get; set; }
        public int StockMAX { get; set; }
        public string Num_parte { get; set; }
        public string Codigogarantia { get; set; }
        public string Combo { get; set; }
        public string DIBUJO { get; set; }
        public string Presentacion { get; set; }
        public string Version { get; set; }
        public int CodigoMoneda { get; set; }
        public string EsServicio { get; set; }
        public string DescripcionEditable { get; set; }
        public string TipoCombo { get; set; }
        public string ValidaCantida { get; set; }
        public string MedidaCompra { get; set; }
        public decimal Volumen { get; set; }
        public decimal Alto { get; set; }
        public decimal Ancho { get; set; }
        public decimal Longitud { get; set; }
        public decimal Peso { get; set; }
        public string Controlado { get; set; }
        public string MsjControlado { get; set; }
        public string Descripcion2 { get; set; }
        public int IdProducto { get; set; }
        public string SegundoNombre { get; set; }
        public string PermiteCero { get; set; }
        public string PermiteDecuento { get; set; }
        public decimal MontoDescuento { get; set; }
        public string AplicaUltimoDiaDeVenta { get; set; }
        public DateTime UltimoDiaDeVenta { get; set; }
        public string Color { get; set; }
        public string ComboRespetaBodegAsociada { get; set; }
        public string PrecioLibre { get; set; }
        public decimal LibreDesde { get; set; }
        public decimal LibreHasta { get; set; }
        public string AplicaWeb { get; set; }
        public string AplicaMovil { get; set; }
        public int Departamento { get; set; }
        public string Bonificacion { get; set; }
        public string InsumoProduccion { get; set; }
        public string ProductoTerminado { get; set; }
        public string Mensaje { get; set; }
        public DateTime FechaCaducidadMensaje { get; set; }
        public string ColorMensaje { get; set; }
        public string UnicoEnFactura { get; set; }
        public DateTime PrimerDiaDeVenta { get; set; }
        public string VisibleEnServicios { get; set; }
        public string AplicaCalendario { get; set; }
        public string SoyPrimeraEleccion { get; set; }
        public string TengoPrimeraEleccion { get; set; }
        public string AplicaLote { get; set; }
        public string AplicaVencimiento { get; set; }
        public int DiasRetiro { get; set; }
        public string OrigenCrecion { get; set; }
        public int IdColor { get; set; }
        public int IdTalla { get; set; }
        public string Importado { get; set; }
        public string AlimentoBebida { get; set; }
        public string CodificacionMsv { get; set; }
        public int IdRubro { get; set; }
        public int IdKilate { get; set; }
        public int IdestadoPrenda { get; set; }
        public string Externo { get; set; }
        public string CertificadoValor { get; set; }
        public int TipoInventario { get; set; }
        public DateTime UltimoDiaDeCompra { get; set; }
        public int IdSeccion { get; set; }
        public int IdGiroNegocio { get; set; }
        public string ConsignacionCliente { get; set; }
        public string ConsignacionProveedor { get; set; }
        public string NoFactura { get; set; }
        public string Poliza { get; set; }
        public string CodCliente { get; set; }
        public decimal Impuesto1 { get; set; }
        public decimal Impuesto2 { get; set; }
        public decimal Impuesto3 { get; set; }
        public decimal Impuesto4 { get; set; }
        public decimal Impuesto5 { get; set; }
        public string ComentarioVendedor { get; set; }
        public string CodBarras2 { get; set; }
        public string EsPizza { get; set; }
        public string TiempoPreparacion { get; set; }
        public decimal Largo { get; set; }
        public decimal Profundidad { get; set; }
        public decimal PesoReal { get; set; }
        public decimal PesoVolumetrico { get; set; }
        public int CodigoTamano { get; set; }
        public string AreaImpresion { get; set; }
        public string PermiteDevolucionFactura { get; set; }
        public string CodigoAlterno { get; set; }
        public string DerechoAutor { get; set; }
    }
}