Public Class Form1
    Public You As String  '此行放頂 Public (星座)
    Public day As String  '此行放頂 Public (日期)
    Public bl As String   '此行放頂 Public (血型)

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        If ComboBox3.SelectedIndex < -1 Then
            You = ""
        End If

        If ComboBox2.SelectedIndex = 0 Then '魔羯 水瓶 1月'
            If ComboBox3.SelectedIndex < 19 Then
                You = ("魔羯")
            End If
            If ComboBox3.SelectedIndex > 19 Then
                You = ("水瓶")
            End If
        End If


        If ComboBox2.SelectedIndex = 1 Then ' 水瓶 雙魚 2月'
                If ComboBox3.SelectedIndex < 19 Then
                    You = ("水瓶")
                End If

                If ComboBox3.SelectedIndex >= 19 Then
                    You = ("雙魚")
                End If
            End If


        If ComboBox2.SelectedIndex = 2 Then '雙魚 牡羊 3月'
            If ComboBox3.SelectedIndex < 20 Then
                You = ("雙魚")
            End If
            If ComboBox3.SelectedIndex > 19 Then
                You = ("牡羊")
            End If

        End If


        If ComboBox2.SelectedIndex = 3 Then '牡羊 金牛 4月'
            If ComboBox3.SelectedIndex < 19 Then
                You = ("牡羊")
            End If
            If ComboBox3.SelectedIndex >= 19 Then
                You = ("金牛")
            End If
        End If

        If ComboBox2.SelectedIndex = 4 Then '金牛 雙子 5月'
            If ComboBox3.SelectedIndex < 20 Then
                You = ("金牛")
            End If
            If ComboBox3.SelectedIndex > 19 Then
                You = ("雙子")
            End If
        End If


        If ComboBox2.SelectedIndex = 5 Then '雙子 巨蟹 6月'
            If ComboBox3.SelectedIndex < 21 Then
                You = ("雙子")
            End If
            If ComboBox3.SelectedIndex >= 21 Then
                You = ("巨蟹")
            End If
        End If


        If ComboBox2.SelectedIndex = 6 Then '巨蟹 獅子 7月'
            If ComboBox3.SelectedIndex < 22 Then
                You = ("巨蟹")
            End If
            If ComboBox3.SelectedIndex >= 22 Then
                You = ("獅子")
            End If
        End If


        If ComboBox2.SelectedIndex = 7 Then '獅子 處女 8月'
            If ComboBox3.SelectedIndex < 22 Then
                You = ("獅子")
            End If
            If ComboBox3.SelectedIndex >= 22 Then
                You = ("處女")
            End If
        End If


        If ComboBox2.SelectedIndex = 8 Then '處女 天秤 9月'
            If ComboBox3.SelectedIndex < 22 Then
                You = ("處女")
            End If
            If ComboBox3.SelectedIndex >= 22 Then
                You = ("天秤")
            End If
        End If


        If ComboBox2.SelectedIndex = 9 Then '天秤 天蠍 10月'
            If ComboBox3.SelectedIndex <= 22 Then
                You = ("天秤")
            End If
            If ComboBox3.SelectedIndex > 22 Then
                You = ("天蠍")
            End If
        End If


        If ComboBox2.SelectedIndex = 10 Then '天蠍 射手 11月'
            If ComboBox3.SelectedIndex < 21 Then
                You = ("天蠍")
            End If
            If ComboBox3.SelectedIndex >= 21 Then
                You = ("射手")
            End If
        End If


        If ComboBox2.SelectedIndex = 11 Then '射手 魔羯 12月'
            If ComboBox3.SelectedIndex < 20 Then
                You = ("射手")
            End If
            If ComboBox3.SelectedIndex > 19 Then
                You = ("魔羯")
            End If

        End If
    '
    '
    '日期
    '
        If ComboBox3.SelectedIndex = 0 Then day = ("1") '判斷日期
        If ComboBox3.SelectedIndex = 1 Then day = ("2")
        If ComboBox3.SelectedIndex = 2 Then day = ("3")
        If ComboBox3.SelectedIndex = 3 Then day = ("4")
        If ComboBox3.SelectedIndex = 4 Then day = ("5")
        If ComboBox3.SelectedIndex = 5 Then day = ("6")
        If ComboBox3.SelectedIndex = 6 Then day = ("7")
        If ComboBox3.SelectedIndex = 7 Then day = ("8")
        If ComboBox3.SelectedIndex = 8 Then day = ("9")
        If ComboBox3.SelectedIndex = 9 Then day = ("10")
        If ComboBox3.SelectedIndex = 10 Then day = ("11")
        If ComboBox3.SelectedIndex = 11 Then day = ("12")
        If ComboBox3.SelectedIndex = 12 Then day = ("13")
        If ComboBox3.SelectedIndex = 13 Then day = ("14")
        If ComboBox3.SelectedIndex = 14 Then day = ("15")
        If ComboBox3.SelectedIndex = 15 Then day = ("16")
        If ComboBox3.SelectedIndex = 16 Then day = ("17")
        If ComboBox3.SelectedIndex = 17 Then day = ("18")
        If ComboBox3.SelectedIndex = 18 Then day = ("19")
        If ComboBox3.SelectedIndex = 19 Then day = ("20")
        If ComboBox3.SelectedIndex = 20 Then day = ("21")
        If ComboBox3.SelectedIndex = 21 Then day = ("22")
        If ComboBox3.SelectedIndex = 22 Then day = ("23")
        If ComboBox3.SelectedIndex = 23 Then day = ("24")
        If ComboBox3.SelectedIndex = 24 Then day = ("25")
        If ComboBox3.SelectedIndex = 25 Then day = ("26")
        If ComboBox3.SelectedIndex = 26 Then day = ("27")
        If ComboBox3.SelectedIndex = 27 Then day = ("28")
        If ComboBox3.SelectedIndex = 28 Then day = ("29")
        If ComboBox3.SelectedIndex = 29 Then day = ("30")
        If ComboBox3.SelectedIndex = 30 Then day = ("31")
    '   
    '
    '血型
    '
        If ComboBox4.SelectedIndex = 0 Then bl = ("A") '判斷血型
        If ComboBox4.SelectedIndex = 1 Then bl = ("B")
        If ComboBox4.SelectedIndex = 2 Then bl = ("O")
        If ComboBox4.SelectedIndex = 3 Then bl = ("AB")



        Select Case ComboBox2.SelectedIndex '排除2/30及2/31
            Case 1
                If ComboBox3.SelectedIndex > 28 Then '數值大於28
                    day = "" '清空數值
                    You = "" '清空數值
                    Form2.Hide()
                    MsgBox("輸入錯誤")



                End If
        End Select
        Select Case ComboBox2.SelectedIndex '排除小月的31日
            Case 3, 5, 8, 10
                If ComboBox3.SelectedIndex > 29 Then
                    day = ""
                    You = ""
                    Form2.Hide()
                    MsgBox("輸入錯誤")


                End If
        End Select
        ''
        Select Case ComboBox2.SelectedIndex '若是2/30以下則秀出Form2
            Case 1
                If ComboBox3.SelectedIndex <= 28 Then
                    If ComboBox3.SelectedIndex < -1 Then
                        You = ""
                    End If
                    Form2.Show()
                End If
        End Select

        Select Case ComboBox2.SelectedIndex '若非小月的31日則秀出Form2
            Case 3, 5, 8, 10
                If ComboBox3.SelectedIndex <= 29 Then

                    Form2.Show()
                End If
        End Select
        Select Case ComboBox2.SelectedIndex '若是大月則秀出Form2
            Case 0, 2, 4, 6, 7, 9, 11
                If ComboBox3.SelectedIndex <= 30 Then

                    Form2.Show()
                End If
        End Select

        If ComboBox3.SelectedIndex = -1 Then '判斷有無輸入日期
            day = ""
            You = ""
            Form2.Hide()
            MsgBox("輸入日期")
        End If
        If ComboBox2.SelectedIndex = -1 Then
            MsgBox("輸入月份")
        End If
        If ComboBox3.SelectedIndex = -1 Then
            day = ""
            You = ""
            Form2.Close()
        End If
    End Sub
End Class


