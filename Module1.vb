Module Module1

    Sub Main()

        noughtsAndCrosses()

        Console.ReadKey()
    End Sub



    Sub noughtsAndCrosses()

        'Initialise Game variables
        Dim grid(,) As Char = {{" ", " ", " "}, {" ", " ", " "}, {" ", " ", " "}}
        Dim player1 As String = ""
        Dim player2 As String = ""
        Dim result As Char

        GetNames(player1, player2)

        result = PlayGame(grid)

        DisplayResults(player1, player2, result)

        Console.ReadKey()
    End Sub

    Sub GetNames(ByRef player1 As String, ByRef player2 As String)
        Console.Clear()
        Console.WriteLine("Enter Player Names")
        Console.Write("Player 1 (0): ")
        player1 = Console.ReadLine()
        Console.Write("Player 2 (X): ")
        player2 = Console.ReadLine()
    End Sub

    Function PlayGame(ByRef grid) As Char
        Dim turns As Integer = 0
        Dim currentPlayer As Char
        Dim result As Char

        Do
            DrawGrid(grid)
            If turns Mod 2 = 0 Then
                currentPlayer = "0"
            Else
                currentPlayer = "X"
            End If
            GetMove(grid, currentPlayer)
            turns = turns + 1
        Loop Until turns = 9 Or CheckWin(grid)

        DrawGrid(grid)

        If turns = 9 Then
            result = "-"
        Else
            result = currentPlayer
        End If

        Return result
    End Function

    Sub DisplayResults(ByVal player1, ByVal player2, ByVal result)
        If result = "-" Then
            Console.WriteLine("Game Drawn...")
        Else
            Console.WriteLine("We have a winner!")
            If result = "0" Then
                Console.WriteLine(player1 & " wins")
            Else
                Console.WriteLine(player2 & " wins")
            End If
        End If
    End Sub

    Sub DrawGrid(ByVal grid As Char(,))
        Console.Clear()
        Console.WriteLine("  0   1   2")
        Console.WriteLine(" ┌───┬───┬───┐")
        Console.WriteLine("0│ " & grid(0, 0) & " │ " & grid(0, 1) & " │ " & grid(0, 2) & " │")
        Console.WriteLine(" ├───┼───┼───┤")
        Console.WriteLine("1│ " & grid(1, 0) & " │ " & grid(1, 1) & " │ " & grid(1, 2) & " │")
        Console.WriteLine(" ├───┼───┼───┤")
        Console.WriteLine("2│ " & grid(2, 0) & " │ " & grid(2, 1) & " │ " & grid(2, 2) & " │")
        Console.WriteLine(" └───┴───┴───┘")
    End Sub

    Sub GetMove(ByRef grid As Char(,), ByVal player As Char)
        Dim column As Integer
        Dim row As Integer

        Do
            Console.WriteLine("Enter co-ordinates for your move...")
            Console.Write("Column: ")
            While Integer.TryParse(Console.ReadLine(), column) = False Or (column < 0 Or column > 2)
                Console.Beep()
                Console.WriteLine("Invalid column - Enter a value between 0 and 2")
                Console.Write("Column: ")
            End While
            Console.Write("Row: ")
            While Integer.TryParse(Console.ReadLine(), row) = False Or (row < 0 Or row > 2)
                Console.Beep()
                Console.WriteLine("Invalid row - Enter a value between 0 and 2")
                Console.Write("Row: ")
            End While
            If grid(row, column) <> " " Then
                Console.Beep()
                Console.WriteLine("Square taken, pick another square!")
            End If
        Loop Until grid(row, column) = " "

        grid(row, column) = player
    End Sub

    Function CheckWin(ByVal grid As Char(,)) As Boolean
        Dim win As Boolean = False
        If CheckColumns(grid) Or CheckRows(grid) Or CheckDiagonals(grid) Then
            win = True
        End If
        Return win
    End Function

    Function CheckRows(ByVal grid As Char(,)) As Boolean
        Dim completedRow As Boolean = False

        For column = 0 To 2
            If grid(column, 0) = "X" Or grid(column, 0) = "0" Then
                If grid(0, column) = grid(1, column) And grid(1, column) = grid(2, column) Then

                End If
            End If

        Next

        Return completedRow
    End Function

    Function CheckColumns(ByVal grid As Char(,)) As Boolean
        Dim CompletedColumn As Boolean = False
        For row = 0 To 2
            If grid(0, row) = "0" Or grid(0, row) = "X" Then
                If grid(0, row) = grid(1, row) And grid(1, row) = grid(2, row) Then

                    CompletedColumn = True

                End If
            End If
        Next

        Return CompletedColumn
    End Function

    Function CheckDiagonals(ByVal grid As Char(,)) As Boolean
        Dim completedDiagonal As Boolean = False
        'Check the two diagonals to see if there are 3 in a row
        Return completedDiagonal
    End Function








    Sub ColumnsAndRows()

        Dim Array2D(,) As String = {{"Top Gun: Maverick", "Tom Cruise", "PG-13", "Action", "Paramount Pictures"}, {"Petite Maman", "Nina Meurisse", "PG", "Drama", "Neon"}, {"The Conversation", "Gene Hackman", "PG", "Thirller", "Paramount Pictures"}, {"Benediction", "Jack Lowden", "PG-13", "Biography", "Roadside Attractions"}, {"The Bad Guys", "Sam Rockwell", "PG", "Animated Comedy", "Universal Pictures"}, {"The Phantom Of the Open", "Mark Rylance", "PG-13", "Comedy", "Sony Pictures"}}
        Dim choice As Integer
        Dim sensible As Boolean = False
        Dim tempInt As Integer
        Dim tempReal As Integer
        Dim tempchoice As String
        Dim file1 As String = "filename"

        Dim filename As System.IO.StreamWriter
        filename = My.Computer.FileSystem.OpenTextFileWriter(file1, False)
        '  filename.WriteLine(For row = 0 to Array2D.GetUpperBound(0)


        For column = 0 To Array2D.GetUpperBound(1)

        Next
        filename.Close()

        Console.WriteLine("Which film do you want to see the details of:
")

        For row = 0 To Array2D.GetUpperBound(0)


            Console.WriteLine(row + 1 & ": " & Array2D(row, 0))
        Next


        Do Until sensible = True

            Console.WriteLine("
Enter the number of the film you want to see the details of:
")

            tempchoice = Console.ReadLine()

            If IsNumeric(tempchoice) Then
                tempInt = tempchoice
                tempReal = tempchoice

                If tempInt = tempReal Then

                    If tempInt >= 1 And tempInt <= Array2D.GetUpperBound(0) + 1 Then

                        sensible = True

                        choice = tempchoice

                    End If

                End If

            End If

            If sensible = False Then

                Console.WriteLine("Invalid choice
Press any key to re-enter: ")

            End If

        Loop


        For column = 1 To 4

            Console.Write((Array2D((choice - 1), column)) & "  ")

        Next

    End Sub

    Sub PracticeTask1() 

  

        Dim credits As Integer = 3 

        Dim rndArray(1 , 3) As Integer 

        Dim count7 As Integer = 0 

        Dim play As boolean = true 

        Dim choice as string

        Dim sensible As boolean = false 

         

        randomize() 

  

 Do

            count7 = 0

            Console.writeline("Credits: " & credits) 

  

            console.writeline("Press anykey to spin...") 

  

            console.readkey() 

  

            credits -= 1 

  

            console.writeline("Credits: " & credits) 

  

                 For i = 0 to 2 

  

                      rndArray(1 , i) = (6 *Rnd() + 1)



                Console.Write((rndArray(1, i)).ToString.PadLeft(2))



                If rndArray(1 , i) = 7 Then 

                                     count7 += 1 

  

                             end if 

  

                 Next

            Console.Write("  ")

            If count7 = 3 Then

                Console.WriteLine("You win 

+10 credits")



                credits += 10

                Console.WriteLine("Credits: " & credits)



            ElseIf count7 = 2 Then

                Console.WriteLine("You win 

        +3 credits")



                credits += 3

                Console.WriteLine("Credits: " & credits)



            ElseIf rndArray(1, 1) = rndArray(1, 2) And rndArray(1, 2) = rndArray(1, 3) Then

                Console.WriteLine("You win +" & rndArray(1, 2) & "  credits")



                credits += rndArray(1, 2)

                Console.WriteLine("Credits: " & credits)

            End If

            If rndArray(1, 1) + rndArray(1, 2) + rndArray(1, 3) = 7 Then

                Console.WriteLine("You win 

+1 credit")



                credits += 1

                Console.WriteLine("Credits: " & credits)

            End If










            If credits = 0 Then 

            

          console.writeline("Out of credits") 

  

          play = False 

  

               Else 

  

                      Do

       
                          console.writeline("Keep playing: (1), or Cash in: (2)") 
                           choice = console.readline() 
                                  If choice = "1" Then 

                                      sensible = true 

                                              Else If choice = "2" 

                                                    play = False 
                                                    console.writeline("Cashed in") 
                                                     sensible = true

                                                                    Else 

                                                                         console.writeline("Not an option 
                                                                         Re-enter:")  
                                   End If  
                      
                     Loop Until (sensible = true)  
       End if      
           
 Loop Until play = false
                       

     

end sub 


    Sub TwoDArrays5()

'declare array
        Dim twoDArray(12, 12) As Integer


        'assign values
        For row = 0 To 11

            For column = 0 To 11



                twoDArray(row, column) = (row +1) * (column +1)

            Next column

        Next row

         For row = 0 To 11



            'output table
            For column = 0 To 11

                Console.Write(twoDArray(row, column).ToString.PadLeft(4))


            Next column

            Console.WriteLine()

        Next row

    End Sub

    Sub TwoDArrays()

        Dim twoDArray(4, 8) As Integer



        For row = 0 To 3

            For column = 0 To 7



                twoDArray(row, column) = 5

            Next column

        Next row



        twoDArray(0, 0) = 10

        twoDArray(1, 2) = 7

        twoDArray(3, 4) = 44

        twoDArray(3, 7) = 99





        For row = 0 To 3

            For column = 0 To 7

                Console.Write(twoDArray(row, column).ToString.PadLeft(3))


            Next column

            Console.WriteLine()

        Next row

    End Sub




    Sub EssentialAlgorithms3()

        Dim tempNum As Integer

        Dim ages() As Integer = {14, 3, 12, 4, 6}


        For count = 0 To ages.Length - 2

            For i = 0 To ages.Length - 2
                If ages(i) < ages(i + 1) Then

                    tempNum = ages(i)
                    ages(i) = ages(i + 1)
                    ages(i + 1) = tempNum

                End If
            Next
        Next

        For i = 0 To ages.Length - 1

            Console.WriteLine(ages(i))

        Next

    End Sub

    Sub FormatChecks3()

        Dim tGIdentifier As String

        Console.WriteLine("Enter a tutor group")

        tGIdentifier = Console.ReadLine()

        If IsValidTG(tGIdentifier) Then

            Console.WriteLine("Valid tutor group")

        Else

            Console.WriteLine("Invalid tutor group")

        End If

    End Sub

    Function IsValidTG(ByVal tGIdentifier As String) As Boolean

        Dim sensible As Boolean = False

        Dim length As Integer = Len(tGIdentifier)

        Select Case length

            Case = 5

                If IsNumeric(tGIdentifier.Substring(0, 2)) Then

                    If tGIdentifier.Substring(2, 3) >= "A" And tGIdentifier.Substring(2, 3) <= "Z" Then

                        sensible = True

                    End If

                End If

            Case = 4

                If IsNumeric(tGIdentifier.Substring(0, 1)) Then

                    If tGIdentifier.Substring(1, 3) >= "A" And tGIdentifier.Substring(1, 3) <= "Z" Then

                        sensible = True

                    End If

                End If

            Case Else

                Return (False)

        End Select

        Return (sensible)

    End Function

    Sub FormatChecks2()
        Dim stringAA As Char

        Console.WriteLine("Enter a string made of letters")
        stringAA = Console.ReadLine()

        If IsAlpha(stringAA) Then

            Console.WriteLine("That's a(Those are) letter(s)")

        Else

            Console.WriteLine("That wasn't a(Those weren't all) letter(s)")

        End If

    End Sub

    Function IsAlpha(ByVal stringA As String) As Boolean

        Dim sensible As Boolean = False
        Dim length As Integer = Len(stringA)
        stringA = UCase(stringA)

        For i = 0 To (length - 1)

            If stringA.Substring(i, 1) >= "A" And stringA.Substring(i, 1) <= "A" Then

                sensible = True

            Else

                Return (False)

            End If

        Next

        Return (sensible)

    End Function

    Sub FormatChecks()
        Dim charA As Char

        Console.WriteLine("Enter a character")
        charA = Console.ReadLine()

        If IsLetter(charA) Then

            Console.WriteLine("That's a letter")

        Else

            Console.WriteLine("That wasn't a letter")

        End If

    End Sub

    Function IsLetter(ByVal letter As Char) As Boolean

        Dim sensible As Boolean = False

        letter = UCase(letter)

        If letter >= "A" And letter <= "Z" Then

            sensible = True

        End If

        Return (sensible)

    End Function
    Sub TypeChecks3()

        Dim num As Decimal
        Dim sensible As Boolean = False

        Do

            Console.WriteLine("Enter a number")


            If Decimal.TryParse(Console.ReadLine(), num) Then

                sensible = True

            Else

                Console.WriteLine("ERROR")

            End If

        Loop Until sensible = True



        Console.WriteLine("Input: " & num)

    End Sub

    Sub TypeChecks()

        Dim tempdata As String
        Dim num As Decimal

        Do

            Console.WriteLine("Enter a number")
            tempdata = Console.ReadLine()

            If IsNumeric(tempdata) Then

            Else

                Console.WriteLine("ERROR")

            End If

        Loop Until IsNumeric(tempdata)

        num = tempdata

        Console.WriteLine("Input: " & num)

    End Sub


    Sub SimpleValidation3()

        Dim pass As String
        Dim length As Integer
        Dim parity As Boolean = False

        Console.WriteLine("Enter a password")

        Do

            pass = Console.ReadLine()

            length = Len(pass)

            If length < 8 Then


                Console.WriteLine("ERROR
Try again")
            Else

                parity = True

            End If
        Loop Until parity = True

        Console.WriteLine("INPUT was " & pass & "
Characters long: " & length)


    End Sub

    Sub SimpleValidation2()

        Dim numOfWeek As String
        Dim parity As Boolean = False

        Console.WriteLine("Enter the number of the day of the week")

        Do

            numOfWeek = Console.ReadLine()

            If numOfWeek < 1 Or numOfWeek > 7 Then


                Console.WriteLine("ERROR
Try again")
            Else

                parity = True

            End If
        Loop Until parity = True

        Console.WriteLine("INPUT was " & numOfWeek)


    End Sub
    Sub SimpleValidation()

        Dim text As String
        Dim parity As Boolean = False

        Console.WriteLine("Enter some text")

        Do

            text = Console.ReadLine()

            If text <> "" Then

                parity = True

            Else

                Console.WriteLine("ERROR
Try again")

            End If
        Loop Until parity = True

        Console.WriteLine("Text = " & text)


    End Sub

    Sub PredictAndTest()

        Dim mark As Integer

        Dim maxMark As Integer

        Dim percentage As Decimal



        Console.Write("Enter the maximum mark: ")

        maxMark = Console.ReadLine()

        Console.Write("Enter the student mark: ")

        mark = Console.ReadLine()



        percentage = (mark / maxMark) * 100



        Console.WriteLine("The percentage is: " & percentage)



        Console.ReadKey()

    End Sub

    Sub ReadFile()

        Dim fileName As String = "granny.txt"
        Dim line As String

        Dim file As System.IO.StreamReader
        file = My.Computer.FileSystem.OpenTextFileReader(fileName)

        For i = 0 To 11

            line = file.ReadLine

            Console.WriteLine(line)

        Next

        file.Close()


    End Sub

    Sub FileHandling()

        Dim score As Integer = 0
        Dim hiScore As Integer
        Dim shot As Char
        Dim save As Char
        Dim play As Boolean = True
        Dim play2 As Boolean = True
        Dim random As Integer
        Dim fileName As String = "hiScore"
        Dim name As String
        Dim hiHolder As String
        Dim filename2 As String = "hiHolder"
        Dim choice As String
        While play2 = True
            Dim file As System.IO.StreamReader
        file = My.Computer.FileSystem.OpenTextFileReader(fileName)
        hiScore = file.ReadLine()
        file.Close()

        Dim file4 As System.IO.StreamReader
        file4 = My.Computer.FileSystem.OpenTextFileReader(filename2)
        hiHolder = file.ReadLine()
        file.Close()

        Console.WriteLine("The current high score holder is " & hiHolder)

        Console.WriteLine("Enter your name:")
        name = Console.ReadLine()


        Console.WriteLine("Penalty challenge: Score to beat = " & hiScore)

        While play = True

            Console.WriteLine("Choose direction of shot")
            Console.WriteLine("Left (L)")
            Console.WriteLine("Right (R)")
            Console.WriteLine("Mid (M)")
            shot = Console.ReadLine()

            Randomize()
            random = (2 * Rnd() + 1)

            Select Case random
                Case = 1
                    save = "L"
                Case 2
                    save = "m"
                Case 3
                    save = "R"

            End Select

            If shot = save Then
                Console.WriteLine("Your shot was saved")
                play = False

            Else
                Console.WriteLine("GOAL!")
                score += 1
                Console.WriteLine("You have scored: " & score & "
Take another penalty...")


            End If

        End While

        Console.WriteLine("Game over")

        If score > hiScore Then
            Console.WriteLine("You beat the high score")
            hiHolder = name
            hiScore = score

            Dim file2 As System.IO.StreamWriter
            file2 = My.Computer.FileSystem.OpenTextFileWriter(fileName, False)
            file2.WriteLine(hiScore)
            file.Close()

            Dim file3 As System.IO.StreamWriter
            file3 = My.Computer.FileSystem.OpenTextFileWriter(filename2, False)
            file3.WriteLine(hiHolder)
            file.Close()


        End If

        Console.WriteLine("Play again Y/N?")
        choice = Console.ReadLine()
            If choice = "Y" Then

            Else
                play2 = False

            End If

        End While

    End Sub



    Sub Substrings2()

        Dim stringA As String

        Console.WriteLine("Enter a string")
        stringA = Console.ReadLine()

        Console.WriteLine(First3Chars(stringA))

    End Sub

    Function First3Chars(ByVal stringA As String) As String

        Return stringA.Substring(0, 3)

    End Function

    Sub Substrings()

        Dim bankCard As String

        Console.WriteLine("Enter bank card number")
        bankCard = Console.ReadLine()

        Console.WriteLine(GetCardID(bankCard))


    End Sub

    Function GetCardID(ByVal bankCard As String) As String

        Return bankCard.Substring(12, 4)

    End Function

    Sub SearchString2()
        Dim stringA As String
        Dim searchItem As Char

        Console.WriteLine("Enter a string")
        stringA = Console.ReadLine()

        Console.WriteLine("Enter a letter to search for")
        searchItem = Console.ReadLine()



        Console.WriteLine("The character was found " & CountChar(stringA, searchItem) & " times")

    End Sub


    Function CountChar(ByVal StringA As String, ByVal charA As Char) As Integer

        Dim amountFound As Integer = 0

        For index = 0 To (Len(StringA) - 1)
            If StringA(index) = charA Then
                amountFound += 1
            End If
        Next

        Return (amountFound)

    End Function


    Sub SearchString()
        Dim stringA As String
        Dim searchItem As Char

        Console.WriteLine("Enter a string")
        stringA = Console.ReadLine()

        Console.WriteLine("Enter a letter to search for")
        searchItem = Console.ReadLine()

        If ContainsChar(stringA, searchItem) Then

            Console.WriteLine("Character found")

        Else
            Console.WriteLine("Character not found")

        End If

    End Sub


    Function ContainsChar(ByVal stringA As String, ByVal charA As Char) As Boolean

        Dim location As Integer = -1

        For index = 0 To (Len(stringA) - 1)
            If stringA(index) = charA Then
                location = index
            End If
        Next

        If location = -1 Then
            Return (False)
        Else
            Return (True)
        End If

    End Function


    Sub LinearSearch2()
        Dim fish() = {"Cod", "Hake", "Sprat", "Capelin", "Pollock", "Trout", "Herring", "Tuna", "Salmon", "Haddock", "Anchovy", "Sardine", "Carp", "Smelt", "Bream", "Whiting"}
        Dim searchItem As String
        Dim location As Integer = -1

        Console.WriteLine("Enter the name of a fish")
        searchItem = Console.ReadLine()


        For index = 0 To 15
            If fish(index) = searchItem Then
                location = index
            End If
        Next

        If location = -1 Then
            Console.WriteLine("Item not found")
        Else
            Console.WriteLine("Location of item: " & location)
        End If



    End Sub

    Sub LinearSearch()

        Dim myNumbers() = {5, 9, 4, 3, 1, 12, 5, 12, 13, 1}
        Dim location As Integer = -1
        Dim searchItem As Integer

        Console.WriteLine("Enter search item:")
        searchItem = Console.ReadLine()

        For index = 0 To 9
            If myNumbers(index) = searchItem Then
                location = index
            End If
        Next

        If location = -1 Then
            Console.WriteLine("Item not found")
        Else
            Console.WriteLine("Location of item: " & location)
        End If
    End Sub



    Sub parcel()
        'declare variables + constants + assign starting values
        Const heavyweight As Integer = 30
        Dim heavyAmount As Integer = 0
        Dim totalWeight As Integer = 0
        Dim heaviest As Integer = 0

        ' declare arrays
        Dim weight(100) As Integer
        Dim parcelID(100) As String
        Dim sender(100) As String
        Dim heavyItem(100) As Boolean
        Dim recipient(100) As String
        ' values of weight
        For index = 0 To 99
            Randomize()
            weight(index) = (9 * Rnd() + 1)
        Next

        ' Is item heavy.        
        For count = 0 To 99

            If weight(count) > heavyweight Then

                heavyItem(count) = True
                ' Amount of heavy items.
                heavyAmount += 1
                ' Details of heavy items.
                Console.WriteLine("Parcel ID: Sender: Recipient: Weight: ")
                Console.WriteLine(parcelID(count) & sender(count) & recipient(count) & weight(count))
                ' Heaviest item.
                If weight(count) > heaviest Then

                    heaviest = weight(count)

                End If

            End If
            'total weight.
            totalWeight += weight(count)

        Next
        ' output total weight + heaviest weight
        Console.WriteLine("Total weight:" & totalWeight)
        Console.WriteLine("Heaviest weight:" & heaviest & "Kg")

    End Sub

    Sub beepinator()
        Randomize()

        For i = 1 To (999999999 * Rnd() + 1)

            Dim freq As Integer = (32700 * Rnd() + 38)
            Dim time As Integer = (350 * Rnd() + 10)

            Console.Beep(freq, time)
        Next

    End Sub

    Sub GroupedArrays3()

        Dim customerID() = {“112”, “217”, “126”, “156”, “143”, “187”, “145”, “143”, “231”, “232”}

        Dim name() = {“Alice”, “Bob”, “Charlie”, “Deena”, “Evie”, “Frank”, "George”, “Harry”, “Isha”, “Jenny”}

        Dim age() = {45, 16, 27, 17, 40, 32, 55, 18, 31, 29}

        Dim Choice As Integer


        Console.WriteLine(“1. Search using: ID  
2. Search using: Age  
3. Search using: Gender")


        Choice = Console.ReadLine()

        Select Case Choice
            Case Is = 1

                Dim person As Integer

                Dim searchS As String



                Console.WriteLine(“Enter the ID of the person you’re looking for:”)
                searchS = Console.ReadLine()



                Select Case searchS


                    Case Is = 112
                        person = 0

                    Case Is = 217
                        person = 1

                    Case Is = 126
                        person = 2

                    Case Is = 156
                        person = 3

                    Case Is = 143
                        person = 4

                    Case Is = 187
                        person = 5

                    Case Is = 145
                        person = 6

                    Case Is = 143
                        person = 7

                    Case Is = 231
                        person = 8

                    Case Is = 232
                        person = 9
                End Select

                Console.WriteLine(”ID   Name    Age”)
                Console.WriteLine(customerID(person) & “ “ & name(person) & “ “ & age(person))


        End Select
    End Sub

    Sub StringHandling2()

        Dim sentence As String

        Dim upperSentence As String

        Dim lowerSentence As String

        Dim choice As Integer



        Console.WriteLine(“Enter a sentnece”)

        sentence = Console.ReadLine()



        upperSentence = UCase(sentence)

        lowerSentence = LCase(sentence)





        Console.WriteLine(“1. Upper Case: 

2. Lower case 

3.Crazy Dave”)



        Select Case choice

            Case Is = 1
                Console.WriteLine(upperSentence)



            Case Is = 2
                Console.WriteLine(lowerSentence)



            Case Is = 3
                Console.WriteLine(CrazyDave(sentence))


        End Select

    End Sub





    Function CrazyDave(ByVal sentence As String) As String

        Dim sentenceLength As Integer

        sentenceLength = Len(sentence)



        For I = 0 To sentenceLength - 1



            'sentence(I) = LCase(sentence(I))

            I += 1

            'sentence(I) = UCase(sentence(I))

        Next

        Return (sentence)

    End Function



    Sub StringHandling()

        Dim sentence As String
        Dim sentenceLength As Integer
        Dim i As Integer

        Console.WriteLine("enter a sentence")
        sentence = Console.ReadLine
        sentenceLength = Len(sentence)
        Console.WriteLine("There are " & sentenceLength & " characters in your sentence")
        Console.ReadKey()

        For i = 0 To sentenceLength - 1

            Console.WriteLine(sentence(i))

        Next

    End Sub

    Sub GroupedArrays2()

        Dim choice As Integer


        Console.WriteLine(“1. Input 
2. Output")

        choice = Console.ReadLine()



        If choice = 1 Then

            Input()

        Else

            Output()

        End If


    End Sub



    Sub Input()
        Dim vehicleReg = {“CMN 125 V”, “DMN 56 F”, “MAN 49 T”, “VMN 12 E”, ""}
        Dim make = {“Ford”, “Honda”, “Vauxhall”, “Ford”, ""}
        Dim model = {“Galaxy”, “Civic”, “Zafira”, “Kuga”, ""}
        Dim Yeay = {“2002”, “1999”, “2007”, “2015”, ""}
        Dim colour = {“Silver”, “Red”, “Silver”, “White”, ""}


        Console.WriteLine(“Enter the data for a vehicle 
Registration:”)
        vehicleReg(4) = Console.ReadLine()

        Console.WriteLine(“Make:”)
        make(4) = Console.ReadLine()

        Console.WriteLine(“Model:”)
        model(4) = Console.ReadLine()

        Console.WriteLine(“Year:”)
        Yeay(4) = Console.ReadLine()

        Console.WriteLine(“Colour:”)
        colour(4) = Console.ReadLine()


    End Sub



    Sub Output()
        Dim vehicleReg = {“CMN 125 V”, “DMN 56 F”, “MAN 49 T”, “VMN 12 E”}
        Dim make = {“Ford”, “Honda”, “Vauxhall”, “Ford”}
        Dim model = {“Galaxy”, “Civic”, “Zafira”, “Kuga”}
        Dim Yeay = {“2002”, “1999”, “2007”, “2015”}
        Dim colour = {“Silver”, “Red”, “Silver”, “White”}

        Console.WriteLine(“VehicleRegistration         Make         Model        Year         Colour”)

        For index = 0 To 3


            Console.Write(vehicleReg(index))
            Console.Write(make(index).PadLeft(28))
            Console.Write(model(index).PadLeft(11))
            Console.Write(Yeay(index).PadLeft(11))
            Console.WriteLine(colour(index).PadLeft(15))

        Next index


    End Sub



    Sub GroupedArrays()

        Console.WriteLine("How many students do you have?")
        Dim length As Integer = (Console.ReadLine() - 1)

        Dim studentID = {"1001", "1002", "1003"}, surname = {"Smith", "Jones", "Ellis"}, grade = {"C", "B", "A"}

        Console.Write("studentID")
        Console.Write("surname".PadLeft(8))
        Console.WriteLine("grade".PadLeft(9))

        For I = 0 To length



            Console.Write(studentID(I))
            Console.Write(surname(I).PadLeft(11))
            Console.WriteLine(grade(I).PadLeft(10))



        Next

    End Sub


    Sub ArraysPrograms2()

        Dim large As Integer = 0, num(10) As Integer

        For count = 1 To 10
            Console.WriteLine("Enter a number")
            num(count - 1) = Console.ReadLine()

            If num(count - 1) > large Then

                large = num(count - 1)

            End If


        Next

        Console.WriteLine(large)

    End Sub

    Sub ArraysPrograms()

        Dim total As Integer = 0, average As Integer = 0, scores = {50, 70, 60, 55, 65}

        For count = 1 To 5

            total += scores(count - 1)

        Next

        average = total / 5
        Console.WriteLine(average)

    End Sub

    Sub ArraysIteration4()
        Dim num As Integer

        Console.WriteLine(“How many people are in your class?”)

        num = Console.ReadLine()



        Dim names(num) As String

        Dim tutorGroup(num) As String

        Dim count As Integer



        For count = 0 To num

            Console.WriteLine(“Enter name of student”)

            names(count) = Console.ReadLine()

            Console.WriteLine(“Enter their Tutor Group”)

            tutorGroup(count) = Console.ReadLine()

        Next

        For count = 0 To num

            Console.WriteLine(“Name             “, “ Tutor Group”)

            Console.WriteLine(names(count), “           “ & tutorGroup(count))
        Next
    End Sub

    Sub ArraysIteration2()

        Dim fbTeams() As String = {"Chelsea", "Spurs", "Man Utd", "Man City", "Liverpool", "Arsenal", "Everton", "West Brom", "Stoke", "Saints", "West Ham", "Burnley", "Watford", "Bournemouth", "Leicester", "Swansea", "Palace", "Hull", "Middlesbrough", "Sunderland"}
        Dim count As Integer

        For count = 0 To 19

            Console.WriteLine(fbTeams(count))

        Next


    End Sub

    Sub ArraysIteration()

        Dim name(10) As String

        Dim count As Integer
        For count = 1 To 10

            Console.WriteLine("Enter name")
            name(count) = Console.ReadLine()

        Next

    End Sub

    Sub ExtendedASCII2a()
        Dim choice As Integer

        Console.WriteLine("
                           ╔═════════════════════╗
                           ║ ASCII and UNICODE   ║
                           ╠═════════════════════╣
                           ║ 1. Get ASCII number ║
                           ║ 2. Get ASCII char   ║
                           ║ 3. ???              ║
                           ║ 4. ???              ║
                           ║ 5. Quit             ║
                           ╚════════════════════ ╝
                            Enter choice:      ")

        choice = Console.ReadLine()

        Select Case choice
            Case 1
                Console.WriteLine(ExtendedASCII2b())


        End Select

    End Sub

    Function ExtendedASCII2b()

        Dim character As Char, aSCII As String

        Console.WriteLine("Enter a character")
        character = Console.ReadLine()
        aSCII = Asc(character)
        Return (aSCII)

    End Function


    Sub Array()
        Dim cheese(6) As String
        cheese(1) = "Edam"
        cheese(2) = "Cheddar"
        cheese(3) = "Red Leicester"
        cheese(4) = ("Wensleydale")
        cheese(5) = ("Moon")
        cheese(6) = ("Stilton")

        For index = 0 To 5
            Console.WriteLine(cheese(index))
        Next
    End Sub

    Sub Array2()
        Dim cheeses() As String = {"Edam", "Cheddar", "Red Leicester", "Wensleydale", "Moon", "Stilton"}

        For index = 0 To 5
            Console.WriteLine(cheeses(index))
        Next
    End Sub

    Sub Array4()
        Dim planets() As String = {"Mercury", "Venus", "Earth", "Mars", "Jupiter", "Saturn", "Uranus", "Neptune"}
        Dim choice As Integer
        Console.WriteLine("Enter a number: 1 - 8 for the planets of the solar system")
        choice = Console.ReadLine

        Select Case choice
            Case 1
                Console.WriteLine(planets(0))
            Case 2
                Console.WriteLine(planets(1))
            Case 3
                Console.WriteLine(planets(2))
            Case 4
                Console.WriteLine(planets(3))
            Case 5
                Console.WriteLine(planets(4))
            Case 6
                Console.WriteLine(planets(5))
            Case 7
                Console.WriteLine(planets(6))
            Case 8
                Console.WriteLine(planets(7))
        End Select
    End Sub

    Sub Menu2SelectCase()

        Dim choice As Integer

        Do
            Console.Clear()
            Console.WriteLine("1) Direction")
            Console.WriteLine("2) Day of Week")
            Console.WriteLine("3) Month of Year")
            Console.WriteLine("4) Test Grade")
            Console.WriteLine("5) Direction")

        Loop Until choice = 5

    End Sub


    Sub LoopUntil5()

        Dim min As Integer, max As Integer, num As Integer, finalMax As Integer, finalMin As Integer

        Console.WriteLine("Enter a number")
        max = Console.ReadLine()
        min = max


        Do

            Console.WriteLine("Enter another number")
            num = Console.ReadLine()

            If num = -999 Then

                finalMax = max

                finalMin = min


            End If

            If num > max Then

                max = num

            End If

            If num < min Then

                min = num

            End If


        Loop Until num = -999

        Console.WriteLine("Your smallest number is " & finalMin & " and your biggest number is " & finalMax)

    End Sub

    Sub LoopUntil()

        Dim total As Integer = 0, count As Integer = 0, num As Integer, average As Decimal


        Do

            Console.Write(＂Enter a Number: ＂)

            num = Console.ReadLine()
            If num <> -999 Then
                total += num
                count += 1

            End If

        Loop Until (num = -999)
        average = (num / count)

        Console.WriteLine(average)

    End Sub
    Sub WhileLoops2()

        Dim num As Integer, num2 As Integer
        num = 1
        num2 = 5
        While num < 50

            num += num2

        End While

        Console.WriteLine("Program Finished")


    End Sub

    Sub WhileLoops()

        Dim i As Integer

        Console.Write(＂Enter a Number: ＂)

        i = Console.ReadLine()

        While i < 10

            Console.WriteLine(i)

            i += 1

        End While

        Console.WriteLine(＂Finished Program＂)

    End Sub

    Sub l2LoopsOfChristmas()

        Dim day1 As String, day2 As String, day3 As String, day4 As String, day5 As String, day6 As String,
        day7 As String, day8 As String, day9 As String, day10 As String, day11 As String, day12 As String,
        dayWord As String, dayWordCount As Integer, totalString As String





        day1 = " and a Partridge in a Pair Tree 

"

        day2 = " 2 Turtle Doves 

"

        day3 = " 3 French Hens 

"

        day4 = " 4 Calling Birds 

"

        day5 = " 5 Golden Rings 

"

        day6 = " 6 Geese a laying 

"

        day7 = " 7 Swans a Swimming 

"

        day8 = " 8 Maids are Milking 

"

        day9 = " 9 Ladies Dancing 

"

        day10 = " 10 Lords are Leaping 

"

        day11 = " 11 Pipers Pipping 

"

        day12 = " 12 Drummers Drumming 

"

        dayWordCount = 0

        totalString = ""



        dayWord = "First"



        Console.WriteLine("On the " & dayWord & " day of Christmas my true love sent to me a Partridge in a Pair Tree 

")



        For i = 2 To 12 Step 1



            dayWordCount = i

            Select Case dayWordCount



                Case 2

                    dayWord = "Second"

                Case 3

                    dayWord = "Third"

                Case 4

                    dayWord = "Fourth"

                Case 5

                    dayWord = "Fifth"

                Case 6

                    dayWord = "Sixth"

                Case 7

                    dayWord = "Seventh"

                Case 8

                    dayWord = "Eighth"

                Case 9

                    dayWord = "Ninth"

                Case 10

                    dayWord = "Tenth"

                Case 11

                    dayWord = "Eleventh"

                Case 12

                    dayWord = "Twelfth"



            End Select





            Select Case i

                Case 12

                    totalString = day12 & totalString

                Case Is > 10

                    totalString = day11 & totalString

                Case Is > 9

                    totalString = day10 & totalString

                Case Is > 8

                    totalString = day9 & totalString

                Case Is > 7

                    totalString = day8 & totalString

                Case Is > 6

                    totalString = day7 & totalString

                Case Is > 5

                    totalString = day6 & totalString

                Case Is > 4

                    totalString = day5 & totalString

                Case Is > 3

                    totalString = day4 & totalString

                Case Is > 2

                    totalString = day3 & totalString

                Case Is > 1

                    totalString = day2 & totalString

                Case Is > 0

                    totalString = day1 & totalString



            End Select





            Console.WriteLine("On the " & dayWord & " day of Christmas my true love sent to me 

" & totalString & " and a Partridge in a Pair Tree 

")



        Next

    End Sub

    Sub ForNextAverageProgram()

        Dim num As Integer, sum As Decimal
        sum = 0

        For i = 1 To 5 Step 1

            Console.WriteLine("Enter a number")

            num = Console.ReadLine()

            sum += num

        Next

        sum /= 5

        Console.WriteLine("The average of your numbers is " & sum)

    End Sub


    Sub DryRun2()

        Dim num As Integer
        num = 2
        Dim num2 As Integer
        num2 = 5

        Console.WriteLine(num)
        Console.WriteLine(num2)

        For i = 1 To 4

            num += num2
            Console.WriteLine(num)
            num2 = num

        Next

        Console.WriteLine("Done")


    End Sub

    Sub DryRun()

        Dim num As Integer
        num = 5
        Console.WriteLine(num)
        For i = 1 To 3

            num += i
            Console.WriteLine(num)

        Next

        Console.WriteLine("Done")


    End Sub



    Sub ChristmasTree2()


        Dim star As String
        star = "*"

        Dim a As Integer

        For a = 1 To 10
            Console.WriteLine(" ".PadLeft(50))
        Next
        For i = 1 To a
            Console.Write("*")

        Next
    End Sub
    Sub ChristmasTree()

        Dim num As Integer
        num = 50



        For j = 1 To 10
            For pd = 1 To 10
                Console.Write(" ".PadLeft(num - pd))
            Next
            For i = 1 To j
                Console.Write("*")

            Next

            Console.WriteLine("")
        Next


    End Sub

    Sub RandomIfThenElse()

        Dim playerCall As String

        Dim computerCallv As String



        Console.WriteLine("Rock, Paper, or Scissors?")

        playerCall = Console.ReadLine



        computerCallv = ComputerCall()



        RPS(playerCall, computerCallv)



    End Sub



    Function RPS(ByVal playerCall As String, ByVal computerCallv As String)

        Select Case playerCall
            Case = "rock"
                If playerCall = computerCallv Then
                    Console.WriteLine("Draw")

                ElseIf computerCallv = "scissors" Then
                    Console.WriteLine("Winner")
                Else
                    Console.WriteLine("Loser")
                End If
            Case = "Scissors"
                If playerCall = computerCallv Then
                    Console.WriteLine("Draw")

                ElseIf computerCallv = "paper" Then
                    Console.WriteLine("Winner")
                Else
                    Console.WriteLine("Loser")
                End If
            Case = "paper"
                If playerCall = computerCallv Then
                    Console.WriteLine("Draw")

                ElseIf computerCallv = "rock" Then
                    Console.WriteLine("Winner")
                Else
                    Console.WriteLine("Loser")
                End If
        End Select





        ' If playerCall = computerCallv Then

        'Console.WriteLine("draw")



        '  Else

        'ayerCall = "rock"

        'If computerCallv = "scissors" Then

        'Console.WriteLine("Winner")



        'ElseIf computerCallv = "paper" Then

        'le.WriteLine("Loser")



        'ElseIf playerCall = "paper" Then

        'uterCallv = "rock" Then

        '  Console.WriteLine("Winner")



        'ElseIf computerCallv = "scissors" Then

        'Console.WriteLine("Loser")



        'ElseIf computerCallv = "rock" Then

        'sole.WriteLine("Loser")



        '   Else

        'Console.WriteLine("Winner")

        '   End If

        '   End If

        ' End If

    End Function



    Function ComputerCall()

        Dim rckPprScrrs As String, computerCallv As String

        Randomize()

        rckPprScrrs = (2 * Rnd()) + 1

        If rckPprScrrs = 3 Then

            computerCallv = "scissors"
            Return (computerCallv)

        ElseIf rckPprScrrs = 2 Then

            computerCallv = "paper"

            Return (computerCallv)

        Else

            computerCallv = "rock"

            Return (computerCallv)

        End If



    End Function

    Sub BinaryShifts()
        Dim denary As Byte
        Dim output As Byte
        Dim shiftNum As Byte
        Dim shiftType As Boolean

        Console.WriteLine("Enter a denary Integer")
        denary = Console.ReadLine()
        Console.WriteLine("Do you want a left Or right shift?
Type: '1' for left.  '0' for right")
        shiftType = Console.ReadLine()
        Console.WriteLine("How many places do you wnat to shift?")
        shiftNum = Console.ReadLine()

        If shiftType = True Then
            output = denary << shiftNum

        Else
            output = denary >> shiftNum

        End If

        Console.WriteLine(output)


    End Sub


    Sub ForNext()
        Dim num As Integer
        Dim num2 As Integer
        Dim answer As Integer
        Dim total As Integer
        Dim sum As Decimal
        sum = 0
        total = 0
        Randomize()

        For i = 1 To 10 Step 1
            num = (19 * Rnd()) + 1
            num2 = (19 * Rnd()) + 1
            sum = num + num2
            Console.WriteLine(num & " + " & num2 & " =")
            answer = Console.ReadLine()

            If answer = sum Then
                total += 1
                Console.WriteLine("Correct")

            Else
                Console.WriteLine("Wrong")
            End If

        Next

        Console.WriteLine("You got " & total & " out of 10")
    End Sub

    Sub Flowgarith10Question()


        Dim count As Integer

        count = 0
        Dim score As Integer

        score = 0
        Dim num As Integer
        Dim num2 As Integer
        Dim sum As Integer
        Dim guess As Integer

        Do While count < 11
            num = Rnd(10) + 1
            num2 = Rnd(10) + 1
            sum = num + num2
            Console.WriteLine(num & "+" & num2)

            If guess = sum Then
                score += 1
            End If
            count += 1
        Loop
        Console.WriteLine("You got " & score & " out of 10")
    End Sub


    Sub CreatingAMenu()

        Dim choice As Integer

        Console.BackgroundColor = ConsoleColor.White
        Console.ForegroundColor = ConsoleColor.Black
        Console.Clear()

        Console.WriteLine("Which Task would you like to run?")
        Console.WriteLine("1. Direction")
        Console.WriteLine("2. Day of the week")
        Console.WriteLine("3. Month of the year")

        choice = Console.ReadLine()

        Select Case choice
            Case 1
                Direction()

            Case 2
                DayOfTheWeek()

            Case 3
                MonthOfTheYear()

            Case Else
                Console.WriteLine("Not a valid Choice")
        End Select

    End Sub

    Sub Direction()

        Dim direction As Char
        Console.WriteLine("Which direction do you want to go?")
        direction = Console.ReadLine
        Select Case direction
            Case "W"
                Console.WriteLine("You move up")
            Case "A"
                Console.WriteLine("You move left")
            Case "S"
                Console.WriteLine("You move down")
            Case "D"
                Console.WriteLine("You move right")
            Case Else
                Console.WriteLine("You pressed the worng key")
        End Select

    End Sub



    Sub DayOfTheWeek()

        Dim num As Char

        Console.WriteLine("Enter which number of the week it is")
        num = Console.ReadLine

        Select Case num

            Case "1"

                Console.WriteLine("Monday")

            Case "2"

                Console.WriteLine("Tuesday")

            Case "3"

                Console.WriteLine("Wednesday")

            Case "4"

                Console.WriteLine("Thursday")

            Case "5"

                Console.WriteLine("Friday")

            Case "6"

                Console.WriteLine("Saturday")

            Case "7"

                Console.WriteLine("Sunday")

            Case Else

                Console.WriteLine("You pressed the wrong key")

        End Select

    End Sub



    Sub MonthOfTheYear()

        Dim num As Integer

        Console.WriteLine("Enter which number month of the year it is")

        num = Console.ReadLine

        Select Case num

            Case < 1

                Console.WriteLine("Not a month")

            Case < 3

                Console.WriteLine("That`s in Winter")

            Case < 6

                Console.WriteLine("That`s in Spring")

            Case < 9

                Console.WriteLine("That`s in Summer")

            Case < 12

                Console.WriteLine("That`s in Autumn")

            Case = 12

                Console.WriteLine("That`s in Winter")

            Case Else

                Console.WriteLine("Not a month")

        End Select

    End Sub


    Sub SelectCase()
        Dim mark As Integer

        Console.WriteLine("Enter your mark")
        mark = Console.ReadLine

        Select Case mark

            Case < 0
                Console.WriteLine("Can`t get that mark")

            Case < 17
                Console.WriteLine("Grade: U")

            Case < 21
                Console.WriteLine("Grade: G")

            Case < 28
                Console.WriteLine("Grade: F")

            Case < 35
                Console.WriteLine("Grade: E")

            Case < 43
                Console.WriteLine("Grade: D")

            Case < 55
                Console.WriteLine("Grade: C")

            Case < 67
                Console.WriteLine("Grade: B")

            Case < 80
                Console.WriteLine("Grade: A")

            Case < 100
                Console.WriteLine("Grade: A*")

            Case Else
                Console.WriteLine("Can`t get that mark")
        End Select

    End Sub



    Sub LogicalOperators()
        Dim superName As String = "Robin"
        Dim superName2 As String = "Nightwing"
        Dim input As String

        Console.WriteLine("What Is the superhero name of the DC Comics character Dick Grayson?")

        input = Console.ReadLine()

        If superName = input Or superName2 = input Then
            Console.WriteLine("Correct")

        Else
            Console.WriteLine("Incorrect")

        End If
    End Sub

    Sub LuckyDice()
        Randomize()
        Dim result As Integer
        Dim result2 As Integer
        Dim total As Integer
        result = (5 * Rnd()) + 1
        result2 = (5 * Rnd()) + 1
        If (result = result2) Then
            Dim result3 As Integer
            Dim result4 As Integer
            result3 = (5 * Rnd()) + 1
            result4 = (5 * Rnd()) + 1
            total = result + result2 + result3 + result4
            Console.WriteLine(“Die 1 was ” & result & “ And die 2 was ” & result2 & " And die 3 was " & result3 & " And die 4 was " & “ so the total Is “ & total)
        Else
            total = result + result2
            Console.WriteLine(“Die 1 was ” & result & “ And die 2 was ” & result2 & “ so the total Is “ & total)
        End If

    End Sub

    Sub IfThenElse2()
        Dim firstNum As Decimal
        Dim secondNum As Decimal
        Dim choice As Integer
        Dim result As Decimal

        Console.WriteLine(“Simple Calculator”)
        Console.WriteLine(“*****************”)

        Console.WriteLine(“Enter your first number”)
        firstNum = Console.ReadLine

        Console.WriteLine(“Enter your second number”)
        secondNum = Console.ReadLine

        Console.WriteLine(“Do you want to

1. Add your numbers 

2. Subtract your numbers 

3. Multiply your numbers 

4. Divide your numbers")

        choice = Console.ReadLine

        If (choice = 1) Then
            result = firstNum + secondNum
        ElseIf (choice = 2) Then
            result = firstNum - secondNum

        ElseIf (choice = 3) Then
            result = firstNum * secondNum

        Else
            result = firstNum / secondNum

        End If

        Console.WriteLine(
            result)
    End Sub
    Sub IfThenElse()
        'Distinction/Pass/fail Algorithm 
        'Declare Variables And Constants
        Const passMark As Integer = 25
        Const distinctMark As Integer = 50
        Dim studMark As Integer

        'Ask for mark 
        Console.WriteLine(“Enter the mark you got:”)
        studMark = Console.ReadLine()
        'Decide output 
        If studMark > distinctMark Then
            Console.WriteLine(“Distinction”)
        ElseIf studMark > passMark Then
            Console.WriteLine(“Pass”)
        Else
            Console.WriteLine(“Fail”)

        End If
    End Sub
    Sub PseudoCodeStarter()
        'Declare Variables 
        Dim test1 As Integer
        Dim test2 As Integer
        Dim test3 As Integer
        Dim test4 As Integer
        Dim average As Decimal

        Console.WriteLine(“Average Mark Calculator”)
        Console.WriteLine(“***********************”)

        'Ask for input And assign values 
        Console.WriteLine(“Enter the 4 test marks”)
        Console.WriteLine(“Test 1:”)
        test1 = Console.ReadLine()
        Console.WriteLine(“Test 2:”)
        test2 = Console.ReadLine()
        Console.WriteLine(“Test 3:”)
        test3 = Console.ReadLine()
        Console.WriteLine(“Test 4:”)
        test4 = Console.ReadLine()

        'Calculate Average Mark 
        average = (test1 + test2 + test3 + test4) / 4

        'Output the result 
        Console.WriteLine(“The average mark is: “ & average)
    End Sub
    Sub PseudoCode()
        'Declare Variables 
        Dim adminFee As Decimal
        Dim dollars As Double
        Dim pounds As Decimal
        Dim adminPounds As Decimal
        Console.WriteLine(“currency converter”)
        Console.WriteLine(“*****************************************”)

        'Ask for input and assign values 
        Console.WriteLine(“Enter the amount of pounds you want to convert”)
        pounds = Console.ReadLine()

        'Calculate dollar amount + administration fee 
        adminPounds = pounds * 0.95
        adminFee = pounds - adminPounds
        dollars = adminPounds * 1.3
        dollars = Math.Round(dollars, 2)

        'Output the result 
        Console.WriteLine(“Admininistration fee = “ & adminFee)
        Console.WriteLine(“Dollars = “ & dollars)
    End Sub
    Sub Morefunctions()
        Dim radius As Integer
        Dim area As Decimal

        Console.Write("Please enter the radius of the circle: ")
        radius = Console.ReadLine()
        area = AreaCircle(radius)
        area = Math.Round(area, 1)
        Console.WriteLine("The area of the circle is " & area)
    End Sub

    Function AreaCircle(ByVal radius As Integer) As Decimal
        Const pi As Decimal = 3.142
        Return radius * radius * pi
    End Function

    Sub DeclreVariablesAndConstants()
        'Declaring Variable and Constants
        'Daniel Bassett
        '17/09/21
        Const passMark As Integer = 50

        'Declare VAriables
        Dim name As String = "Bob"
        Dim score As Integer = 58
        Dim grade As Char = "C"
        Console.WriteLine(name)
        Console.WriteLine(score)
        Console.WriteLine(grade)
        Console.WriteLine(passMark)
        Console.ReadKey()
    End Sub

    Sub OutputtingText()
        'Outputting text
        'Daniel Bassett
        '23/09/21

        Dim name As String = "wngtsha"
        Dim town As String = "ianfcahfA"
        Dim school As String = "aoaejmhrwoA"

        Console.WriteLine("Computer Science")
        Console.WriteLine("Console programming")
        Console.WriteLine("Programmers name: Fred Bloggs")
        Console.WriteLine("Date:8th September 2016")
        Console.WriteLine("Press <Enter> or <Return> to continue")
        Console.ReadLine()
        Console.WriteLine("What's your name?")
        name = Console.ReadLine()
        Console.WriteLine("Hello " & name)
        Console.WriteLine("Where do you live?")
        town = Console.ReadLine()
        Console.WriteLine(town & " is a good place to live")
        Console.WriteLine("What school do you go to?")
        school = Console.ReadLine()
        Console.WriteLine("So let me get this right. Your name is " & name & " and you come from " & town & " and you go to " & school)
        Console.ReadLine()
    End Sub


End Module
