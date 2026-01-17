Module Module1

    Sub Main()

        'Diccionarios
        Dim diccionarioAlumno As Dictionary(Of Integer, Alumno)

        Console.Write("--- Menu Calculator ---")

    End Sub

    Public Function Resta(num1 As Integer, num2 As Integer) As Integer
        Return num1 - num2
    End Function

    Public Function Multiplicacion(num1 As Integer, num2 As Integer) As Integer
        Return num1 * num2
    End Function


    Public Function Suma(num1 As Integer, num2 As Integer) As Integer
        Return num1 + num2
    End Function

    Public Class Persona

        Public Property Nombre() As String
        Public Property Edad() As Byte

        Public Sub MotrarInfo()
            Console.WriteLine($"Nombre: {Nombre}, Edad: {Edad}")
        End Sub


    End Class

    Public Class Alumno
        Inherits Persona

        Public Property Matricula() As String
        Public Property Calificacion() As Byte

        Public Function EsAprobado() As Boolean
            If Calificacion >= 7 Then
                Return True
            End If
            Return False
        End Function

    End Class

    Public Class Producto

        Private _id As Integer
        Public Property Id() As String
            Get
                Return _id
            End Get
            Set(ByVal value As String)
                _id = value
            End Set
        End Property

        Private _nombre As String
        Public Property Nombre() As String
            Get
                Return _nombre
            End Get
            Set(ByVal value As String)
                _nombre = value
            End Set
        End Property

        Private _precio As String
        Public Property Precio() As String
            Get
                Return _precio
            End Get
            Set(ByVal value As String)
                _precio = value
            End Set
        End Property


        Public Sub New(id As Integer, nombre As String, precio As Integer)
            _id = id
            _nombre = nombre
            _precio = precio
        End Sub

    End Class

End Module
