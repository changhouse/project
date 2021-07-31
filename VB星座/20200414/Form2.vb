Public Class Form2

    Private Sub Form2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If Form1.You = ("魔羯") Then
            Dim fileReader As String
            fileReader = My.Computer.FileSystem.ReadAllText("../star/" + "魔羯.txt") '接收Form1的魔羯指令
            RichTextBox1.Text = (fileReader) '顯示txt檔
        End If
        If Form1.You = ("水瓶") Then
            Dim fileReader As String
            fileReader = My.Computer.FileSystem.ReadAllText("../star/" + "水瓶.txt") '接收Form1的水瓶指令
            RichTextBox1.Text = (fileReader) '顯示txt檔
        End If
        If Form1.You = ("雙魚") Then
            Dim fileReader As String
            fileReader = My.Computer.FileSystem.ReadAllText("../star/" + "雙魚.txt") '接收Form1的雙魚指令
            RichTextBox1.Text = (fileReader) '顯示txt檔
        End If
        If Form1.You = ("牡羊") Then
            Dim fileReader As String
            fileReader = My.Computer.FileSystem.ReadAllText("../star/" + "牡羊.txt") '接收Form1的牡羊指令
            RichTextBox1.Text = (fileReader) '顯示txt檔
        End If
        If Form1.You = ("金牛") Then
            Dim fileReader As String
            fileReader = My.Computer.FileSystem.ReadAllText("../star/" + "金牛.txt") '接收Form1的金牛指令
            RichTextBox1.Text = (fileReader) '顯示txt檔
        End If
        If Form1.You = ("雙子") Then
            Dim fileReader As String
            fileReader = My.Computer.FileSystem.ReadAllText("../star/" + "雙子.txt")
            RichTextBox1.Text = (fileReader)
        End If
        If Form1.You = ("巨蟹") Then
            Dim fileReader As String
            fileReader = My.Computer.FileSystem.ReadAllText("../star/" + "巨蟹.txt")
            RichTextBox1.Text = (fileReader)
        End If
        If Form1.You = ("獅子") Then
            Dim fileReader As String
            fileReader = My.Computer.FileSystem.ReadAllText("../star/" + "獅子.txt")
            RichTextBox1.Text = (fileReader)
        End If
        If Form1.You = ("處女") Then
            Dim fileReader As String
            fileReader = My.Computer.FileSystem.ReadAllText("../star/" + "處女.txt")
            RichTextBox1.Text = (fileReader)
        End If
        If Form1.You = ("天秤") Then
            Dim fileReader As String
            fileReader = My.Computer.FileSystem.ReadAllText("../star/" + "天秤.txt")
            RichTextBox1.Text = (fileReader)
        End If
        If Form1.You = ("天蠍") Then
            Dim fileReader As String
            fileReader = My.Computer.FileSystem.ReadAllText("../star/" + "天蠍.txt")
            RichTextBox1.Text = (fileReader)
        End If
        If Form1.You = ("射手") Then
            Dim fileReader As String
            fileReader = My.Computer.FileSystem.ReadAllText("../star/" + "射手.txt")
            RichTextBox1.Text = (fileReader)
        End If
        If Form1.You = ("魔羯") Then
            Dim fileReader As String
            fileReader = My.Computer.FileSystem.ReadAllText("../star/" + "魔羯.txt")
            RichTextBox1.Text = (fileReader)
        End If
        '
        '日期
        '
        '
        If Form1.day = ("1") Then
            Dim fileReader As String
            fileReader = My.Computer.FileSystem.ReadAllText("../day/" + "1.txt") '接收Form1的1日指令,則秀出1日指令
            RichTextBox2.Text = (fileReader)
        End If
        If Form1.day = ("2") Then
            Dim fileReader As String
            fileReader = My.Computer.FileSystem.ReadAllText("../day/" + "2.txt") '接收Form1的2日指令,則秀出2日指令
            RichTextBox2.Text = (fileReader)
        End If
        If Form1.day = ("3") Then
            Dim fileReader As String
            fileReader = My.Computer.FileSystem.ReadAllText("../day/" + "3.txt") '接收Form1的3日指令,則秀出3日指令
            RichTextBox2.Text = (fileReader)
        End If
        If Form1.day = ("4") Then
            Dim fileReader As String
            fileReader = My.Computer.FileSystem.ReadAllText("../day/" + "4.txt") '接收Form1的4日指令,則秀出4日指令
            RichTextBox2.Text = (fileReader)
        End If
        If Form1.day = ("5") Then
            Dim fileReader As String
            fileReader = My.Computer.FileSystem.ReadAllText("../day/" + "5.txt") '接收Form1的5日指令,則秀出5日指令
            RichTextBox2.Text = (fileReader)
        End If
        If Form1.day = ("6") Then
            Dim fileReader As String
            fileReader = My.Computer.FileSystem.ReadAllText("../day/" + "6.txt")
            RichTextBox2.Text = (fileReader)
        End If
        If Form1.day = ("7") Then
            Dim fileReader As String
            fileReader = My.Computer.FileSystem.ReadAllText("../day/" + "7.txt")
            RichTextBox2.Text = (fileReader)
        End If
        If Form1.day = ("8") Then
            Dim fileReader As String
            fileReader = My.Computer.FileSystem.ReadAllText("../day/" + "8.txt")
            RichTextBox2.Text = (fileReader)
        End If
        If Form1.day = ("9") Then
            Dim fileReader As String
            fileReader = My.Computer.FileSystem.ReadAllText("../day/" + "9.txt")
            RichTextBox2.Text = (fileReader)
        End If
        If Form1.day = ("10") Then
            Dim fileReader As String
            fileReader = My.Computer.FileSystem.ReadAllText("../day/" + "10.txt")
            RichTextBox2.Text = (fileReader)
        End If
        If Form1.day = ("11") Then
            Dim fileReader As String
            fileReader = My.Computer.FileSystem.ReadAllText("../day/" + "11.txt")
            RichTextBox2.Text = (fileReader)
        End If
        If Form1.day = ("12") Then
            Dim fileReader As String
            fileReader = My.Computer.FileSystem.ReadAllText("../day/" + "12.txt")
            RichTextBox2.Text = (fileReader)
        End If
        If Form1.day = ("13") Then
            Dim fileReader As String
            fileReader = My.Computer.FileSystem.ReadAllText("../day/" + "13.txt")
            RichTextBox2.Text = (fileReader)
        End If
        If Form1.day = ("14") Then
            Dim fileReader As String
            fileReader = My.Computer.FileSystem.ReadAllText("../day/" + "14.txt")
            RichTextBox2.Text = (fileReader)
        End If
        If Form1.day = ("15") Then
            Dim fileReader As String
            fileReader = My.Computer.FileSystem.ReadAllText("../day/" + "15.txt")
            RichTextBox2.Text = (fileReader)
        End If
        If Form1.day = ("16") Then
            Dim fileReader As String
            fileReader = My.Computer.FileSystem.ReadAllText("../day/" + "16.txt")
            RichTextBox2.Text = (fileReader)
        End If
        If Form1.day = ("17") Then
            Dim fileReader As String
            fileReader = My.Computer.FileSystem.ReadAllText("../day/" + "17.txt")
            RichTextBox2.Text = (fileReader)
        End If
        If Form1.day = ("18") Then
            Dim fileReader As String
            fileReader = My.Computer.FileSystem.ReadAllText("../day/" + "18.txt")
            RichTextBox2.Text = (fileReader)
        End If
        If Form1.day = ("19") Then
            Dim fileReader As String
            fileReader = My.Computer.FileSystem.ReadAllText("../day/" + "19.txt")
            RichTextBox2.Text = (fileReader)
        End If
        If Form1.day = ("20") Then
            Dim fileReader As String
            fileReader = My.Computer.FileSystem.ReadAllText("../day/" + "20.txt")
            RichTextBox2.Text = (fileReader)
        End If
        If Form1.day = ("21") Then
            Dim fileReader As String
            fileReader = My.Computer.FileSystem.ReadAllText("../day/" + "21.txt")
            RichTextBox2.Text = (fileReader)
        End If
        If Form1.day = ("22") Then
            Dim fileReader As String
            fileReader = My.Computer.FileSystem.ReadAllText("../day/" + "22.txt")
            RichTextBox2.Text = (fileReader)
        End If
        If Form1.day = ("23") Then
            Dim fileReader As String
            fileReader = My.Computer.FileSystem.ReadAllText("../day/" + "23.txt")
            RichTextBox2.Text = (fileReader)
        End If
        If Form1.day = ("24") Then
            Dim fileReader As String
            fileReader = My.Computer.FileSystem.ReadAllText("../day/" + "24.txt")
            RichTextBox2.Text = (fileReader)
        End If
        If Form1.day = ("25") Then
            Dim fileReader As String
            fileReader = My.Computer.FileSystem.ReadAllText("../day/" + "25.txt")
            RichTextBox2.Text = (fileReader)
        End If
        If Form1.day = ("26") Then
            Dim fileReader As String
            fileReader = My.Computer.FileSystem.ReadAllText("../day/" + "26.txt")
            RichTextBox2.Text = (fileReader)
        End If
        If Form1.day = ("27") Then
            Dim fileReader As String
            fileReader = My.Computer.FileSystem.ReadAllText("../day/" + "27.txt")
            RichTextBox2.Text = (fileReader)
        End If
        If Form1.day = ("28") Then
            Dim fileReader As String
            fileReader = My.Computer.FileSystem.ReadAllText("../day/" + "28.txt")
            RichTextBox2.Text = (fileReader)
        End If
        If Form1.day = ("29") Then
            Dim fileReader As String
            fileReader = My.Computer.FileSystem.ReadAllText("../day/" + "29.txt")
            RichTextBox2.Text = (fileReader)
        End If
        If Form1.day = ("30") Then
            Dim fileReader As String
            fileReader = My.Computer.FileSystem.ReadAllText("../day/" + "30.txt")
            RichTextBox2.Text = (fileReader)
        End If
        If Form1.day = ("31") Then
            Dim fileReader As String
            fileReader = My.Computer.FileSystem.ReadAllText("../day/" + "31.txt")
            RichTextBox2.Text = (fileReader)
        End If
        '
        '
        '血型
        '
        If Form1.bl = ("A") Then
            Dim fileReader As String
            fileReader = My.Computer.FileSystem.ReadAllText("../blood/" + "a.txt") '接收Form1的A型指令,則秀出A型指令
            RichTextBox3.Text = (fileReader)
        End If
        If Form1.bl = ("B") Then
            Dim fileReader As String
            fileReader = My.Computer.FileSystem.ReadAllText("../blood/" + "b.txt") '接收Form1的B型指令,則秀出B型指令
            RichTextBox3.Text = (fileReader)
        End If
        If Form1.bl = ("O") Then
            Dim fileReader As String
            fileReader = My.Computer.FileSystem.ReadAllText("../blood/" + "o.txt") '接收Form1的O型指令,則秀出O型指令
            RichTextBox3.Text = (fileReader)
        End If
        If Form1.bl = ("AB") Then
            Dim fileReader As String
            fileReader = My.Computer.FileSystem.ReadAllText("../blood/" + "ab.txt") '接收Form1的AB型指令,則秀出AB型指令
            RichTextBox3.Text = (fileReader)
        End If
    End Sub
End Class