using PPAI_CU17_GrupoYaNoNosFaltan2.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PPAI_CU17_GrupoYaNoNosFaltan2.Interfaces;

class Program
{
    
    TipoInformacion tipoInfo = new TipoInformacion('Validatoria', 'Es la cantidad de hijos del cliente');

    Validacion validacion = new Validacion('Audio', 'Cantidad de hijos', '1', tipoInfo);

    InformacionCliente infoCliente = new InformacionCliente('Cantidad de hijos', validacion, tipoInfo);

    SubOpcionLlamada subOpcion = new SubOpcionLlamada('Hablar con operador', '1', validacion);

    OpcionLlamada opcionLlamada = new OpcionLlamada('Audio', 'Hablar con operador 1. Finalizar 2', 
        'Informar robo y anular tarjeta', '1', 'No tiene validacion');

    Categoria categoria = new Categoria('Audio', 'Informar robo y solicitar tarjeta 1. Informar robo y anular tarjeta 2.',
        'Informar robo', '1');

    Cliente cliente = new Cliente("12345678", "Juan Pérez", "123456789", infoCliente);

    Estado estado = new Estado('Iniciada');

    CambioEstado cambioEstado = new CambioEstado('01/01/2023', estado);

    Llamada llamada = new Llamada('Sin descripción', 'Sin acción req', TimeSpan.Zero, false, 'Sin observación',
        cliente, subOpcion, opcionLlamada, cambioEstado, categoria);
}