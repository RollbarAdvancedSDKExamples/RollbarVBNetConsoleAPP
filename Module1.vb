Imports Rollbar

Module Module1

    Sub Main()

        'Write messages to console window
        Console.WriteLine("Welcome to this Console Application.")

        Console.WriteLine("Loading main application data...")

        Console.WriteLine("|")
        Console.WriteLine("|-")
        Console.WriteLine("|-|")
        Console.WriteLine("|-|-")
        Console.WriteLine("|-|-|")

        'Load Rollbar
        ConfigureRollbar()

        'Execute Functions
        HandledError()

        Console.WriteLine("Ready.... press any key to exit.")

        'Keeps the Window Open Until a Key press
        Console.Read()

    End Sub

    Sub ConfigureRollbar()

        Dim objRollbarSettings As New RollbarLoggerConfig("XX", "Production")

        RollbarLocator.RollbarInstance.Configure(objRollbarSettings)
        RollbarLocator.RollbarInstance.Info("Rollbar is configured properly.")

    End Sub


    Sub HandledError()

        Try

            'Generate Error Here 
            Dim intValue As Integer
            Dim intValue2 As Integer = 0

            'Generate Error Here
            intValue = 1 / intValue2

        Catch ex As Exception
            RollbarLocator.RollbarInstance.Error(ex)
        End Try

    End Sub

End Module
