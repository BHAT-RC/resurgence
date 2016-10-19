Public Class HLP
    'Code for starting session.
    Private Sub beginningInstructions_Click(sender As Object, e As EventArgs) Handles phase1Alt4Light.Click
        phase1Alt4Light.Visible = False
        r1VI.Enabled = True
        SessionTime.Enabled = True
    End Sub

    'Code for target response. 
    Private Sub r0101_Click(sender As Object, e As EventArgs) Handles r0101.Click
        r0101.Visible = False
        r0102.Visible = True
        r0201.Visible = True
        r0202.Visible = False
        r0203.Visible = False
        r0204.Visible = False
        r0205.Visible = False
        r0206.Visible = False
        r0301.Visible = True
        r0302.Visible = False
        r0303.Visible = False
        r0304.Visible = False
        r0305.Visible = False
        r0306.Visible = False
        r0401.Visible = True
        r0402.Visible = False
        r0403.Visible = False
        r0404.Visible = False
        r0405.Visible = False
        r0406.Visible = False
        r0501.Visible = True
        r0502.Visible = False
        r0503.Visible = False
        r0504.Visible = False
        r0505.Visible = False
        r0506.Visible = False
        r0601.Visible = True
        r0602.Visible = False
        r0603.Visible = False
        r0604.Visible = False
        r0605.Visible = False
        r0606.Visible = False
    End Sub
    Private Sub r0102_Click(sender As Object, e As EventArgs) Handles r0102.Click
        r0102.Visible = False
        r0103.Visible = True
    End Sub
    Private Sub r0103_Click(sender As Object, e As EventArgs) Handles r0103.Click
        r0103.Visible = False
        r0104.Visible = True
    End Sub
    Private Sub r0104_Click(sender As Object, e As EventArgs) Handles r0104.Click
        r0104.Visible = False
        r0105.Visible = True
    End Sub
    Private Sub r0105_Click(sender As Object, e As EventArgs) Handles r0105.Click
        r0105.Visible = False
        r0106.Visible = True
    End Sub
    Private Sub r0106_Click(sender As Object, e As EventArgs) Handles r0106.Click
        r0106.Visible = False
        r0101.Visible = True
        'Code for changeover (CO) response. That is, the first response following switching cannot contact reinforcement. 
        If r1CO.Text < 2 Then
            r1CO.Text = Val(r1CO.Text) + 1
            r2CO.Text = 0
            r3CO.Text = 0
            r4CO.Text = 0
            r5CO.Text = 0
            r6CO.Text = 0
        End If
        If r1CO.Text = 2 Then
            If r1VIval.Text = 0 Then
                pointText.Visible = True
                consumResp.Visible = True
                TargetTimeDeliver.Text = TargetTimeDeliver.Text + TimeLeft.Text + ","
            End If
        End If
        'Code for count per 2-min session. 
        If TimeLeft.Text > 0 Then
            If TimeLeft.Text <= 120 Then
                r1sess1.Text = r1sess1.Text + 1
            End If
        End If
        If TimeLeft.Text > 120 Then
            If TimeLeft.Text <= 240 Then
                r1sess2.Text = r1sess2.Text + 1
            End If
        End If
        If TimeLeft.Text > 240 Then
            If TimeLeft.Text <= 360 Then
                r1sess3.Text = r1sess3.Text + 1
            End If
        End If
        If TimeLeft.Text > 360 Then
            If TimeLeft.Text <= 480 Then
                r1sess4.Text = r1sess4.Text + 1
            End If
        End If
        If TimeLeft.Text > 480 Then
            If TimeLeft.Text <= 600 Then
                r1sess5.Text = r1sess5.Text + 1
            End If
        End If
        If TimeLeft.Text > 600 Then
            If TimeLeft.Text <= 720 Then
                r1sess6.Text = r1sess6.Text + 1
            End If
        End If
        If TimeLeft.Text > 720 Then
            If TimeLeft.Text <= 840 Then
                r1sess7.Text = r1sess7.Text + 1
            End If
        End If
        If TimeLeft.Text > 840 Then
            If TimeLeft.Text <= 960 Then
                r1sess8.Text = r1sess8.Text + 1
            End If
        End If
        If TimeLeft.Text > 960 Then
            If TimeLeft.Text <= 1080 Then
                r1sess9.Text = r1sess9.Text + 1
            End If
        End If
        If TimeLeft.Text > 1080 Then
            If TimeLeft.Text <= 1200 Then
                r1sess10.Text = r1sess10.Text + 1
            End If
        End If
        If TimeLeft.Text > 1200 Then
            If TimeLeft.Text <= 1320 Then
                r1sess11.Text = r1sess11.Text + 1
            End If
        End If
        If TimeLeft.Text > 1320 Then
            If TimeLeft.Text <= 1440 Then
                r1sess12.Text = r1sess12.Text + 1
            End If
        End If
        If TimeLeft.Text > 1440 Then
            If TimeLeft.Text <= 1560 Then
                r1sess13.Text = r1sess13.Text + 1
            End If
        End If
        If TimeLeft.Text > 1560 Then
            If TimeLeft.Text <= 1680 Then
                r1sess14.Text = r1sess14.Text + 1
            End If
        End If
        If TimeLeft.Text > 1680 Then
            If TimeLeft.Text <= 1800 Then
                r1sess15.Text = r1sess15.Text + 1
            End If
        End If
        If TimeLeft.Text > 1800 Then
            If TimeLeft.Text <= 1920 Then
                r1sess16.Text = r1sess16.Text + 1
            End If
        End If
        If TimeLeft.Text > 1920 Then
            If TimeLeft.Text <= 2040 Then
                r1sess17.Text = r1sess17.Text + 1
            End If
        End If
        If TimeLeft.Text > 2040 Then
            If TimeLeft.Text <= 2160 Then
                r1sess18.Text = r1sess18.Text + 1
            End If
        End If
        If TimeLeft.Text > 2160 Then
            If TimeLeft.Text <= 2280 Then
                r1sess19.Text = r1sess19.Text + 1
            End If
        End If
        If TimeLeft.Text > 2280 Then
            If TimeLeft.Text <= 2400 Then
                r1sess20.Text = r1sess20.Text + 1
            End If
        End If
        If TimeLeft.Text > 2400 Then
            If TimeLeft.Text <= 2520 Then
                r1sess21.Text = r1sess21.Text + 1
            End If
        End If
        If TimeLeft.Text > 2520 Then
            If TimeLeft.Text <= 2640 Then
                r1sess22.Text = r1sess22.Text + 1
            End If
        End If
        If TimeLeft.Text > 2640 Then
            If TimeLeft.Text <= 2760 Then
                r1sess23.Text = r1sess23.Text + 1
            End If
        End If
        If TimeLeft.Text > 2760 Then
            If TimeLeft.Text <= 2880 Then
                r1sess24.Text = r1sess24.Text + 1
            End If
        End If


        'Code for count per 10-sec interval.
        If TimeLeft.Text > 0 Then
            If TimeLeft.Text <= 10 Then
                r1i01.Text = r1i01.Text + 1
            End If
        End If
        If TimeLeft.Text > 10 Then
            If TimeLeft.Text <= 20 Then
                r1i02.Text = r1i02.Text + 1
            End If
        End If
        If TimeLeft.Text > 20 Then
            If TimeLeft.Text <= 30 Then
                r1i03.Text = r1i03.Text + 1
            End If
        End If
        If TimeLeft.Text > 30 Then
            If TimeLeft.Text <= 40 Then
                r1i04.Text = r1i04.Text + 1
            End If
        End If
        If TimeLeft.Text > 40 Then
            If TimeLeft.Text <= 50 Then
                r1i05.Text = r1i05.Text + 1
            End If
        End If
        If TimeLeft.Text > 50 Then
            If TimeLeft.Text <= 60 Then
                r1i06.Text = r1i06.Text + 1
            End If
        End If
        If TimeLeft.Text > 60 Then
            If TimeLeft.Text <= 70 Then
                r1i07.Text = r1i07.Text + 1
            End If
        End If
        If TimeLeft.Text > 70 Then
            If TimeLeft.Text <= 80 Then
                r1i08.Text = r1i08.Text + 1
            End If
        End If
        If TimeLeft.Text > 80 Then
            If TimeLeft.Text <= 90 Then
                r1i09.Text = r1i09.Text + 1
            End If
        End If
        If TimeLeft.Text > 90 Then
            If TimeLeft.Text <= 100 Then
                r1i10.Text = r1i10.Text + 1
            End If
        End If
        If TimeLeft.Text > 100 Then
            If TimeLeft.Text <= 110 Then
                r1i11.Text = r1i11.Text + 1
            End If
        End If
        If TimeLeft.Text > 110 Then
            If TimeLeft.Text <= 120 Then
                r1i12.Text = r1i12.Text + 1
            End If
        End If
        If TimeLeft.Text > 120 Then
            If TimeLeft.Text <= 130 Then
                r1i13.Text = r1i13.Text + 1
            End If
        End If
        If TimeLeft.Text > 130 Then
            If TimeLeft.Text <= 140 Then
                r1i14.Text = r1i14.Text + 1
            End If
        End If
        If TimeLeft.Text > 140 Then
            If TimeLeft.Text <= 150 Then
                r1i15.Text = r1i15.Text + 1
            End If
        End If
        If TimeLeft.Text > 150 Then
            If TimeLeft.Text <= 160 Then
                r1i16.Text = r1i16.Text + 1
            End If
        End If
        If TimeLeft.Text > 160 Then
            If TimeLeft.Text <= 170 Then
                r1i17.Text = r1i17.Text + 1
            End If
        End If
        If TimeLeft.Text > 170 Then
            If TimeLeft.Text <= 180 Then
                r1i18.Text = r1i18.Text + 1
            End If
        End If
        If TimeLeft.Text > 180 Then
            If TimeLeft.Text <= 190 Then
                r1i19.Text = r1i19.Text + 1
            End If
        End If
        If TimeLeft.Text > 190 Then
            If TimeLeft.Text <= 200 Then
                r1i20.Text = r1i20.Text + 1
            End If
        End If
        If TimeLeft.Text > 200 Then
            If TimeLeft.Text <= 210 Then
                r1i21.Text = r1i21.Text + 1
            End If
        End If
        If TimeLeft.Text > 210 Then
            If TimeLeft.Text <= 220 Then
                r1i22.Text = r1i22.Text + 1
            End If
        End If
        If TimeLeft.Text > 220 Then
            If TimeLeft.Text <= 230 Then
                r1i23.Text = r1i23.Text + 1
            End If
        End If
        If TimeLeft.Text > 230 Then
            If TimeLeft.Text <= 240 Then
                r1i24.Text = r1i24.Text + 1
            End If
        End If
        If TimeLeft.Text > 240 Then
            If TimeLeft.Text <= 250 Then
                r1i25.Text = r1i25.Text + 1
            End If
        End If
        If TimeLeft.Text > 250 Then
            If TimeLeft.Text <= 260 Then
                r1i26.Text = r1i26.Text + 1
            End If
        End If
        If TimeLeft.Text > 260 Then
            If TimeLeft.Text <= 270 Then
                r1i27.Text = r1i27.Text + 1
            End If
        End If
        If TimeLeft.Text > 270 Then
            If TimeLeft.Text <= 280 Then
                r1i28.Text = r1i28.Text + 1
            End If
        End If
        If TimeLeft.Text > 280 Then
            If TimeLeft.Text <= 290 Then
                r1i29.Text = r1i29.Text + 1
            End If
        End If
        If TimeLeft.Text > 290 Then
            If TimeLeft.Text <= 300 Then
                r1i30.Text = r1i30.Text + 1
            End If
        End If
        If TimeLeft.Text > 300 Then
            If TimeLeft.Text <= 310 Then
                r1i31.Text = r1i31.Text + 1
            End If
        End If
        If TimeLeft.Text > 310 Then
            If TimeLeft.Text <= 320 Then
                r1i32.Text = r1i32.Text + 1
            End If
        End If
        If TimeLeft.Text > 320 Then
            If TimeLeft.Text <= 330 Then
                r1i33.Text = r1i33.Text + 1
            End If
        End If
        If TimeLeft.Text > 330 Then
            If TimeLeft.Text <= 340 Then
                r1i34.Text = r1i34.Text + 1
            End If
        End If
        If TimeLeft.Text > 340 Then
            If TimeLeft.Text <= 350 Then
                r1i35.Text = r1i35.Text + 1
            End If
        End If
        If TimeLeft.Text > 350 Then
            If TimeLeft.Text <= 360 Then
                r1i36.Text = r1i36.Text + 1
            End If
        End If
        If TimeLeft.Text > 360 Then
            If TimeLeft.Text <= 370 Then
                r1i37.Text = r1i37.Text + 1
            End If
        End If
        If TimeLeft.Text > 370 Then
            If TimeLeft.Text <= 380 Then
                r1i38.Text = r1i38.Text + 1
            End If
        End If
        If TimeLeft.Text > 380 Then
            If TimeLeft.Text <= 390 Then
                r1i39.Text = r1i39.Text + 1
            End If
        End If
        If TimeLeft.Text > 390 Then
            If TimeLeft.Text <= 400 Then
                r1i40.Text = r1i40.Text + 1
            End If
        End If
        If TimeLeft.Text > 400 Then
            If TimeLeft.Text <= 410 Then
                r1i41.Text = r1i41.Text + 1
            End If
        End If
        If TimeLeft.Text > 410 Then
            If TimeLeft.Text <= 420 Then
                r1i42.Text = r1i42.Text + 1
            End If
        End If
        If TimeLeft.Text > 420 Then
            If TimeLeft.Text <= 430 Then
                r1i43.Text = r1i43.Text + 1
            End If
        End If
        If TimeLeft.Text > 430 Then
            If TimeLeft.Text <= 440 Then
                r1i44.Text = r1i44.Text + 1
            End If
        End If
        If TimeLeft.Text > 440 Then
            If TimeLeft.Text <= 450 Then
                r1i45.Text = r1i45.Text + 1
            End If
        End If
        If TimeLeft.Text > 450 Then
            If TimeLeft.Text <= 460 Then
                r1i46.Text = r1i46.Text + 1
            End If
        End If
        If TimeLeft.Text > 460 Then
            If TimeLeft.Text <= 470 Then
                r1i47.Text = r1i47.Text + 1
            End If
        End If
        If TimeLeft.Text > 470 Then
            If TimeLeft.Text <= 480 Then
                r1i48.Text = r1i48.Text + 1
            End If
        End If
        If TimeLeft.Text > 480 Then
            If TimeLeft.Text <= 490 Then
                r1i49.Text = r1i49.Text + 1
            End If
        End If
        If TimeLeft.Text > 490 Then
            If TimeLeft.Text <= 500 Then
                r1i50.Text = r1i50.Text + 1
            End If
        End If
        If TimeLeft.Text > 500 Then
            If TimeLeft.Text <= 510 Then
                r1i51.Text = r1i51.Text + 1
            End If
        End If
        If TimeLeft.Text > 510 Then
            If TimeLeft.Text <= 520 Then
                r1i52.Text = r1i52.Text + 1
            End If
        End If
        If TimeLeft.Text > 520 Then
            If TimeLeft.Text <= 530 Then
                r1i53.Text = r1i53.Text + 1
            End If
        End If
        If TimeLeft.Text > 530 Then
            If TimeLeft.Text <= 540 Then
                r1i54.Text = r1i54.Text + 1
            End If
        End If
        If TimeLeft.Text > 540 Then
            If TimeLeft.Text <= 550 Then
                r1i55.Text = r1i55.Text + 1
            End If
        End If
        If TimeLeft.Text > 550 Then
            If TimeLeft.Text <= 560 Then
                r1i56.Text = r1i56.Text + 1
            End If
        End If
        If TimeLeft.Text > 560 Then
            If TimeLeft.Text <= 570 Then
                r1i57.Text = r1i57.Text + 1
            End If
        End If
        If TimeLeft.Text > 570 Then
            If TimeLeft.Text <= 580 Then
                r1i58.Text = r1i58.Text + 1
            End If
        End If
        If TimeLeft.Text > 580 Then
            If TimeLeft.Text <= 590 Then
                r1i59.Text = r1i59.Text + 1
            End If
        End If
        If TimeLeft.Text > 590 Then
            If TimeLeft.Text <= 600 Then
                r1i60.Text = r1i60.Text + 1
            End If
        End If
        If TimeLeft.Text > 600 Then
            If TimeLeft.Text <= 610 Then
                r1i61.Text = r1i61.Text + 1
            End If
        End If
        If TimeLeft.Text > 610 Then
            If TimeLeft.Text <= 620 Then
                r1i62.Text = r1i62.Text + 1
            End If
        End If
        If TimeLeft.Text > 620 Then
            If TimeLeft.Text <= 630 Then
                r1i63.Text = r1i63.Text + 1
            End If
        End If
        If TimeLeft.Text > 630 Then
            If TimeLeft.Text <= 640 Then
                r1i64.Text = r1i64.Text + 1
            End If
        End If
        If TimeLeft.Text > 640 Then
            If TimeLeft.Text <= 650 Then
                r1i65.Text = r1i65.Text + 1
            End If
        End If
        If TimeLeft.Text > 650 Then
            If TimeLeft.Text <= 660 Then
                r1i66.Text = r1i66.Text + 1
            End If
        End If
        If TimeLeft.Text > 660 Then
            If TimeLeft.Text <= 670 Then
                r1i67.Text = r1i67.Text + 1
            End If
        End If
        If TimeLeft.Text > 670 Then
            If TimeLeft.Text <= 680 Then
                r1i68.Text = r1i68.Text + 1
            End If
        End If
        If TimeLeft.Text > 680 Then
            If TimeLeft.Text <= 690 Then
                r1i69.Text = r1i69.Text + 1
            End If
        End If
        If TimeLeft.Text > 690 Then
            If TimeLeft.Text <= 700 Then
                r1i70.Text = r1i70.Text + 1
            End If
        End If
        If TimeLeft.Text > 700 Then
            If TimeLeft.Text <= 710 Then
                r1i71.Text = r1i71.Text + 1
            End If
        End If
        If TimeLeft.Text > 710 Then
            If TimeLeft.Text <= 720 Then
                r1i72.Text = r1i72.Text + 1
            End If
        End If
        If TimeLeft.Text > 720 Then
            If TimeLeft.Text <= 730 Then
                r1i73.Text = r1i73.Text + 1
            End If
        End If
        If TimeLeft.Text > 730 Then
            If TimeLeft.Text <= 740 Then
                r1i74.Text = r1i74.Text + 1
            End If
        End If
        If TimeLeft.Text > 740 Then
            If TimeLeft.Text <= 750 Then
                r1i75.Text = r1i75.Text + 1
            End If
        End If
        If TimeLeft.Text > 750 Then
            If TimeLeft.Text <= 760 Then
                r1i76.Text = r1i76.Text + 1
            End If
        End If
        If TimeLeft.Text > 760 Then
            If TimeLeft.Text <= 770 Then
                r1i77.Text = r1i77.Text + 1
            End If
        End If
        If TimeLeft.Text > 770 Then
            If TimeLeft.Text <= 780 Then
                r1i78.Text = r1i78.Text + 1
            End If
        End If
        If TimeLeft.Text > 780 Then
            If TimeLeft.Text <= 790 Then
                r1i79.Text = r1i79.Text + 1
            End If
        End If
        If TimeLeft.Text > 790 Then
            If TimeLeft.Text <= 800 Then
                r1i80.Text = r1i80.Text + 1
            End If
        End If
        If TimeLeft.Text > 800 Then
            If TimeLeft.Text <= 810 Then
                r1i81.Text = r1i81.Text + 1
            End If
        End If
        If TimeLeft.Text > 810 Then
            If TimeLeft.Text <= 820 Then
                r1i82.Text = r1i82.Text + 1
            End If
        End If
        If TimeLeft.Text > 820 Then
            If TimeLeft.Text <= 830 Then
                r1i83.Text = r1i83.Text + 1
            End If
        End If
        If TimeLeft.Text > 830 Then
            If TimeLeft.Text <= 840 Then
                r1i84.Text = r1i84.Text + 1
            End If
        End If
        If TimeLeft.Text > 840 Then
            If TimeLeft.Text <= 850 Then
                r1i85.Text = r1i85.Text + 1
            End If
        End If
        If TimeLeft.Text > 850 Then
            If TimeLeft.Text <= 860 Then
                r1i86.Text = r1i86.Text + 1
            End If
        End If
        If TimeLeft.Text > 860 Then
            If TimeLeft.Text <= 870 Then
                r1i87.Text = r1i87.Text + 1
            End If
        End If
        If TimeLeft.Text > 870 Then
            If TimeLeft.Text <= 880 Then
                r1i88.Text = r1i88.Text + 1
            End If
        End If
        If TimeLeft.Text > 880 Then
            If TimeLeft.Text <= 890 Then
                r1i89.Text = r1i89.Text + 1
            End If
        End If
        If TimeLeft.Text > 890 Then
            If TimeLeft.Text <= 900 Then
                r1i90.Text = r1i90.Text + 1
            End If
        End If
        If TimeLeft.Text > 900 Then
            If TimeLeft.Text <= 910 Then
                r1i91.Text = r1i91.Text + 1
            End If
        End If
        If TimeLeft.Text > 910 Then
            If TimeLeft.Text <= 920 Then
                r1i92.Text = r1i92.Text + 1
            End If
        End If
        If TimeLeft.Text > 920 Then
            If TimeLeft.Text <= 930 Then
                r1i93.Text = r1i93.Text + 1
            End If
        End If
        If TimeLeft.Text > 930 Then
            If TimeLeft.Text <= 940 Then
                r1i94.Text = r1i94.Text + 1
            End If
        End If
        If TimeLeft.Text > 940 Then
            If TimeLeft.Text <= 950 Then
                r1i95.Text = r1i95.Text + 1
            End If
        End If
        If TimeLeft.Text > 950 Then
            If TimeLeft.Text <= 960 Then
                r1i96.Text = r1i96.Text + 1
            End If
        End If
        If TimeLeft.Text > 960 Then
            If TimeLeft.Text <= 970 Then
                r1i97.Text = r1i97.Text + 1
            End If
        End If
        If TimeLeft.Text > 970 Then
            If TimeLeft.Text <= 980 Then
                r1i98.Text = r1i98.Text + 1
            End If
        End If
        If TimeLeft.Text > 980 Then
            If TimeLeft.Text <= 990 Then
                r1i99.Text = r1i99.Text + 1
            End If
        End If
        If TimeLeft.Text > 990 Then
            If TimeLeft.Text <= 1000 Then
                r1i100.Text = r1i100.Text + 1
            End If
        End If
        If TimeLeft.Text > 1000 Then
            If TimeLeft.Text <= 1010 Then
                r1i101.Text = r1i101.Text + 1
            End If
        End If
        If TimeLeft.Text > 1010 Then
            If TimeLeft.Text <= 1020 Then
                r1i102.Text = r1i102.Text + 1
            End If
        End If
        If TimeLeft.Text > 1020 Then
            If TimeLeft.Text <= 1030 Then
                r1i103.Text = r1i103.Text + 1
            End If
        End If
        If TimeLeft.Text > 1030 Then
            If TimeLeft.Text <= 1040 Then
                r1i104.Text = r1i104.Text + 1
            End If
        End If
        If TimeLeft.Text > 1040 Then
            If TimeLeft.Text <= 1050 Then
                r1i105.Text = r1i105.Text + 1
            End If
        End If
        If TimeLeft.Text > 1050 Then
            If TimeLeft.Text <= 1060 Then
                r1i106.Text = r1i106.Text + 1
            End If
        End If
        If TimeLeft.Text > 1060 Then
            If TimeLeft.Text <= 1070 Then
                r1i107.Text = r1i107.Text + 1
            End If
        End If
        If TimeLeft.Text > 1070 Then
            If TimeLeft.Text <= 1080 Then
                r1i108.Text = r1i108.Text + 1
            End If
        End If
        If TimeLeft.Text > 1080 Then
            If TimeLeft.Text <= 1090 Then
                r1i109.Text = r1i109.Text + 1
            End If
        End If
        If TimeLeft.Text > 1090 Then
            If TimeLeft.Text <= 1100 Then
                r1i110.Text = r1i110.Text + 1
            End If
        End If
        If TimeLeft.Text > 1100 Then
            If TimeLeft.Text <= 1110 Then
                r1i111.Text = r1i111.Text + 1
            End If
        End If
        If TimeLeft.Text > 1110 Then
            If TimeLeft.Text <= 1120 Then
                r1i112.Text = r1i112.Text + 1
            End If
        End If
        If TimeLeft.Text > 1120 Then
            If TimeLeft.Text <= 1130 Then
                r1i113.Text = r1i113.Text + 1
            End If
        End If
        If TimeLeft.Text > 1130 Then
            If TimeLeft.Text <= 1140 Then
                r1i114.Text = r1i114.Text + 1
            End If
        End If
        If TimeLeft.Text > 1140 Then
            If TimeLeft.Text <= 1150 Then
                r1i115.Text = r1i115.Text + 1
            End If
        End If
        If TimeLeft.Text > 1150 Then
            If TimeLeft.Text <= 1160 Then
                r1i116.Text = r1i116.Text + 1
            End If
        End If
        If TimeLeft.Text > 1160 Then
            If TimeLeft.Text <= 1170 Then
                r1i117.Text = r1i117.Text + 1
            End If
        End If
        If TimeLeft.Text > 1170 Then
            If TimeLeft.Text <= 1180 Then
                r1i118.Text = r1i118.Text + 1
            End If
        End If
        If TimeLeft.Text > 1180 Then
            If TimeLeft.Text <= 1190 Then
                r1i119.Text = r1i119.Text + 1
            End If
        End If
        If TimeLeft.Text > 1190 Then
            If TimeLeft.Text <= 1200 Then
                r1i120.Text = r1i120.Text + 1
            End If
        End If
        If TimeLeft.Text > 1200 Then
            If TimeLeft.Text <= 1210 Then
                r1i121.Text = r1i121.Text + 1
            End If
        End If
        If TimeLeft.Text > 1210 Then
            If TimeLeft.Text <= 1220 Then
                r1i122.Text = r1i122.Text + 1
            End If
        End If
        If TimeLeft.Text > 1220 Then
            If TimeLeft.Text <= 1230 Then
                r1i123.Text = r1i123.Text + 1
            End If
        End If
        If TimeLeft.Text > 1230 Then
            If TimeLeft.Text <= 1240 Then
                r1i124.Text = r1i124.Text + 1
            End If
        End If
        If TimeLeft.Text > 1240 Then
            If TimeLeft.Text <= 1250 Then
                r1i125.Text = r1i125.Text + 1
            End If
        End If
        If TimeLeft.Text > 1250 Then
            If TimeLeft.Text <= 1260 Then
                r1i126.Text = r1i126.Text + 1
            End If
        End If
        If TimeLeft.Text > 1260 Then
            If TimeLeft.Text <= 1270 Then
                r1i127.Text = r1i127.Text + 1
            End If
        End If
        If TimeLeft.Text > 1270 Then
            If TimeLeft.Text <= 1280 Then
                r1i128.Text = r1i128.Text + 1
            End If
        End If
        If TimeLeft.Text > 1280 Then
            If TimeLeft.Text <= 1290 Then
                r1i129.Text = r1i129.Text + 1
            End If
        End If
        If TimeLeft.Text > 1290 Then
            If TimeLeft.Text <= 1300 Then
                r1i130.Text = r1i130.Text + 1
            End If
        End If
        If TimeLeft.Text > 1300 Then
            If TimeLeft.Text <= 1310 Then
                r1i131.Text = r1i131.Text + 1
            End If
        End If
        If TimeLeft.Text > 1310 Then
            If TimeLeft.Text <= 1320 Then
                r1i132.Text = r1i132.Text + 1
            End If
        End If
        If TimeLeft.Text > 1320 Then
            If TimeLeft.Text <= 1330 Then
                r1i133.Text = r1i133.Text + 1
            End If
        End If
        If TimeLeft.Text > 1330 Then
            If TimeLeft.Text <= 1340 Then
                r1i134.Text = r1i134.Text + 1
            End If
        End If
        If TimeLeft.Text > 1340 Then
            If TimeLeft.Text <= 1350 Then
                r1i135.Text = r1i135.Text + 1
            End If
        End If
        If TimeLeft.Text > 1350 Then
            If TimeLeft.Text <= 1360 Then
                r1i136.Text = r1i136.Text + 1
            End If
        End If
        If TimeLeft.Text > 1360 Then
            If TimeLeft.Text <= 1370 Then
                r1i137.Text = r1i137.Text + 1
            End If
        End If
        If TimeLeft.Text > 1370 Then
            If TimeLeft.Text <= 1380 Then
                r1i138.Text = r1i138.Text + 1
            End If
        End If
        If TimeLeft.Text > 1380 Then
            If TimeLeft.Text <= 1390 Then
                r1i139.Text = r1i139.Text + 1
            End If
        End If
        If TimeLeft.Text > 1390 Then
            If TimeLeft.Text <= 1400 Then
                r1i140.Text = r1i140.Text + 1
            End If
        End If
        If TimeLeft.Text > 1400 Then
            If TimeLeft.Text <= 1410 Then
                r1i141.Text = r1i141.Text + 1
            End If
        End If
        If TimeLeft.Text > 1410 Then
            If TimeLeft.Text <= 1420 Then
                r1i142.Text = r1i142.Text + 1
            End If
        End If
        If TimeLeft.Text > 1420 Then
            If TimeLeft.Text <= 1430 Then
                r1i143.Text = r1i143.Text + 1
            End If
        End If
        If TimeLeft.Text > 1430 Then
            If TimeLeft.Text <= 1440 Then
                r1i144.Text = r1i144.Text + 1
            End If
        End If
        If TimeLeft.Text > 1440 Then
            If TimeLeft.Text <= 1450 Then
                r1i145.Text = r1i145.Text + 1
            End If
        End If
        If TimeLeft.Text > 1450 Then
            If TimeLeft.Text <= 1460 Then
                r1i146.Text = r1i146.Text + 1
            End If
        End If
        If TimeLeft.Text > 1460 Then
            If TimeLeft.Text <= 1470 Then
                r1i147.Text = r1i147.Text + 1
            End If
        End If
        If TimeLeft.Text > 1470 Then
            If TimeLeft.Text <= 1480 Then
                r1i148.Text = r1i148.Text + 1
            End If
        End If
        If TimeLeft.Text > 1480 Then
            If TimeLeft.Text <= 1490 Then
                r1i149.Text = r1i149.Text + 1
            End If
        End If
        If TimeLeft.Text > 1490 Then
            If TimeLeft.Text <= 1500 Then
                r1i150.Text = r1i150.Text + 1
            End If
        End If
        If TimeLeft.Text > 1500 Then
            If TimeLeft.Text <= 1510 Then
                r1i151.Text = r1i151.Text + 1
            End If
        End If
        If TimeLeft.Text > 1510 Then
            If TimeLeft.Text <= 1520 Then
                r1i152.Text = r1i152.Text + 1
            End If
        End If
        If TimeLeft.Text > 1520 Then
            If TimeLeft.Text <= 1530 Then
                r1i153.Text = r1i153.Text + 1
            End If
        End If
        If TimeLeft.Text > 1530 Then
            If TimeLeft.Text <= 1540 Then
                r1i154.Text = r1i154.Text + 1
            End If
        End If
        If TimeLeft.Text > 1540 Then
            If TimeLeft.Text <= 1550 Then
                r1i155.Text = r1i155.Text + 1
            End If
        End If
        If TimeLeft.Text > 1550 Then
            If TimeLeft.Text <= 1560 Then
                r1i156.Text = r1i156.Text + 1
            End If
        End If
        If TimeLeft.Text > 1560 Then
            If TimeLeft.Text <= 1570 Then
                r1i157.Text = r1i157.Text + 1
            End If
        End If
        If TimeLeft.Text > 1570 Then
            If TimeLeft.Text <= 1580 Then
                r1i158.Text = r1i158.Text + 1
            End If
        End If
        If TimeLeft.Text > 1580 Then
            If TimeLeft.Text <= 1590 Then
                r1i159.Text = r1i159.Text + 1
            End If
        End If
        If TimeLeft.Text > 1590 Then
            If TimeLeft.Text <= 1600 Then
                r1i160.Text = r1i160.Text + 1
            End If
        End If
        If TimeLeft.Text > 1600 Then
            If TimeLeft.Text <= 1610 Then
                r1i161.Text = r1i161.Text + 1
            End If
        End If
        If TimeLeft.Text > 1610 Then
            If TimeLeft.Text <= 1620 Then
                r1i162.Text = r1i162.Text + 1
            End If
        End If
        If TimeLeft.Text > 1620 Then
            If TimeLeft.Text <= 1630 Then
                r1i163.Text = r1i163.Text + 1
            End If
        End If
        If TimeLeft.Text > 1630 Then
            If TimeLeft.Text <= 1640 Then
                r1i164.Text = r1i164.Text + 1
            End If
        End If
        If TimeLeft.Text > 1640 Then
            If TimeLeft.Text <= 1650 Then
                r1i165.Text = r1i165.Text + 1
            End If
        End If
        If TimeLeft.Text > 1650 Then
            If TimeLeft.Text <= 1660 Then
                r1i166.Text = r1i166.Text + 1
            End If
        End If
        If TimeLeft.Text > 1660 Then
            If TimeLeft.Text <= 1670 Then
                r1i167.Text = r1i167.Text + 1
            End If
        End If
        If TimeLeft.Text > 1670 Then
            If TimeLeft.Text <= 1680 Then
                r1i168.Text = r1i168.Text + 1
            End If
        End If
        If TimeLeft.Text > 1680 Then
            If TimeLeft.Text <= 1690 Then
                r1i169.Text = r1i169.Text + 1
            End If
        End If
        If TimeLeft.Text > 1690 Then
            If TimeLeft.Text <= 1700 Then
                r1i170.Text = r1i170.Text + 1
            End If
        End If
        If TimeLeft.Text > 1700 Then
            If TimeLeft.Text <= 1710 Then
                r1i171.Text = r1i171.Text + 1
            End If
        End If
        If TimeLeft.Text > 1710 Then
            If TimeLeft.Text <= 1720 Then
                r1i172.Text = r1i172.Text + 1
            End If
        End If
        If TimeLeft.Text > 1720 Then
            If TimeLeft.Text <= 1730 Then
                r1i173.Text = r1i173.Text + 1
            End If
        End If
        If TimeLeft.Text > 1730 Then
            If TimeLeft.Text <= 1740 Then
                r1i174.Text = r1i174.Text + 1
            End If
        End If
        If TimeLeft.Text > 1740 Then
            If TimeLeft.Text <= 1750 Then
                r1i175.Text = r1i175.Text + 1
            End If
        End If
        If TimeLeft.Text > 1750 Then
            If TimeLeft.Text <= 1760 Then
                r1i176.Text = r1i176.Text + 1
            End If
        End If
        If TimeLeft.Text > 1760 Then
            If TimeLeft.Text <= 1770 Then
                r1i177.Text = r1i177.Text + 1
            End If
        End If
        If TimeLeft.Text > 1770 Then
            If TimeLeft.Text <= 1780 Then
                r1i178.Text = r1i178.Text + 1
            End If
        End If
        If TimeLeft.Text > 1780 Then
            If TimeLeft.Text <= 1790 Then
                r1i179.Text = r1i179.Text + 1
            End If
        End If
        If TimeLeft.Text > 1790 Then
            If TimeLeft.Text <= 1800 Then
                r1i180.Text = r1i180.Text + 1
            End If
        End If
        If TimeLeft.Text > 1800 Then
            If TimeLeft.Text <= 1810 Then
                r1i181.Text = r1i181.Text + 1
            End If
        End If
        If TimeLeft.Text > 1810 Then
            If TimeLeft.Text <= 1820 Then
                r1i182.Text = r1i182.Text + 1
            End If
        End If
        If TimeLeft.Text > 1820 Then
            If TimeLeft.Text <= 1830 Then
                r1i183.Text = r1i183.Text + 1
            End If
        End If
        If TimeLeft.Text > 1830 Then
            If TimeLeft.Text <= 1840 Then
                r1i184.Text = r1i184.Text + 1
            End If
        End If
        If TimeLeft.Text > 1840 Then
            If TimeLeft.Text <= 1850 Then
                r1i185.Text = r1i185.Text + 1
            End If
        End If
        If TimeLeft.Text > 1850 Then
            If TimeLeft.Text <= 1860 Then
                r1i186.Text = r1i186.Text + 1
            End If
        End If
        If TimeLeft.Text > 1860 Then
            If TimeLeft.Text <= 1870 Then
                r1i187.Text = r1i187.Text + 1
            End If
        End If
        If TimeLeft.Text > 1870 Then
            If TimeLeft.Text <= 1880 Then
                r1i188.Text = r1i188.Text + 1
            End If
        End If
        If TimeLeft.Text > 1880 Then
            If TimeLeft.Text <= 1890 Then
                r1i189.Text = r1i189.Text + 1
            End If
        End If
        If TimeLeft.Text > 1890 Then
            If TimeLeft.Text <= 1900 Then
                r1i190.Text = r1i190.Text + 1
            End If
        End If
        If TimeLeft.Text > 1900 Then
            If TimeLeft.Text <= 1910 Then
                r1i191.Text = r1i191.Text + 1
            End If
        End If
        If TimeLeft.Text > 1910 Then
            If TimeLeft.Text <= 1920 Then
                r1i192.Text = r1i192.Text + 1
            End If
        End If
        If TimeLeft.Text > 1920 Then
            If TimeLeft.Text <= 1930 Then
                r1i193.Text = r1i193.Text + 1
            End If
        End If
        If TimeLeft.Text > 1930 Then
            If TimeLeft.Text <= 1940 Then
                r1i194.Text = r1i194.Text + 1
            End If
        End If
        If TimeLeft.Text > 1940 Then
            If TimeLeft.Text <= 1950 Then
                r1i195.Text = r1i195.Text + 1
            End If
        End If
        If TimeLeft.Text > 1950 Then
            If TimeLeft.Text <= 1960 Then
                r1i196.Text = r1i196.Text + 1
            End If
        End If
        If TimeLeft.Text > 1960 Then
            If TimeLeft.Text <= 1970 Then
                r1i197.Text = r1i197.Text + 1
            End If
        End If
        If TimeLeft.Text > 1970 Then
            If TimeLeft.Text <= 1980 Then
                r1i198.Text = r1i198.Text + 1
            End If
        End If
        If TimeLeft.Text > 1980 Then
            If TimeLeft.Text <= 1990 Then
                r1i199.Text = r1i199.Text + 1
            End If
        End If
        If TimeLeft.Text > 1990 Then
            If TimeLeft.Text <= 2000 Then
                r1i200.Text = r1i200.Text + 1
            End If
        End If
        If TimeLeft.Text > 2000 Then
            If TimeLeft.Text <= 2010 Then
                r1i201.Text = r1i201.Text + 1
            End If
        End If
        If TimeLeft.Text > 2010 Then
            If TimeLeft.Text <= 2020 Then
                r1i202.Text = r1i202.Text + 1
            End If
        End If
        If TimeLeft.Text > 2020 Then
            If TimeLeft.Text <= 2030 Then
                r1i203.Text = r1i203.Text + 1
            End If
        End If
        If TimeLeft.Text > 2030 Then
            If TimeLeft.Text <= 2040 Then
                r1i204.Text = r1i204.Text + 1
            End If
        End If
        If TimeLeft.Text > 2040 Then
            If TimeLeft.Text <= 2050 Then
                r1i205.Text = r1i205.Text + 1
            End If
        End If
        If TimeLeft.Text > 2050 Then
            If TimeLeft.Text <= 2060 Then
                r1i206.Text = r1i206.Text + 1
            End If
        End If
        If TimeLeft.Text > 2060 Then
            If TimeLeft.Text <= 2070 Then
                r1i207.Text = r1i207.Text + 1
            End If
        End If
        If TimeLeft.Text > 2070 Then
            If TimeLeft.Text <= 2080 Then
                r1i208.Text = r1i208.Text + 1
            End If
        End If
        If TimeLeft.Text > 2080 Then
            If TimeLeft.Text <= 2090 Then
                r1i209.Text = r1i209.Text + 1
            End If
        End If
        If TimeLeft.Text > 2090 Then
            If TimeLeft.Text <= 2100 Then
                r1i210.Text = r1i210.Text + 1
            End If
        End If
        If TimeLeft.Text > 2100 Then
            If TimeLeft.Text <= 2110 Then
                r1i211.Text = r1i211.Text + 1
            End If
        End If
        If TimeLeft.Text > 2110 Then
            If TimeLeft.Text <= 2120 Then
                r1i212.Text = r1i212.Text + 1
            End If
        End If
        If TimeLeft.Text > 2120 Then
            If TimeLeft.Text <= 2130 Then
                r1i213.Text = r1i213.Text + 1
            End If
        End If
        If TimeLeft.Text > 2130 Then
            If TimeLeft.Text <= 2140 Then
                r1i214.Text = r1i214.Text + 1
            End If
        End If
        If TimeLeft.Text > 2140 Then
            If TimeLeft.Text <= 2150 Then
                r1i215.Text = r1i215.Text + 1
            End If
        End If
        If TimeLeft.Text > 2150 Then
            If TimeLeft.Text <= 2160 Then
                r1i216.Text = r1i216.Text + 1
            End If
        End If
        If TimeLeft.Text > 2160 Then
            If TimeLeft.Text <= 2170 Then
                r1i217.Text = r1i217.Text + 1
            End If
        End If
        If TimeLeft.Text > 2170 Then
            If TimeLeft.Text <= 2180 Then
                r1i218.Text = r1i218.Text + 1
            End If
        End If
        If TimeLeft.Text > 2180 Then
            If TimeLeft.Text <= 2190 Then
                r1i219.Text = r1i219.Text + 1
            End If
        End If
        If TimeLeft.Text > 2190 Then
            If TimeLeft.Text <= 2200 Then
                r1i220.Text = r1i220.Text + 1
            End If
        End If
        If TimeLeft.Text > 2200 Then
            If TimeLeft.Text <= 2210 Then
                r1i221.Text = r1i221.Text + 1
            End If
        End If
        If TimeLeft.Text > 2210 Then
            If TimeLeft.Text <= 2220 Then
                r1i222.Text = r1i222.Text + 1
            End If
        End If
        If TimeLeft.Text > 2220 Then
            If TimeLeft.Text <= 2230 Then
                r1i223.Text = r1i223.Text + 1
            End If
        End If
        If TimeLeft.Text > 2230 Then
            If TimeLeft.Text <= 2240 Then
                r1i224.Text = r1i224.Text + 1
            End If
        End If
        If TimeLeft.Text > 2240 Then
            If TimeLeft.Text <= 2250 Then
                r1i225.Text = r1i225.Text + 1
            End If
        End If
        If TimeLeft.Text > 2250 Then
            If TimeLeft.Text <= 2260 Then
                r1i226.Text = r1i226.Text + 1
            End If
        End If
        If TimeLeft.Text > 2260 Then
            If TimeLeft.Text <= 2270 Then
                r1i227.Text = r1i227.Text + 1
            End If
        End If
        If TimeLeft.Text > 2270 Then
            If TimeLeft.Text <= 2280 Then
                r1i228.Text = r1i228.Text + 1
            End If
        End If
        If TimeLeft.Text > 2280 Then
            If TimeLeft.Text <= 2290 Then
                r1i229.Text = r1i229.Text + 1
            End If
        End If
        If TimeLeft.Text > 2290 Then
            If TimeLeft.Text <= 2300 Then
                r1i230.Text = r1i230.Text + 1
            End If
        End If
        If TimeLeft.Text > 2300 Then
            If TimeLeft.Text <= 2310 Then
                r1i231.Text = r1i231.Text + 1
            End If
        End If
        If TimeLeft.Text > 2310 Then
            If TimeLeft.Text <= 2320 Then
                r1i232.Text = r1i232.Text + 1
            End If
        End If
        If TimeLeft.Text > 2320 Then
            If TimeLeft.Text <= 2330 Then
                r1i233.Text = r1i233.Text + 1
            End If
        End If
        If TimeLeft.Text > 2330 Then
            If TimeLeft.Text <= 2340 Then
                r1i234.Text = r1i234.Text + 1
            End If
        End If
        If TimeLeft.Text > 2340 Then
            If TimeLeft.Text <= 2350 Then
                r1i235.Text = r1i235.Text + 1
            End If
        End If
        If TimeLeft.Text > 2350 Then
            If TimeLeft.Text <= 2360 Then
                r1i236.Text = r1i236.Text + 1
            End If
        End If
        If TimeLeft.Text > 2360 Then
            If TimeLeft.Text <= 2370 Then
                r1i237.Text = r1i237.Text + 1
            End If
        End If
        If TimeLeft.Text > 2370 Then
            If TimeLeft.Text <= 2380 Then
                r1i238.Text = r1i238.Text + 1
            End If
        End If
        If TimeLeft.Text > 2380 Then
            If TimeLeft.Text <= 2390 Then
                r1i239.Text = r1i239.Text + 1
            End If
        End If
        If TimeLeft.Text > 2390 Then
            If TimeLeft.Text <= 2400 Then
                r1i240.Text = r1i240.Text + 1
            End If
        End If
        If TimeLeft.Text > 2400 Then
            If TimeLeft.Text <= 2410 Then
                r1i241.Text = r1i241.Text + 1
            End If
        End If
        If TimeLeft.Text > 2410 Then
            If TimeLeft.Text <= 2420 Then
                r1i242.Text = r1i242.Text + 1
            End If
        End If
        If TimeLeft.Text > 2420 Then
            If TimeLeft.Text <= 2430 Then
                r1i243.Text = r1i243.Text + 1
            End If
        End If
        If TimeLeft.Text > 2430 Then
            If TimeLeft.Text <= 2440 Then
                r1i244.Text = r1i244.Text + 1
            End If
        End If
        If TimeLeft.Text > 2440 Then
            If TimeLeft.Text <= 2450 Then
                r1i245.Text = r1i245.Text + 1
            End If
        End If
        If TimeLeft.Text > 2450 Then
            If TimeLeft.Text <= 2460 Then
                r1i246.Text = r1i246.Text + 1
            End If
        End If
        If TimeLeft.Text > 2460 Then
            If TimeLeft.Text <= 2470 Then
                r1i247.Text = r1i247.Text + 1
            End If
        End If
        If TimeLeft.Text > 2470 Then
            If TimeLeft.Text <= 2480 Then
                r1i248.Text = r1i248.Text + 1
            End If
        End If
        If TimeLeft.Text > 2480 Then
            If TimeLeft.Text <= 2490 Then
                r1i249.Text = r1i249.Text + 1
            End If
        End If
        If TimeLeft.Text > 2490 Then
            If TimeLeft.Text <= 2500 Then
                r1i250.Text = r1i250.Text + 1
            End If
        End If
        If TimeLeft.Text > 2500 Then
            If TimeLeft.Text <= 2510 Then
                r1i251.Text = r1i251.Text + 1
            End If
        End If
        If TimeLeft.Text > 2510 Then
            If TimeLeft.Text <= 2520 Then
                r1i252.Text = r1i252.Text + 1
            End If
        End If
        If TimeLeft.Text > 2520 Then
            If TimeLeft.Text <= 2530 Then
                r1i253.Text = r1i253.Text + 1
            End If
        End If
        If TimeLeft.Text > 2530 Then
            If TimeLeft.Text <= 2540 Then
                r1i254.Text = r1i254.Text + 1
            End If
        End If
        If TimeLeft.Text > 2540 Then
            If TimeLeft.Text <= 2550 Then
                r1i255.Text = r1i255.Text + 1
            End If
        End If
        If TimeLeft.Text > 2550 Then
            If TimeLeft.Text <= 2560 Then
                r1i256.Text = r1i256.Text + 1
            End If
        End If
        If TimeLeft.Text > 2560 Then
            If TimeLeft.Text <= 2570 Then
                r1i257.Text = r1i257.Text + 1
            End If
        End If
        If TimeLeft.Text > 2570 Then
            If TimeLeft.Text <= 2580 Then
                r1i258.Text = r1i258.Text + 1
            End If
        End If
        If TimeLeft.Text > 2580 Then
            If TimeLeft.Text <= 2590 Then
                r1i259.Text = r1i259.Text + 1
            End If
        End If
        If TimeLeft.Text > 2590 Then
            If TimeLeft.Text <= 2600 Then
                r1i260.Text = r1i260.Text + 1
            End If
        End If
        If TimeLeft.Text > 2600 Then
            If TimeLeft.Text <= 2610 Then
                r1i261.Text = r1i261.Text + 1
            End If
        End If
        If TimeLeft.Text > 2610 Then
            If TimeLeft.Text <= 2620 Then
                r1i262.Text = r1i262.Text + 1
            End If
        End If
        If TimeLeft.Text > 2620 Then
            If TimeLeft.Text <= 2630 Then
                r1i263.Text = r1i263.Text + 1
            End If
        End If
        If TimeLeft.Text > 2630 Then
            If TimeLeft.Text <= 2640 Then
                r1i264.Text = r1i264.Text + 1
            End If
        End If
        If TimeLeft.Text > 2640 Then
            If TimeLeft.Text <= 2650 Then
                r1i265.Text = r1i265.Text + 1
            End If
        End If
        If TimeLeft.Text > 2650 Then
            If TimeLeft.Text <= 2660 Then
                r1i266.Text = r1i266.Text + 1
            End If
        End If
        If TimeLeft.Text > 2660 Then
            If TimeLeft.Text <= 2670 Then
                r1i267.Text = r1i267.Text + 1
            End If
        End If
        If TimeLeft.Text > 2670 Then
            If TimeLeft.Text <= 2680 Then
                r1i268.Text = r1i268.Text + 1
            End If
        End If
        If TimeLeft.Text > 2680 Then
            If TimeLeft.Text <= 2690 Then
                r1i269.Text = r1i269.Text + 1
            End If
        End If
        If TimeLeft.Text > 2690 Then
            If TimeLeft.Text <= 2700 Then
                r1i270.Text = r1i270.Text + 1
            End If
        End If
        If TimeLeft.Text > 2700 Then
            If TimeLeft.Text <= 2710 Then
                r1i271.Text = r1i271.Text + 1
            End If
        End If
        If TimeLeft.Text > 2710 Then
            If TimeLeft.Text <= 2720 Then
                r1i272.Text = r1i272.Text + 1
            End If
        End If
        If TimeLeft.Text > 2720 Then
            If TimeLeft.Text <= 2730 Then
                r1i273.Text = r1i273.Text + 1
            End If
        End If
        If TimeLeft.Text > 2730 Then
            If TimeLeft.Text <= 2740 Then
                r1i274.Text = r1i274.Text + 1
            End If
        End If
        If TimeLeft.Text > 2740 Then
            If TimeLeft.Text <= 2750 Then
                r1i275.Text = r1i275.Text + 1
            End If
        End If
        If TimeLeft.Text > 2750 Then
            If TimeLeft.Text <= 2760 Then
                r1i276.Text = r1i276.Text + 1
            End If
        End If
        If TimeLeft.Text > 2760 Then
            If TimeLeft.Text <= 2770 Then
                r1i277.Text = r1i277.Text + 1
            End If
        End If
        If TimeLeft.Text > 2770 Then
            If TimeLeft.Text <= 2780 Then
                r1i278.Text = r1i278.Text + 1
            End If
        End If
        If TimeLeft.Text > 2780 Then
            If TimeLeft.Text <= 2790 Then
                r1i279.Text = r1i279.Text + 1
            End If
        End If
        If TimeLeft.Text > 2790 Then
            If TimeLeft.Text <= 2800 Then
                r1i281.Text = r1i280.Text + 1
            End If
        End If
        If TimeLeft.Text > 2800 Then
            If TimeLeft.Text <= 2810 Then
                r1i281.Text = r1i281.Text + 1
            End If
        End If
        If TimeLeft.Text > 2810 Then
            If TimeLeft.Text <= 2820 Then
                r1i282.Text = r1i282.Text + 1
            End If
        End If
        If TimeLeft.Text > 2820 Then
            If TimeLeft.Text <= 2830 Then
                r1i283.Text = r1i283.Text + 1
            End If
        End If
        If TimeLeft.Text > 2830 Then
            If TimeLeft.Text <= 2840 Then
                r1i284.Text = r1i284.Text + 1
            End If
        End If
        If TimeLeft.Text > 2840 Then
            If TimeLeft.Text <= 2850 Then
                r1i285.Text = r1i285.Text + 1
            End If
        End If
        If TimeLeft.Text > 2850 Then
            If TimeLeft.Text <= 2860 Then
                r1i286.Text = r1i286.Text + 1
            End If
        End If
        If TimeLeft.Text > 2860 Then
            If TimeLeft.Text <= 2870 Then
                r1i287.Text = r1i287.Text + 1
            End If
        End If
        If TimeLeft.Text > 2870 Then
            If TimeLeft.Text <= 2880 Then
                r1i288.Text = r1i288.Text + 1
            End If
        End If
    End Sub

    'Code for alternative one response. 
    Private Sub r0201_Click(sender As Object, e As EventArgs) Handles r0201.Click
        r0201.Visible = False
        r0202.Visible = True
        r0101.Visible = True
        r0102.Visible = False
        r0103.Visible = False
        r0104.Visible = False
        r0105.Visible = False
        r0106.Visible = False
        r0301.Visible = True
        r0302.Visible = False
        r0303.Visible = False
        r0304.Visible = False
        r0305.Visible = False
        r0306.Visible = False
        r0401.Visible = True
        r0402.Visible = False
        r0403.Visible = False
        r0404.Visible = False
        r0405.Visible = False
        r0406.Visible = False
        r0501.Visible = True
        r0502.Visible = False
        r0503.Visible = False
        r0504.Visible = False
        r0505.Visible = False
        r0506.Visible = False
        r0601.Visible = True
        r0602.Visible = False
        r0603.Visible = False
        r0604.Visible = False
        r0605.Visible = False
        r0606.Visible = False
    End Sub
    Private Sub r0202_Click(sender As Object, e As EventArgs) Handles r0202.Click
        r0202.Visible = False
        r0203.Visible = True
    End Sub
    Private Sub r0203_Click(sender As Object, e As EventArgs) Handles r0203.Click
        r0203.Visible = False
        r0204.Visible = True
    End Sub
    Private Sub r0204_Click(sender As Object, e As EventArgs) Handles r0204.Click
        r0204.Visible = False
        r0205.Visible = True
    End Sub
    Private Sub r0205_Click(sender As Object, e As EventArgs) Handles r0205.Click
        r0205.Visible = False
        r0206.Visible = True
    End Sub
    Private Sub r0206_Click(sender As Object, e As EventArgs) Handles r0206.Click
        r0206.Visible = False
        r0201.Visible = True
        'Code for changeover (CO) response. That is, the first response following switching cannot contact reinforcement. 
        If r2CO.Text < 2 Then
            r2CO.Text = Val(r2CO.Text) + 1
            r1CO.Text = 0
            r3CO.Text = 0
            r4CO.Text = 0
            r5CO.Text = 0
            r6CO.Text = 0
        End If
        If r2CO.Text = 2 Then
            If r2VIval.Text = 0 Then
                pointText.Visible = True
                consumResp.Visible = True
                Alt1TimeDeliver.Text = Alt1TimeDeliver.Text + TimeLeft.Text + ","
            End If
        End If
        'Code for count per 2-min session. 
        If TimeLeft.Text > 0 Then
            If TimeLeft.Text <= 120 Then
                r2sess1.Text = r2sess1.Text + 1
            End If
        End If
        If TimeLeft.Text > 120 Then
            If TimeLeft.Text <= 240 Then
                r2sess2.Text = r2sess2.Text + 1
            End If
        End If
        If TimeLeft.Text > 240 Then
            If TimeLeft.Text <= 360 Then
                r2sess3.Text = r2sess3.Text + 1
            End If
        End If
        If TimeLeft.Text > 360 Then
            If TimeLeft.Text <= 480 Then
                r2sess4.Text = r2sess4.Text + 1
            End If
        End If
        If TimeLeft.Text > 480 Then
            If TimeLeft.Text <= 600 Then
                r2sess5.Text = r2sess5.Text + 1
            End If
        End If
        If TimeLeft.Text > 600 Then
            If TimeLeft.Text <= 720 Then
                r2sess6.Text = r2sess6.Text + 1
            End If
        End If
        If TimeLeft.Text > 720 Then
            If TimeLeft.Text <= 840 Then
                r2sess7.Text = r2sess7.Text + 1
            End If
        End If
        If TimeLeft.Text > 840 Then
            If TimeLeft.Text <= 960 Then
                r2sess8.Text = r2sess8.Text + 1
            End If
        End If
        If TimeLeft.Text > 960 Then
            If TimeLeft.Text <= 1080 Then
                r2sess9.Text = r2sess9.Text + 1
            End If
        End If
        If TimeLeft.Text > 1080 Then
            If TimeLeft.Text <= 1200 Then
                r2sess10.Text = r2sess10.Text + 1
            End If
        End If
        If TimeLeft.Text > 1200 Then
            If TimeLeft.Text <= 1320 Then
                r2sess11.Text = r2sess11.Text + 1
            End If
        End If
        If TimeLeft.Text > 1320 Then
            If TimeLeft.Text <= 1440 Then
                r2sess12.Text = r2sess12.Text + 1
            End If
        End If
        If TimeLeft.Text > 1440 Then
            If TimeLeft.Text <= 1560 Then
                r2sess13.Text = r2sess13.Text + 1
            End If
        End If
        If TimeLeft.Text > 1560 Then
            If TimeLeft.Text <= 1680 Then
                r2sess14.Text = r2sess14.Text + 1
            End If
        End If
        If TimeLeft.Text > 1680 Then
            If TimeLeft.Text <= 1800 Then
                r2sess15.Text = r2sess15.Text + 1
            End If
        End If
        If TimeLeft.Text > 1800 Then
            If TimeLeft.Text <= 1920 Then
                r2sess16.Text = r2sess16.Text + 1
            End If
        End If
        If TimeLeft.Text > 1920 Then
            If TimeLeft.Text <= 2040 Then
                r2sess17.Text = r2sess17.Text + 1
            End If
        End If
        If TimeLeft.Text > 2040 Then
            If TimeLeft.Text <= 2160 Then
                r2sess18.Text = r2sess18.Text + 1
            End If
        End If
        If TimeLeft.Text > 2160 Then
            If TimeLeft.Text <= 2280 Then
                r2sess19.Text = r2sess19.Text + 1
            End If
        End If
        If TimeLeft.Text > 2280 Then
            If TimeLeft.Text <= 2400 Then
                r2sess20.Text = r2sess20.Text + 1
            End If
        End If
        If TimeLeft.Text > 2400 Then
            If TimeLeft.Text <= 2520 Then
                r2sess21.Text = r2sess21.Text + 1
            End If
        End If
        If TimeLeft.Text > 2520 Then
            If TimeLeft.Text <= 2640 Then
                r2sess22.Text = r2sess22.Text + 1
            End If
        End If
        If TimeLeft.Text > 2640 Then
            If TimeLeft.Text <= 2760 Then
                r2sess23.Text = r2sess23.Text + 1
            End If
        End If
        If TimeLeft.Text > 2760 Then
            If TimeLeft.Text <= 2880 Then
                r2sess24.Text = r2sess24.Text + 1
            End If
        End If


        'Code for count per 10-sec interval.
        If TimeLeft.Text > 0 Then
            If TimeLeft.Text <= 10 Then
                r2i01.Text = r2i01.Text + 1
            End If
        End If
        If TimeLeft.Text > 10 Then
            If TimeLeft.Text <= 20 Then
                r2i02.Text = r2i02.Text + 1
            End If
        End If
        If TimeLeft.Text > 20 Then
            If TimeLeft.Text <= 30 Then
                r2i03.Text = r2i03.Text + 1
            End If
        End If
        If TimeLeft.Text > 30 Then
            If TimeLeft.Text <= 40 Then
                r2i04.Text = r2i04.Text + 1
            End If
        End If
        If TimeLeft.Text > 40 Then
            If TimeLeft.Text <= 50 Then
                r2i05.Text = r2i05.Text + 1
            End If
        End If
        If TimeLeft.Text > 50 Then
            If TimeLeft.Text <= 60 Then
                r2i06.Text = r2i06.Text + 1
            End If
        End If
        If TimeLeft.Text > 60 Then
            If TimeLeft.Text <= 70 Then
                r2i07.Text = r2i07.Text + 1
            End If
        End If
        If TimeLeft.Text > 70 Then
            If TimeLeft.Text <= 80 Then
                r2i08.Text = r2i08.Text + 1
            End If
        End If
        If TimeLeft.Text > 80 Then
            If TimeLeft.Text <= 90 Then
                r2i09.Text = r2i09.Text + 1
            End If
        End If
        If TimeLeft.Text > 90 Then
            If TimeLeft.Text <= 100 Then
                r2i10.Text = r2i10.Text + 1
            End If
        End If
        If TimeLeft.Text > 100 Then
            If TimeLeft.Text <= 110 Then
                r2i11.Text = r2i11.Text + 1
            End If
        End If
        If TimeLeft.Text > 110 Then
            If TimeLeft.Text <= 120 Then
                r2i12.Text = r2i12.Text + 1
            End If
        End If
        If TimeLeft.Text > 120 Then
            If TimeLeft.Text <= 130 Then
                r2i13.Text = r2i13.Text + 1
            End If
        End If
        If TimeLeft.Text > 130 Then
            If TimeLeft.Text <= 140 Then
                r2i14.Text = r2i14.Text + 1
            End If
        End If
        If TimeLeft.Text > 140 Then
            If TimeLeft.Text <= 150 Then
                r2i15.Text = r2i15.Text + 1
            End If
        End If
        If TimeLeft.Text > 150 Then
            If TimeLeft.Text <= 160 Then
                r2i16.Text = r2i16.Text + 1
            End If
        End If
        If TimeLeft.Text > 160 Then
            If TimeLeft.Text <= 170 Then
                r2i17.Text = r2i17.Text + 1
            End If
        End If
        If TimeLeft.Text > 170 Then
            If TimeLeft.Text <= 180 Then
                r2i18.Text = r2i18.Text + 1
            End If
        End If
        If TimeLeft.Text > 180 Then
            If TimeLeft.Text <= 190 Then
                r2i19.Text = r2i19.Text + 1
            End If
        End If
        If TimeLeft.Text > 190 Then
            If TimeLeft.Text <= 200 Then
                r2i20.Text = r2i20.Text + 1
            End If
        End If
        If TimeLeft.Text > 200 Then
            If TimeLeft.Text <= 210 Then
                r2i21.Text = r2i21.Text + 1
            End If
        End If
        If TimeLeft.Text > 210 Then
            If TimeLeft.Text <= 220 Then
                r2i22.Text = r2i22.Text + 1
            End If
        End If
        If TimeLeft.Text > 220 Then
            If TimeLeft.Text <= 230 Then
                r2i23.Text = r2i23.Text + 1
            End If
        End If
        If TimeLeft.Text > 230 Then
            If TimeLeft.Text <= 240 Then
                r2i24.Text = r2i24.Text + 1
            End If
        End If
        If TimeLeft.Text > 240 Then
            If TimeLeft.Text <= 250 Then
                r2i25.Text = r2i25.Text + 1
            End If
        End If
        If TimeLeft.Text > 250 Then
            If TimeLeft.Text <= 260 Then
                r2i26.Text = r2i26.Text + 1
            End If
        End If
        If TimeLeft.Text > 260 Then
            If TimeLeft.Text <= 270 Then
                r2i27.Text = r2i27.Text + 1
            End If
        End If
        If TimeLeft.Text > 270 Then
            If TimeLeft.Text <= 280 Then
                r2i28.Text = r2i28.Text + 1
            End If
        End If
        If TimeLeft.Text > 280 Then
            If TimeLeft.Text <= 290 Then
                r2i29.Text = r2i29.Text + 1
            End If
        End If
        If TimeLeft.Text > 290 Then
            If TimeLeft.Text <= 300 Then
                r2i30.Text = r2i30.Text + 1
            End If
        End If
        If TimeLeft.Text > 300 Then
            If TimeLeft.Text <= 310 Then
                r2i31.Text = r2i31.Text + 1
            End If
        End If
        If TimeLeft.Text > 310 Then
            If TimeLeft.Text <= 320 Then
                r2i32.Text = r2i32.Text + 1
            End If
        End If
        If TimeLeft.Text > 320 Then
            If TimeLeft.Text <= 330 Then
                r2i33.Text = r2i33.Text + 1
            End If
        End If
        If TimeLeft.Text > 330 Then
            If TimeLeft.Text <= 340 Then
                r2i34.Text = r2i34.Text + 1
            End If
        End If
        If TimeLeft.Text > 340 Then
            If TimeLeft.Text <= 350 Then
                r2i35.Text = r2i35.Text + 1
            End If
        End If
        If TimeLeft.Text > 350 Then
            If TimeLeft.Text <= 360 Then
                r2i36.Text = r2i36.Text + 1
            End If
        End If
        If TimeLeft.Text > 360 Then
            If TimeLeft.Text <= 370 Then
                r2i37.Text = r2i37.Text + 1
            End If
        End If
        If TimeLeft.Text > 370 Then
            If TimeLeft.Text <= 380 Then
                r2i38.Text = r2i38.Text + 1
            End If
        End If
        If TimeLeft.Text > 380 Then
            If TimeLeft.Text <= 390 Then
                r2i39.Text = r2i39.Text + 1
            End If
        End If
        If TimeLeft.Text > 390 Then
            If TimeLeft.Text <= 400 Then
                r2i40.Text = r2i40.Text + 1
            End If
        End If
        If TimeLeft.Text > 400 Then
            If TimeLeft.Text <= 410 Then
                r2i41.Text = r2i41.Text + 1
            End If
        End If
        If TimeLeft.Text > 410 Then
            If TimeLeft.Text <= 420 Then
                r2i42.Text = r2i42.Text + 1
            End If
        End If
        If TimeLeft.Text > 420 Then
            If TimeLeft.Text <= 430 Then
                r2i43.Text = r2i43.Text + 1
            End If
        End If
        If TimeLeft.Text > 430 Then
            If TimeLeft.Text <= 440 Then
                r2i44.Text = r2i44.Text + 1
            End If
        End If
        If TimeLeft.Text > 440 Then
            If TimeLeft.Text <= 450 Then
                r2i45.Text = r2i45.Text + 1
            End If
        End If
        If TimeLeft.Text > 450 Then
            If TimeLeft.Text <= 460 Then
                r2i46.Text = r2i46.Text + 1
            End If
        End If
        If TimeLeft.Text > 460 Then
            If TimeLeft.Text <= 470 Then
                r2i47.Text = r2i47.Text + 1
            End If
        End If
        If TimeLeft.Text > 470 Then
            If TimeLeft.Text <= 480 Then
                r2i48.Text = r2i48.Text + 1
            End If
        End If
        If TimeLeft.Text > 480 Then
            If TimeLeft.Text <= 490 Then
                r2i49.Text = r2i49.Text + 1
            End If
        End If
        If TimeLeft.Text > 490 Then
            If TimeLeft.Text <= 500 Then
                r2i50.Text = r2i50.Text + 1
            End If
        End If
        If TimeLeft.Text > 500 Then
            If TimeLeft.Text <= 510 Then
                r2i51.Text = r2i51.Text + 1
            End If
        End If
        If TimeLeft.Text > 510 Then
            If TimeLeft.Text <= 520 Then
                r2i52.Text = r2i52.Text + 1
            End If
        End If
        If TimeLeft.Text > 520 Then
            If TimeLeft.Text <= 530 Then
                r2i53.Text = r2i53.Text + 1
            End If
        End If
        If TimeLeft.Text > 530 Then
            If TimeLeft.Text <= 540 Then
                r2i54.Text = r2i54.Text + 1
            End If
        End If
        If TimeLeft.Text > 540 Then
            If TimeLeft.Text <= 550 Then
                r2i55.Text = r2i55.Text + 1
            End If
        End If
        If TimeLeft.Text > 550 Then
            If TimeLeft.Text <= 560 Then
                r2i56.Text = r2i56.Text + 1
            End If
        End If
        If TimeLeft.Text > 560 Then
            If TimeLeft.Text <= 570 Then
                r2i57.Text = r2i57.Text + 1
            End If
        End If
        If TimeLeft.Text > 570 Then
            If TimeLeft.Text <= 580 Then
                r2i58.Text = r2i58.Text + 1
            End If
        End If
        If TimeLeft.Text > 580 Then
            If TimeLeft.Text <= 590 Then
                r2i59.Text = r2i59.Text + 1
            End If
        End If
        If TimeLeft.Text > 590 Then
            If TimeLeft.Text <= 600 Then
                r2i60.Text = r2i60.Text + 1
            End If
        End If
        If TimeLeft.Text > 600 Then
            If TimeLeft.Text <= 610 Then
                r2i61.Text = r2i61.Text + 1
            End If
        End If
        If TimeLeft.Text > 610 Then
            If TimeLeft.Text <= 620 Then
                r2i62.Text = r2i62.Text + 1
            End If
        End If
        If TimeLeft.Text > 620 Then
            If TimeLeft.Text <= 630 Then
                r2i63.Text = r2i63.Text + 1
            End If
        End If
        If TimeLeft.Text > 630 Then
            If TimeLeft.Text <= 640 Then
                r2i64.Text = r2i64.Text + 1
            End If
        End If
        If TimeLeft.Text > 640 Then
            If TimeLeft.Text <= 650 Then
                r2i65.Text = r2i65.Text + 1
            End If
        End If
        If TimeLeft.Text > 650 Then
            If TimeLeft.Text <= 660 Then
                r2i66.Text = r2i66.Text + 1
            End If
        End If
        If TimeLeft.Text > 660 Then
            If TimeLeft.Text <= 670 Then
                r2i67.Text = r2i67.Text + 1
            End If
        End If
        If TimeLeft.Text > 670 Then
            If TimeLeft.Text <= 680 Then
                r2i68.Text = r2i68.Text + 1
            End If
        End If
        If TimeLeft.Text > 680 Then
            If TimeLeft.Text <= 690 Then
                r2i69.Text = r2i69.Text + 1
            End If
        End If
        If TimeLeft.Text > 690 Then
            If TimeLeft.Text <= 700 Then
                r2i70.Text = r2i70.Text + 1
            End If
        End If
        If TimeLeft.Text > 700 Then
            If TimeLeft.Text <= 710 Then
                r2i71.Text = r2i71.Text + 1
            End If
        End If
        If TimeLeft.Text > 710 Then
            If TimeLeft.Text <= 720 Then
                r2i72.Text = r2i72.Text + 1
            End If
        End If
        If TimeLeft.Text > 720 Then
            If TimeLeft.Text <= 730 Then
                r2i73.Text = r2i73.Text + 1
            End If
        End If
        If TimeLeft.Text > 730 Then
            If TimeLeft.Text <= 740 Then
                r2i74.Text = r2i74.Text + 1
            End If
        End If
        If TimeLeft.Text > 740 Then
            If TimeLeft.Text <= 750 Then
                r2i75.Text = r2i75.Text + 1
            End If
        End If
        If TimeLeft.Text > 750 Then
            If TimeLeft.Text <= 760 Then
                r2i76.Text = r2i76.Text + 1
            End If
        End If
        If TimeLeft.Text > 760 Then
            If TimeLeft.Text <= 770 Then
                r2i77.Text = r2i77.Text + 1
            End If
        End If
        If TimeLeft.Text > 770 Then
            If TimeLeft.Text <= 780 Then
                r2i78.Text = r2i78.Text + 1
            End If
        End If
        If TimeLeft.Text > 780 Then
            If TimeLeft.Text <= 790 Then
                r2i79.Text = r2i79.Text + 1
            End If
        End If
        If TimeLeft.Text > 790 Then
            If TimeLeft.Text <= 800 Then
                r2i80.Text = r2i80.Text + 1
            End If
        End If
        If TimeLeft.Text > 800 Then
            If TimeLeft.Text <= 810 Then
                r2i81.Text = r2i81.Text + 1
            End If
        End If
        If TimeLeft.Text > 810 Then
            If TimeLeft.Text <= 820 Then
                r2i82.Text = r2i82.Text + 1
            End If
        End If
        If TimeLeft.Text > 820 Then
            If TimeLeft.Text <= 830 Then
                r2i83.Text = r2i83.Text + 1
            End If
        End If
        If TimeLeft.Text > 830 Then
            If TimeLeft.Text <= 840 Then
                r2i84.Text = r2i84.Text + 1
            End If
        End If
        If TimeLeft.Text > 840 Then
            If TimeLeft.Text <= 850 Then
                r2i85.Text = r2i85.Text + 1
            End If
        End If
        If TimeLeft.Text > 850 Then
            If TimeLeft.Text <= 860 Then
                r2i86.Text = r2i86.Text + 1
            End If
        End If
        If TimeLeft.Text > 860 Then
            If TimeLeft.Text <= 870 Then
                r2i87.Text = r2i87.Text + 1
            End If
        End If
        If TimeLeft.Text > 870 Then
            If TimeLeft.Text <= 880 Then
                r2i88.Text = r2i88.Text + 1
            End If
        End If
        If TimeLeft.Text > 880 Then
            If TimeLeft.Text <= 890 Then
                r2i89.Text = r2i89.Text + 1
            End If
        End If
        If TimeLeft.Text > 890 Then
            If TimeLeft.Text <= 900 Then
                r2i90.Text = r2i90.Text + 1
            End If
        End If
        If TimeLeft.Text > 900 Then
            If TimeLeft.Text <= 910 Then
                r2i91.Text = r2i91.Text + 1
            End If
        End If
        If TimeLeft.Text > 910 Then
            If TimeLeft.Text <= 920 Then
                r2i92.Text = r2i92.Text + 1
            End If
        End If
        If TimeLeft.Text > 920 Then
            If TimeLeft.Text <= 930 Then
                r2i93.Text = r2i93.Text + 1
            End If
        End If
        If TimeLeft.Text > 930 Then
            If TimeLeft.Text <= 940 Then
                r2i94.Text = r2i94.Text + 1
            End If
        End If
        If TimeLeft.Text > 940 Then
            If TimeLeft.Text <= 950 Then
                r2i95.Text = r2i95.Text + 1
            End If
        End If
        If TimeLeft.Text > 950 Then
            If TimeLeft.Text <= 960 Then
                r2i96.Text = r2i96.Text + 1
            End If
        End If
        If TimeLeft.Text > 960 Then
            If TimeLeft.Text <= 970 Then
                r2i97.Text = r2i97.Text + 1
            End If
        End If
        If TimeLeft.Text > 970 Then
            If TimeLeft.Text <= 980 Then
                r2i98.Text = r2i98.Text + 1
            End If
        End If
        If TimeLeft.Text > 980 Then
            If TimeLeft.Text <= 990 Then
                r2i99.Text = r2i99.Text + 1
            End If
        End If
        If TimeLeft.Text > 990 Then
            If TimeLeft.Text <= 1000 Then
                r2i100.Text = r2i100.Text + 1
            End If
        End If
        If TimeLeft.Text > 1000 Then
            If TimeLeft.Text <= 1010 Then
                r2i101.Text = r2i101.Text + 1
            End If
        End If
        If TimeLeft.Text > 1010 Then
            If TimeLeft.Text <= 1020 Then
                r2i102.Text = r2i102.Text + 1
            End If
        End If
        If TimeLeft.Text > 1020 Then
            If TimeLeft.Text <= 1030 Then
                r2i103.Text = r2i103.Text + 1
            End If
        End If
        If TimeLeft.Text > 1030 Then
            If TimeLeft.Text <= 1040 Then
                r2i104.Text = r2i104.Text + 1
            End If
        End If
        If TimeLeft.Text > 1040 Then
            If TimeLeft.Text <= 1050 Then
                r2i105.Text = r2i105.Text + 1
            End If
        End If
        If TimeLeft.Text > 1050 Then
            If TimeLeft.Text <= 1060 Then
                r2i106.Text = r2i106.Text + 1
            End If
        End If
        If TimeLeft.Text > 1060 Then
            If TimeLeft.Text <= 1070 Then
                r2i107.Text = r2i107.Text + 1
            End If
        End If
        If TimeLeft.Text > 1070 Then
            If TimeLeft.Text <= 1080 Then
                r2i108.Text = r2i108.Text + 1
            End If
        End If
        If TimeLeft.Text > 1080 Then
            If TimeLeft.Text <= 1090 Then
                r2i109.Text = r2i109.Text + 1
            End If
        End If
        If TimeLeft.Text > 1090 Then
            If TimeLeft.Text <= 1100 Then
                r2i200.Text = r2i200.Text + 1
            End If
        End If
        If TimeLeft.Text > 1100 Then
            If TimeLeft.Text <= 1110 Then
                r2i111.Text = r2i111.Text + 1
            End If
        End If
        If TimeLeft.Text > 1110 Then
            If TimeLeft.Text <= 1120 Then
                r2i112.Text = r2i112.Text + 1
            End If
        End If
        If TimeLeft.Text > 1120 Then
            If TimeLeft.Text <= 1130 Then
                r2i113.Text = r2i113.Text + 1
            End If
        End If
        If TimeLeft.Text > 1130 Then
            If TimeLeft.Text <= 1140 Then
                r2i114.Text = r2i114.Text + 1
            End If
        End If
        If TimeLeft.Text > 1140 Then
            If TimeLeft.Text <= 1150 Then
                r2i115.Text = r2i115.Text + 1
            End If
        End If
        If TimeLeft.Text > 1150 Then
            If TimeLeft.Text <= 1160 Then
                r2i116.Text = r2i116.Text + 1
            End If
        End If
        If TimeLeft.Text > 1160 Then
            If TimeLeft.Text <= 1170 Then
                r2i117.Text = r2i117.Text + 1
            End If
        End If
        If TimeLeft.Text > 1170 Then
            If TimeLeft.Text <= 1180 Then
                r2i118.Text = r2i118.Text + 1
            End If
        End If
        If TimeLeft.Text > 1180 Then
            If TimeLeft.Text <= 1190 Then
                r2i119.Text = r2i119.Text + 1
            End If
        End If
        If TimeLeft.Text > 1190 Then
            If TimeLeft.Text <= 1200 Then
                r2i120.Text = r2i120.Text + 1
            End If
        End If
        If TimeLeft.Text > 1200 Then
            If TimeLeft.Text <= 1210 Then
                r2i121.Text = r2i121.Text + 1
            End If
        End If
        If TimeLeft.Text > 1210 Then
            If TimeLeft.Text <= 1220 Then
                r2i122.Text = r2i122.Text + 1
            End If
        End If
        If TimeLeft.Text > 1220 Then
            If TimeLeft.Text <= 1230 Then
                r2i123.Text = r2i123.Text + 1
            End If
        End If
        If TimeLeft.Text > 1230 Then
            If TimeLeft.Text <= 1240 Then
                r2i124.Text = r2i124.Text + 1
            End If
        End If
        If TimeLeft.Text > 1240 Then
            If TimeLeft.Text <= 1250 Then
                r2i125.Text = r2i125.Text + 1
            End If
        End If
        If TimeLeft.Text > 1250 Then
            If TimeLeft.Text <= 1260 Then
                r2i126.Text = r2i126.Text + 1
            End If
        End If
        If TimeLeft.Text > 1260 Then
            If TimeLeft.Text <= 1270 Then
                r2i127.Text = r2i127.Text + 1
            End If
        End If
        If TimeLeft.Text > 1270 Then
            If TimeLeft.Text <= 1280 Then
                r2i128.Text = r2i128.Text + 1
            End If
        End If
        If TimeLeft.Text > 1280 Then
            If TimeLeft.Text <= 1290 Then
                r2i129.Text = r2i129.Text + 1
            End If
        End If
        If TimeLeft.Text > 1290 Then
            If TimeLeft.Text <= 1300 Then
                r2i130.Text = r2i130.Text + 1
            End If
        End If
        If TimeLeft.Text > 1300 Then
            If TimeLeft.Text <= 1310 Then
                r2i131.Text = r2i131.Text + 1
            End If
        End If
        If TimeLeft.Text > 1310 Then
            If TimeLeft.Text <= 1320 Then
                r2i132.Text = r2i132.Text + 1
            End If
        End If
        If TimeLeft.Text > 1320 Then
            If TimeLeft.Text <= 1330 Then
                r2i133.Text = r2i133.Text + 1
            End If
        End If
        If TimeLeft.Text > 1330 Then
            If TimeLeft.Text <= 1340 Then
                r2i134.Text = r2i134.Text + 1
            End If
        End If
        If TimeLeft.Text > 1340 Then
            If TimeLeft.Text <= 1350 Then
                r2i135.Text = r2i135.Text + 1
            End If
        End If
        If TimeLeft.Text > 1350 Then
            If TimeLeft.Text <= 1360 Then
                r2i136.Text = r2i136.Text + 1
            End If
        End If
        If TimeLeft.Text > 1360 Then
            If TimeLeft.Text <= 1370 Then
                r2i137.Text = r2i137.Text + 1
            End If
        End If
        If TimeLeft.Text > 1370 Then
            If TimeLeft.Text <= 1380 Then
                r2i138.Text = r2i138.Text + 1
            End If
        End If
        If TimeLeft.Text > 1380 Then
            If TimeLeft.Text <= 1390 Then
                r2i139.Text = r2i139.Text + 1
            End If
        End If
        If TimeLeft.Text > 1390 Then
            If TimeLeft.Text <= 1400 Then
                r2i140.Text = r2i140.Text + 1
            End If
        End If
        If TimeLeft.Text > 1400 Then
            If TimeLeft.Text <= 1410 Then
                r2i141.Text = r2i141.Text + 1
            End If
        End If
        If TimeLeft.Text > 1410 Then
            If TimeLeft.Text <= 1420 Then
                r2i142.Text = r2i142.Text + 1
            End If
        End If
        If TimeLeft.Text > 1420 Then
            If TimeLeft.Text <= 1430 Then
                r2i143.Text = r2i143.Text + 1
            End If
        End If
        If TimeLeft.Text > 1430 Then
            If TimeLeft.Text <= 1440 Then
                r2i144.Text = r2i144.Text + 1
            End If
        End If
        If TimeLeft.Text > 1440 Then
            If TimeLeft.Text <= 1450 Then
                r2i145.Text = r2i145.Text + 1
            End If
        End If
        If TimeLeft.Text > 1450 Then
            If TimeLeft.Text <= 1460 Then
                r2i146.Text = r2i146.Text + 1
            End If
        End If
        If TimeLeft.Text > 1460 Then
            If TimeLeft.Text <= 1470 Then
                r2i147.Text = r2i147.Text + 1
            End If
        End If
        If TimeLeft.Text > 1470 Then
            If TimeLeft.Text <= 1480 Then
                r2i148.Text = r2i148.Text + 1
            End If
        End If
        If TimeLeft.Text > 1480 Then
            If TimeLeft.Text <= 1490 Then
                r2i149.Text = r2i149.Text + 1
            End If
        End If
        If TimeLeft.Text > 1490 Then
            If TimeLeft.Text <= 1500 Then
                r2i150.Text = r2i150.Text + 1
            End If
        End If
        If TimeLeft.Text > 1500 Then
            If TimeLeft.Text <= 1510 Then
                r2i151.Text = r2i151.Text + 1
            End If
        End If
        If TimeLeft.Text > 1510 Then
            If TimeLeft.Text <= 1520 Then
                r2i152.Text = r2i152.Text + 1
            End If
        End If
        If TimeLeft.Text > 1520 Then
            If TimeLeft.Text <= 1530 Then
                r2i153.Text = r2i153.Text + 1
            End If
        End If
        If TimeLeft.Text > 1530 Then
            If TimeLeft.Text <= 1540 Then
                r2i154.Text = r2i154.Text + 1
            End If
        End If
        If TimeLeft.Text > 1540 Then
            If TimeLeft.Text <= 1550 Then
                r2i155.Text = r2i155.Text + 1
            End If
        End If
        If TimeLeft.Text > 1550 Then
            If TimeLeft.Text <= 1560 Then
                r2i156.Text = r2i156.Text + 1
            End If
        End If
        If TimeLeft.Text > 1560 Then
            If TimeLeft.Text <= 1570 Then
                r2i157.Text = r2i157.Text + 1
            End If
        End If
        If TimeLeft.Text > 1570 Then
            If TimeLeft.Text <= 1580 Then
                r2i158.Text = r2i158.Text + 1
            End If
        End If
        If TimeLeft.Text > 1580 Then
            If TimeLeft.Text <= 1590 Then
                r2i159.Text = r2i159.Text + 1
            End If
        End If
        If TimeLeft.Text > 1590 Then
            If TimeLeft.Text <= 1600 Then
                r2i160.Text = r2i160.Text + 1
            End If
        End If
        If TimeLeft.Text > 1600 Then
            If TimeLeft.Text <= 1610 Then
                r2i161.Text = r2i161.Text + 1
            End If
        End If
        If TimeLeft.Text > 1610 Then
            If TimeLeft.Text <= 1620 Then
                r2i162.Text = r2i162.Text + 1
            End If
        End If
        If TimeLeft.Text > 1620 Then
            If TimeLeft.Text <= 1630 Then
                r2i163.Text = r2i163.Text + 1
            End If
        End If
        If TimeLeft.Text > 1630 Then
            If TimeLeft.Text <= 1640 Then
                r2i164.Text = r2i164.Text + 1
            End If
        End If
        If TimeLeft.Text > 1640 Then
            If TimeLeft.Text <= 1650 Then
                r2i165.Text = r2i165.Text + 1
            End If
        End If
        If TimeLeft.Text > 1650 Then
            If TimeLeft.Text <= 1660 Then
                r2i166.Text = r2i166.Text + 1
            End If
        End If
        If TimeLeft.Text > 1660 Then
            If TimeLeft.Text <= 1670 Then
                r2i167.Text = r2i167.Text + 1
            End If
        End If
        If TimeLeft.Text > 1670 Then
            If TimeLeft.Text <= 1680 Then
                r2i168.Text = r2i168.Text + 1
            End If
        End If
        If TimeLeft.Text > 1680 Then
            If TimeLeft.Text <= 1690 Then
                r2i169.Text = r2i169.Text + 1
            End If
        End If
        If TimeLeft.Text > 1690 Then
            If TimeLeft.Text <= 1700 Then
                r2i170.Text = r2i170.Text + 1
            End If
        End If
        If TimeLeft.Text > 1700 Then
            If TimeLeft.Text <= 1710 Then
                r2i171.Text = r2i171.Text + 1
            End If
        End If
        If TimeLeft.Text > 1710 Then
            If TimeLeft.Text <= 1720 Then
                r2i172.Text = r2i172.Text + 1
            End If
        End If
        If TimeLeft.Text > 1720 Then
            If TimeLeft.Text <= 1730 Then
                r2i173.Text = r2i173.Text + 1
            End If
        End If
        If TimeLeft.Text > 1730 Then
            If TimeLeft.Text <= 1740 Then
                r2i174.Text = r2i174.Text + 1
            End If
        End If
        If TimeLeft.Text > 1740 Then
            If TimeLeft.Text <= 1750 Then
                r2i175.Text = r2i175.Text + 1
            End If
        End If
        If TimeLeft.Text > 1750 Then
            If TimeLeft.Text <= 1760 Then
                r2i176.Text = r2i176.Text + 1
            End If
        End If
        If TimeLeft.Text > 1760 Then
            If TimeLeft.Text <= 1770 Then
                r2i177.Text = r2i177.Text + 1
            End If
        End If
        If TimeLeft.Text > 1770 Then
            If TimeLeft.Text <= 1780 Then
                r2i178.Text = r2i178.Text + 1
            End If
        End If
        If TimeLeft.Text > 1780 Then
            If TimeLeft.Text <= 1790 Then
                r2i179.Text = r2i179.Text + 1
            End If
        End If
        If TimeLeft.Text > 1790 Then
            If TimeLeft.Text <= 1800 Then
                r2i180.Text = r2i180.Text + 1
            End If
        End If
        If TimeLeft.Text > 1800 Then
            If TimeLeft.Text <= 1810 Then
                r2i181.Text = r2i181.Text + 1
            End If
        End If
        If TimeLeft.Text > 1810 Then
            If TimeLeft.Text <= 1820 Then
                r2i182.Text = r2i182.Text + 1
            End If
        End If
        If TimeLeft.Text > 1820 Then
            If TimeLeft.Text <= 1830 Then
                r2i183.Text = r2i183.Text + 1
            End If
        End If
        If TimeLeft.Text > 1830 Then
            If TimeLeft.Text <= 1840 Then
                r2i184.Text = r2i184.Text + 1
            End If
        End If
        If TimeLeft.Text > 1840 Then
            If TimeLeft.Text <= 1850 Then
                r2i185.Text = r2i185.Text + 1
            End If
        End If
        If TimeLeft.Text > 1850 Then
            If TimeLeft.Text <= 1860 Then
                r2i186.Text = r2i186.Text + 1
            End If
        End If
        If TimeLeft.Text > 1860 Then
            If TimeLeft.Text <= 1870 Then
                r2i187.Text = r2i187.Text + 1
            End If
        End If
        If TimeLeft.Text > 1870 Then
            If TimeLeft.Text <= 1880 Then
                r2i188.Text = r2i188.Text + 1
            End If
        End If
        If TimeLeft.Text > 1880 Then
            If TimeLeft.Text <= 1890 Then
                r2i189.Text = r2i189.Text + 1
            End If
        End If
        If TimeLeft.Text > 1890 Then
            If TimeLeft.Text <= 1900 Then
                r2i190.Text = r2i190.Text + 1
            End If
        End If
        If TimeLeft.Text > 1900 Then
            If TimeLeft.Text <= 1910 Then
                r2i191.Text = r2i191.Text + 1
            End If
        End If
        If TimeLeft.Text > 1910 Then
            If TimeLeft.Text <= 1920 Then
                r2i192.Text = r2i192.Text + 1
            End If
        End If
        If TimeLeft.Text > 1920 Then
            If TimeLeft.Text <= 1930 Then
                r2i193.Text = r2i193.Text + 1
            End If
        End If
        If TimeLeft.Text > 1930 Then
            If TimeLeft.Text <= 1940 Then
                r2i194.Text = r2i194.Text + 1
            End If
        End If
        If TimeLeft.Text > 1940 Then
            If TimeLeft.Text <= 1950 Then
                r2i195.Text = r2i195.Text + 1
            End If
        End If
        If TimeLeft.Text > 1950 Then
            If TimeLeft.Text <= 1960 Then
                r2i196.Text = r2i196.Text + 1
            End If
        End If
        If TimeLeft.Text > 1960 Then
            If TimeLeft.Text <= 1970 Then
                r2i197.Text = r2i197.Text + 1
            End If
        End If
        If TimeLeft.Text > 1970 Then
            If TimeLeft.Text <= 1980 Then
                r2i198.Text = r2i198.Text + 1
            End If
        End If
        If TimeLeft.Text > 1980 Then
            If TimeLeft.Text <= 1990 Then
                r2i199.Text = r2i199.Text + 1
            End If
        End If
        If TimeLeft.Text > 2000 Then
            If TimeLeft.Text <= 2010 Then
                r2i201.Text = r2i201.Text + 1
            End If
        End If
        If TimeLeft.Text > 2010 Then
            If TimeLeft.Text <= 2020 Then
                r2i202.Text = r2i202.Text + 1
            End If
        End If
        If TimeLeft.Text > 2020 Then
            If TimeLeft.Text <= 2030 Then
                r2i203.Text = r2i203.Text + 1
            End If
        End If
        If TimeLeft.Text > 2030 Then
            If TimeLeft.Text <= 2040 Then
                r2i204.Text = r2i204.Text + 1
            End If
        End If
        If TimeLeft.Text > 2040 Then
            If TimeLeft.Text <= 2050 Then
                r2i205.Text = r2i205.Text + 1
            End If
        End If
        If TimeLeft.Text > 2050 Then
            If TimeLeft.Text <= 2060 Then
                r2i206.Text = r2i206.Text + 1
            End If
        End If
        If TimeLeft.Text > 2060 Then
            If TimeLeft.Text <= 2070 Then
                r2i207.Text = r2i207.Text + 1
            End If
        End If
        If TimeLeft.Text > 2070 Then
            If TimeLeft.Text <= 2080 Then
                r2i208.Text = r2i208.Text + 1
            End If
        End If
        If TimeLeft.Text > 2080 Then
            If TimeLeft.Text <= 2090 Then
                r2i209.Text = r2i209.Text + 1
            End If
        End If
        If TimeLeft.Text > 2090 Then
            If TimeLeft.Text <= 2100 Then
                r2i210.Text = r2i210.Text + 1
            End If
        End If
        If TimeLeft.Text > 2100 Then
            If TimeLeft.Text <= 2110 Then
                r2i211.Text = r2i211.Text + 1
            End If
        End If
        If TimeLeft.Text > 2110 Then
            If TimeLeft.Text <= 2120 Then
                r2i212.Text = r2i212.Text + 1
            End If
        End If
        If TimeLeft.Text > 2120 Then
            If TimeLeft.Text <= 2130 Then
                r2i213.Text = r2i213.Text + 1
            End If
        End If
        If TimeLeft.Text > 2130 Then
            If TimeLeft.Text <= 2140 Then
                r2i214.Text = r2i214.Text + 1
            End If
        End If
        If TimeLeft.Text > 2140 Then
            If TimeLeft.Text <= 2150 Then
                r2i215.Text = r2i215.Text + 1
            End If
        End If
        If TimeLeft.Text > 2150 Then
            If TimeLeft.Text <= 2160 Then
                r2i216.Text = r2i216.Text + 1
            End If
        End If
        If TimeLeft.Text > 2160 Then
            If TimeLeft.Text <= 2170 Then
                r2i217.Text = r2i217.Text + 1
            End If
        End If
        If TimeLeft.Text > 2170 Then
            If TimeLeft.Text <= 2180 Then
                r2i218.Text = r2i218.Text + 1
            End If
        End If
        If TimeLeft.Text > 2180 Then
            If TimeLeft.Text <= 2190 Then
                r2i219.Text = r2i219.Text + 1
            End If
        End If
        If TimeLeft.Text > 2190 Then
            If TimeLeft.Text <= 2200 Then
                r2i220.Text = r2i220.Text + 1
            End If
        End If
        If TimeLeft.Text > 2200 Then
            If TimeLeft.Text <= 2210 Then
                r2i221.Text = r2i221.Text + 1
            End If
        End If
        If TimeLeft.Text > 2210 Then
            If TimeLeft.Text <= 2220 Then
                r2i222.Text = r2i222.Text + 1
            End If
        End If
        If TimeLeft.Text > 2220 Then
            If TimeLeft.Text <= 2230 Then
                r2i223.Text = r2i223.Text + 1
            End If
        End If
        If TimeLeft.Text > 2230 Then
            If TimeLeft.Text <= 2240 Then
                r2i224.Text = r2i224.Text + 1
            End If
        End If
        If TimeLeft.Text > 2240 Then
            If TimeLeft.Text <= 2250 Then
                r2i225.Text = r2i225.Text + 1
            End If
        End If
        If TimeLeft.Text > 2250 Then
            If TimeLeft.Text <= 2260 Then
                r2i226.Text = r2i226.Text + 1
            End If
        End If
        If TimeLeft.Text > 2260 Then
            If TimeLeft.Text <= 2270 Then
                r2i227.Text = r2i227.Text + 1
            End If
        End If
        If TimeLeft.Text > 2270 Then
            If TimeLeft.Text <= 2280 Then
                r2i228.Text = r2i228.Text + 1
            End If
        End If
        If TimeLeft.Text > 2280 Then
            If TimeLeft.Text <= 2290 Then
                r2i229.Text = r2i229.Text + 1
            End If
        End If
        If TimeLeft.Text > 2290 Then
            If TimeLeft.Text <= 2300 Then
                r2i230.Text = r2i230.Text + 1
            End If
        End If
        If TimeLeft.Text > 2300 Then
            If TimeLeft.Text <= 2310 Then
                r2i231.Text = r2i231.Text + 1
            End If
        End If
        If TimeLeft.Text > 2310 Then
            If TimeLeft.Text <= 2320 Then
                r2i232.Text = r2i232.Text + 1
            End If
        End If
        If TimeLeft.Text > 2320 Then
            If TimeLeft.Text <= 2330 Then
                r2i233.Text = r2i233.Text + 1
            End If
        End If
        If TimeLeft.Text > 2330 Then
            If TimeLeft.Text <= 2340 Then
                r2i234.Text = r2i234.Text + 1
            End If
        End If
        If TimeLeft.Text > 2340 Then
            If TimeLeft.Text <= 2350 Then
                r2i235.Text = r2i235.Text + 1
            End If
        End If
        If TimeLeft.Text > 2350 Then
            If TimeLeft.Text <= 2360 Then
                r2i236.Text = r2i236.Text + 1
            End If
        End If
        If TimeLeft.Text > 2360 Then
            If TimeLeft.Text <= 2370 Then
                r2i237.Text = r2i237.Text + 1
            End If
        End If
        If TimeLeft.Text > 2370 Then
            If TimeLeft.Text <= 2380 Then
                r2i238.Text = r2i238.Text + 1
            End If
        End If
        If TimeLeft.Text > 2380 Then
            If TimeLeft.Text <= 2390 Then
                r2i239.Text = r2i239.Text + 1
            End If
        End If
        If TimeLeft.Text > 2390 Then
            If TimeLeft.Text <= 2400 Then
                r2i240.Text = r2i240.Text + 1
            End If
        End If
        If TimeLeft.Text > 2400 Then
            If TimeLeft.Text <= 2410 Then
                r2i241.Text = r2i241.Text + 1
            End If
        End If
        If TimeLeft.Text > 2410 Then
            If TimeLeft.Text <= 2420 Then
                r2i242.Text = r2i242.Text + 1
            End If
        End If
        If TimeLeft.Text > 2420 Then
            If TimeLeft.Text <= 2430 Then
                r2i243.Text = r2i243.Text + 1
            End If
        End If
        If TimeLeft.Text > 2430 Then
            If TimeLeft.Text <= 2440 Then
                r2i244.Text = r2i244.Text + 1
            End If
        End If
        If TimeLeft.Text > 2440 Then
            If TimeLeft.Text <= 2450 Then
                r2i245.Text = r2i245.Text + 1
            End If
        End If
        If TimeLeft.Text > 2450 Then
            If TimeLeft.Text <= 2460 Then
                r2i246.Text = r2i246.Text + 1
            End If
        End If
        If TimeLeft.Text > 2460 Then
            If TimeLeft.Text <= 2470 Then
                r2i247.Text = r2i247.Text + 1
            End If
        End If
        If TimeLeft.Text > 2470 Then
            If TimeLeft.Text <= 2480 Then
                r2i248.Text = r2i248.Text + 1
            End If
        End If
        If TimeLeft.Text > 2480 Then
            If TimeLeft.Text <= 2490 Then
                r2i249.Text = r2i249.Text + 1
            End If
        End If
        If TimeLeft.Text > 2490 Then
            If TimeLeft.Text <= 2500 Then
                r2i250.Text = r2i250.Text + 1
            End If
        End If
        If TimeLeft.Text > 2500 Then
            If TimeLeft.Text <= 2510 Then
                r2i251.Text = r2i251.Text + 1
            End If
        End If
        If TimeLeft.Text > 2510 Then
            If TimeLeft.Text <= 2520 Then
                r2i252.Text = r2i252.Text + 1
            End If
        End If
        If TimeLeft.Text > 2520 Then
            If TimeLeft.Text <= 2530 Then
                r2i253.Text = r2i253.Text + 1
            End If
        End If
        If TimeLeft.Text > 2530 Then
            If TimeLeft.Text <= 2540 Then
                r2i254.Text = r2i254.Text + 1
            End If
        End If
        If TimeLeft.Text > 2540 Then
            If TimeLeft.Text <= 2550 Then
                r2i255.Text = r2i255.Text + 1
            End If
        End If
        If TimeLeft.Text > 2550 Then
            If TimeLeft.Text <= 2560 Then
                r2i256.Text = r2i256.Text + 1
            End If
        End If
        If TimeLeft.Text > 2560 Then
            If TimeLeft.Text <= 2570 Then
                r2i257.Text = r2i257.Text + 1
            End If
        End If
        If TimeLeft.Text > 2570 Then
            If TimeLeft.Text <= 2580 Then
                r2i258.Text = r2i258.Text + 1
            End If
        End If
        If TimeLeft.Text > 2580 Then
            If TimeLeft.Text <= 2590 Then
                r2i259.Text = r2i259.Text + 1
            End If
        End If
        If TimeLeft.Text > 2590 Then
            If TimeLeft.Text <= 2600 Then
                r2i260.Text = r2i260.Text + 1
            End If
        End If
        If TimeLeft.Text > 2600 Then
            If TimeLeft.Text <= 2610 Then
                r2i261.Text = r2i261.Text + 1
            End If
        End If
        If TimeLeft.Text > 2610 Then
            If TimeLeft.Text <= 2620 Then
                r2i262.Text = r2i262.Text + 1
            End If
        End If
        If TimeLeft.Text > 2620 Then
            If TimeLeft.Text <= 2630 Then
                r2i263.Text = r2i263.Text + 1
            End If
        End If
        If TimeLeft.Text > 2630 Then
            If TimeLeft.Text <= 2640 Then
                r2i264.Text = r2i264.Text + 1
            End If
        End If
        If TimeLeft.Text > 2640 Then
            If TimeLeft.Text <= 2650 Then
                r2i265.Text = r2i265.Text + 1
            End If
        End If
        If TimeLeft.Text > 2650 Then
            If TimeLeft.Text <= 2660 Then
                r2i266.Text = r2i266.Text + 1
            End If
        End If
        If TimeLeft.Text > 2660 Then
            If TimeLeft.Text <= 2670 Then
                r2i267.Text = r2i267.Text + 1
            End If
        End If
        If TimeLeft.Text > 2670 Then
            If TimeLeft.Text <= 2680 Then
                r2i268.Text = r2i268.Text + 1
            End If
        End If
        If TimeLeft.Text > 2680 Then
            If TimeLeft.Text <= 2690 Then
                r2i269.Text = r2i269.Text + 1
            End If
        End If
        If TimeLeft.Text > 2690 Then
            If TimeLeft.Text <= 2700 Then
                r2i270.Text = r2i270.Text + 1
            End If
        End If
        If TimeLeft.Text > 2700 Then
            If TimeLeft.Text <= 2710 Then
                r2i271.Text = r2i271.Text + 1
            End If
        End If
        If TimeLeft.Text > 2710 Then
            If TimeLeft.Text <= 2720 Then
                r2i272.Text = r2i272.Text + 1
            End If
        End If
        If TimeLeft.Text > 2720 Then
            If TimeLeft.Text <= 2730 Then
                r2i273.Text = r2i273.Text + 1
            End If
        End If
        If TimeLeft.Text > 2730 Then
            If TimeLeft.Text <= 2740 Then
                r2i274.Text = r2i274.Text + 1
            End If
        End If
        If TimeLeft.Text > 2740 Then
            If TimeLeft.Text <= 2750 Then
                r2i275.Text = r2i275.Text + 1
            End If
        End If
        If TimeLeft.Text > 2750 Then
            If TimeLeft.Text <= 2760 Then
                r2i276.Text = r2i276.Text + 1
            End If
        End If
        If TimeLeft.Text > 2760 Then
            If TimeLeft.Text <= 2770 Then
                r2i277.Text = r2i277.Text + 1
            End If
        End If
        If TimeLeft.Text > 2770 Then
            If TimeLeft.Text <= 2780 Then
                r2i278.Text = r2i278.Text + 1
            End If
        End If
        If TimeLeft.Text > 2780 Then
            If TimeLeft.Text <= 2790 Then
                r2i279.Text = r2i279.Text + 1
            End If
        End If
        If TimeLeft.Text > 2790 Then
            If TimeLeft.Text <= 2800 Then
                r2i281.Text = r2i280.Text + 1
            End If
        End If
        If TimeLeft.Text > 2800 Then
            If TimeLeft.Text <= 2810 Then
                r2i281.Text = r2i281.Text + 1
            End If
        End If
        If TimeLeft.Text > 2810 Then
            If TimeLeft.Text <= 2820 Then
                r2i282.Text = r2i282.Text + 1
            End If
        End If
        If TimeLeft.Text > 2820 Then
            If TimeLeft.Text <= 2830 Then
                r2i283.Text = r2i283.Text + 1
            End If
        End If
        If TimeLeft.Text > 2830 Then
            If TimeLeft.Text <= 2840 Then
                r2i284.Text = r2i284.Text + 1
            End If
        End If
        If TimeLeft.Text > 2840 Then
            If TimeLeft.Text <= 2850 Then
                r2i285.Text = r2i285.Text + 1
            End If
        End If
        If TimeLeft.Text > 2850 Then
            If TimeLeft.Text <= 2860 Then
                r2i286.Text = r2i286.Text + 1
            End If
        End If
        If TimeLeft.Text > 2860 Then
            If TimeLeft.Text <= 2870 Then
                r2i287.Text = r2i287.Text + 1
            End If
        End If
        If TimeLeft.Text > 2870 Then
            If TimeLeft.Text <= 2880 Then
                r2i288.Text = r2i288.Text + 1
            End If
        End If

    End Sub

    'Code for alternative two response. 
    Private Sub r0401_Click(sender As Object, e As EventArgs) Handles r0401.Click
        r0401.Visible = False
        r0402.Visible = True
        r0101.Visible = True
        r0102.Visible = False
        r0103.Visible = False
        r0104.Visible = False
        r0105.Visible = False
        r0106.Visible = False
        r0201.Visible = True
        r0202.Visible = False
        r0203.Visible = False
        r0204.Visible = False
        r0205.Visible = False
        r0206.Visible = False
        r0301.Visible = True
        r0302.Visible = False
        r0303.Visible = False
        r0304.Visible = False
        r0305.Visible = False
        r0306.Visible = False
        r0501.Visible = True
        r0502.Visible = False
        r0503.Visible = False
        r0504.Visible = False
        r0505.Visible = False
        r0506.Visible = False
        r0601.Visible = True
        r0602.Visible = False
        r0603.Visible = False
        r0604.Visible = False
        r0605.Visible = False
        r0606.Visible = False
    End Sub
    Private Sub r0402_Click(sender As Object, e As EventArgs) Handles r0402.Click
        r0402.Visible = False
        r0403.Visible = True
    End Sub
    Private Sub r0403_Click(sender As Object, e As EventArgs) Handles r0403.Click
        r0403.Visible = False
        r0404.Visible = True
    End Sub
    Private Sub r0404_Click(sender As Object, e As EventArgs) Handles r0404.Click
        r0404.Visible = False
        r0405.Visible = True
    End Sub
    Private Sub r0405_Click(sender As Object, e As EventArgs) Handles r0405.Click
        r0405.Visible = False
        r0406.Visible = True
    End Sub
    Private Sub r0406_Click(sender As Object, e As EventArgs) Handles r0406.Click
        r0406.Visible = False
        r0401.Visible = True
        'Code for changeover (CO) response. That is, the first response following switching cannot contact reinforcement. 
        If r4CO.Text < 2 Then
            r4CO.Text = Val(r4CO.Text) + 1
            r1CO.Text = 0
            r2CO.Text = 0
            r3CO.Text = 0
            r5CO.Text = 0
            r6CO.Text = 0
        End If
        If r4CO.Text = 2 Then
            If r4VIval.Text = 0 Then
                pointText.Visible = True
                consumResp.Visible = True
                Alt2TimeDeliver.Text = Alt2TimeDeliver.Text + TimeLeft.Text + ","
            End If
        End If
        'Code for count per 2-min session. 
        If TimeLeft.Text > 0 Then
            If TimeLeft.Text <= 120 Then
                r4sess1.Text = r4sess1.Text + 1
            End If
        End If
        If TimeLeft.Text > 120 Then
            If TimeLeft.Text <= 240 Then
                r4sess2.Text = r4sess2.Text + 1
            End If
        End If
        If TimeLeft.Text > 240 Then
            If TimeLeft.Text <= 360 Then
                r4sess3.Text = r4sess3.Text + 1
            End If
        End If
        If TimeLeft.Text > 360 Then
            If TimeLeft.Text <= 480 Then
                r4sess4.Text = r4sess4.Text + 1
            End If
        End If
        If TimeLeft.Text > 480 Then
            If TimeLeft.Text <= 600 Then
                r4sess5.Text = r4sess5.Text + 1
            End If
        End If
        If TimeLeft.Text > 600 Then
            If TimeLeft.Text <= 720 Then
                r4sess6.Text = r4sess6.Text + 1
            End If
        End If
        If TimeLeft.Text > 720 Then
            If TimeLeft.Text <= 840 Then
                r4sess7.Text = r4sess7.Text + 1
            End If
        End If
        If TimeLeft.Text > 840 Then
            If TimeLeft.Text <= 960 Then
                r4sess8.Text = r4sess8.Text + 1
            End If
        End If
        If TimeLeft.Text > 960 Then
            If TimeLeft.Text <= 1080 Then
                r4sess9.Text = r4sess9.Text + 1
            End If
        End If
        If TimeLeft.Text > 1080 Then
            If TimeLeft.Text <= 1200 Then
                r4sess10.Text = r4sess10.Text + 1
            End If
        End If
        If TimeLeft.Text > 1200 Then
            If TimeLeft.Text <= 1320 Then
                r4sess11.Text = r4sess11.Text + 1
            End If
        End If
        If TimeLeft.Text > 1320 Then
            If TimeLeft.Text <= 1440 Then
                r4sess12.Text = r4sess12.Text + 1
            End If
        End If
        If TimeLeft.Text > 1440 Then
            If TimeLeft.Text <= 1560 Then
                r4sess13.Text = r4sess13.Text + 1
            End If
        End If
        If TimeLeft.Text > 1560 Then
            If TimeLeft.Text <= 1680 Then
                r4sess14.Text = r4sess14.Text + 1
            End If
        End If
        If TimeLeft.Text > 1680 Then
            If TimeLeft.Text <= 1800 Then
                r4sess15.Text = r4sess15.Text + 1
            End If
        End If
        If TimeLeft.Text > 1800 Then
            If TimeLeft.Text <= 1920 Then
                r4sess16.Text = r4sess16.Text + 1
            End If
        End If
        If TimeLeft.Text > 1920 Then
            If TimeLeft.Text <= 2040 Then
                r4sess17.Text = r4sess17.Text + 1
            End If
        End If
        If TimeLeft.Text > 2040 Then
            If TimeLeft.Text <= 2160 Then
                r4sess18.Text = r4sess18.Text + 1
            End If
        End If
        If TimeLeft.Text > 2160 Then
            If TimeLeft.Text <= 2280 Then
                r4sess19.Text = r4sess19.Text + 1
            End If
        End If
        If TimeLeft.Text > 2280 Then
            If TimeLeft.Text <= 2400 Then
                r4sess20.Text = r4sess20.Text + 1
            End If
        End If
        If TimeLeft.Text > 2400 Then
            If TimeLeft.Text <= 2520 Then
                r4sess21.Text = r4sess21.Text + 1
            End If
        End If
        If TimeLeft.Text > 2520 Then
            If TimeLeft.Text <= 2640 Then
                r4sess22.Text = r4sess22.Text + 1
            End If
        End If
        If TimeLeft.Text > 2640 Then
            If TimeLeft.Text <= 2760 Then
                r4sess23.Text = r4sess23.Text + 1
            End If
        End If
        If TimeLeft.Text > 2760 Then
            If TimeLeft.Text <= 2880 Then
                r4sess24.Text = r4sess24.Text + 1
            End If
        End If


        'Code for count per 10-sec interval.
        If TimeLeft.Text > 0 Then
            If TimeLeft.Text <= 10 Then
                r4i01.Text = r4i01.Text + 1
            End If
        End If
        If TimeLeft.Text > 10 Then
            If TimeLeft.Text <= 20 Then
                r4i02.Text = r4i02.Text + 1
            End If
        End If
        If TimeLeft.Text > 20 Then
            If TimeLeft.Text <= 30 Then
                r4i03.Text = r4i03.Text + 1
            End If
        End If
        If TimeLeft.Text > 30 Then
            If TimeLeft.Text <= 40 Then
                r4i04.Text = r4i04.Text + 1
            End If
        End If
        If TimeLeft.Text > 40 Then
            If TimeLeft.Text <= 50 Then
                r4i05.Text = r4i05.Text + 1
            End If
        End If
        If TimeLeft.Text > 50 Then
            If TimeLeft.Text <= 60 Then
                r4i06.Text = r4i06.Text + 1
            End If
        End If
        If TimeLeft.Text > 60 Then
            If TimeLeft.Text <= 70 Then
                r4i07.Text = r4i07.Text + 1
            End If
        End If
        If TimeLeft.Text > 70 Then
            If TimeLeft.Text <= 80 Then
                r4i08.Text = r4i08.Text + 1
            End If
        End If
        If TimeLeft.Text > 80 Then
            If TimeLeft.Text <= 90 Then
                r4i09.Text = r4i09.Text + 1
            End If
        End If
        If TimeLeft.Text > 90 Then
            If TimeLeft.Text <= 100 Then
                r4i10.Text = r4i10.Text + 1
            End If
        End If
        If TimeLeft.Text > 100 Then
            If TimeLeft.Text <= 110 Then
                r4i11.Text = r4i11.Text + 1
            End If
        End If
        If TimeLeft.Text > 110 Then
            If TimeLeft.Text <= 120 Then
                r4i12.Text = r4i12.Text + 1
            End If
        End If
        If TimeLeft.Text > 120 Then
            If TimeLeft.Text <= 130 Then
                r4i13.Text = r4i13.Text + 1
            End If
        End If
        If TimeLeft.Text > 130 Then
            If TimeLeft.Text <= 140 Then
                r4i14.Text = r4i14.Text + 1
            End If
        End If
        If TimeLeft.Text > 140 Then
            If TimeLeft.Text <= 150 Then
                r4i15.Text = r4i15.Text + 1
            End If
        End If
        If TimeLeft.Text > 150 Then
            If TimeLeft.Text <= 160 Then
                r4i16.Text = r4i16.Text + 1
            End If
        End If
        If TimeLeft.Text > 160 Then
            If TimeLeft.Text <= 170 Then
                r4i17.Text = r4i17.Text + 1
            End If
        End If
        If TimeLeft.Text > 170 Then
            If TimeLeft.Text <= 180 Then
                r4i18.Text = r4i18.Text + 1
            End If
        End If
        If TimeLeft.Text > 180 Then
            If TimeLeft.Text <= 190 Then
                r4i19.Text = r4i19.Text + 1
            End If
        End If
        If TimeLeft.Text > 190 Then
            If TimeLeft.Text <= 200 Then
                r4i20.Text = r4i20.Text + 1
            End If
        End If
        If TimeLeft.Text > 200 Then
            If TimeLeft.Text <= 210 Then
                r4i21.Text = r4i21.Text + 1
            End If
        End If
        If TimeLeft.Text > 210 Then
            If TimeLeft.Text <= 220 Then
                r4i22.Text = r4i22.Text + 1
            End If
        End If
        If TimeLeft.Text > 220 Then
            If TimeLeft.Text <= 230 Then
                r4i23.Text = r4i23.Text + 1
            End If
        End If
        If TimeLeft.Text > 230 Then
            If TimeLeft.Text <= 240 Then
                r4i24.Text = r4i24.Text + 1
            End If
        End If
        If TimeLeft.Text > 240 Then
            If TimeLeft.Text <= 250 Then
                r4i25.Text = r4i25.Text + 1
            End If
        End If
        If TimeLeft.Text > 250 Then
            If TimeLeft.Text <= 260 Then
                r4i26.Text = r4i26.Text + 1
            End If
        End If
        If TimeLeft.Text > 260 Then
            If TimeLeft.Text <= 270 Then
                r4i27.Text = r4i27.Text + 1
            End If
        End If
        If TimeLeft.Text > 270 Then
            If TimeLeft.Text <= 280 Then
                r4i28.Text = r4i28.Text + 1
            End If
        End If
        If TimeLeft.Text > 280 Then
            If TimeLeft.Text <= 290 Then
                r4i29.Text = r4i29.Text + 1
            End If
        End If
        If TimeLeft.Text > 290 Then
            If TimeLeft.Text <= 300 Then
                r4i30.Text = r4i30.Text + 1
            End If
        End If
        If TimeLeft.Text > 300 Then
            If TimeLeft.Text <= 310 Then
                r4i31.Text = r4i31.Text + 1
            End If
        End If
        If TimeLeft.Text > 310 Then
            If TimeLeft.Text <= 320 Then
                r4i32.Text = r4i32.Text + 1
            End If
        End If
        If TimeLeft.Text > 320 Then
            If TimeLeft.Text <= 330 Then
                r4i33.Text = r4i33.Text + 1
            End If
        End If
        If TimeLeft.Text > 330 Then
            If TimeLeft.Text <= 340 Then
                r4i34.Text = r4i34.Text + 1
            End If
        End If
        If TimeLeft.Text > 340 Then
            If TimeLeft.Text <= 350 Then
                r4i35.Text = r4i35.Text + 1
            End If
        End If
        If TimeLeft.Text > 350 Then
            If TimeLeft.Text <= 360 Then
                r4i36.Text = r4i36.Text + 1
            End If
        End If
        If TimeLeft.Text > 360 Then
            If TimeLeft.Text <= 370 Then
                r4i37.Text = r4i37.Text + 1
            End If
        End If
        If TimeLeft.Text > 370 Then
            If TimeLeft.Text <= 380 Then
                r4i38.Text = r4i38.Text + 1
            End If
        End If
        If TimeLeft.Text > 380 Then
            If TimeLeft.Text <= 390 Then
                r4i39.Text = r4i39.Text + 1
            End If
        End If
        If TimeLeft.Text > 390 Then
            If TimeLeft.Text <= 400 Then
                r4i40.Text = r4i40.Text + 1
            End If
        End If
        If TimeLeft.Text > 400 Then
            If TimeLeft.Text <= 410 Then
                r4i41.Text = r4i41.Text + 1
            End If
        End If
        If TimeLeft.Text > 410 Then
            If TimeLeft.Text <= 420 Then
                r4i42.Text = r4i42.Text + 1
            End If
        End If
        If TimeLeft.Text > 420 Then
            If TimeLeft.Text <= 430 Then
                r4i43.Text = r4i43.Text + 1
            End If
        End If
        If TimeLeft.Text > 430 Then
            If TimeLeft.Text <= 440 Then
                r4i44.Text = r4i44.Text + 1
            End If
        End If
        If TimeLeft.Text > 440 Then
            If TimeLeft.Text <= 450 Then
                r4i45.Text = r4i45.Text + 1
            End If
        End If
        If TimeLeft.Text > 450 Then
            If TimeLeft.Text <= 460 Then
                r4i46.Text = r4i46.Text + 1
            End If
        End If
        If TimeLeft.Text > 460 Then
            If TimeLeft.Text <= 470 Then
                r4i47.Text = r4i47.Text + 1
            End If
        End If
        If TimeLeft.Text > 470 Then
            If TimeLeft.Text <= 480 Then
                r4i48.Text = r4i48.Text + 1
            End If
        End If
        If TimeLeft.Text > 480 Then
            If TimeLeft.Text <= 490 Then
                r4i49.Text = r4i49.Text + 1
            End If
        End If
        If TimeLeft.Text > 490 Then
            If TimeLeft.Text <= 500 Then
                r4i50.Text = r4i50.Text + 1
            End If
        End If
        If TimeLeft.Text > 500 Then
            If TimeLeft.Text <= 510 Then
                r4i51.Text = r4i51.Text + 1
            End If
        End If
        If TimeLeft.Text > 510 Then
            If TimeLeft.Text <= 520 Then
                r4i52.Text = r4i52.Text + 1
            End If
        End If
        If TimeLeft.Text > 520 Then
            If TimeLeft.Text <= 530 Then
                r4i53.Text = r4i53.Text + 1
            End If
        End If
        If TimeLeft.Text > 530 Then
            If TimeLeft.Text <= 540 Then
                r4i54.Text = r4i54.Text + 1
            End If
        End If
        If TimeLeft.Text > 540 Then
            If TimeLeft.Text <= 550 Then
                r4i55.Text = r4i55.Text + 1
            End If
        End If
        If TimeLeft.Text > 550 Then
            If TimeLeft.Text <= 560 Then
                r4i56.Text = r4i56.Text + 1
            End If
        End If
        If TimeLeft.Text > 560 Then
            If TimeLeft.Text <= 570 Then
                r4i57.Text = r4i57.Text + 1
            End If
        End If
        If TimeLeft.Text > 570 Then
            If TimeLeft.Text <= 580 Then
                r4i58.Text = r4i58.Text + 1
            End If
        End If
        If TimeLeft.Text > 580 Then
            If TimeLeft.Text <= 590 Then
                r4i59.Text = r4i59.Text + 1
            End If
        End If
        If TimeLeft.Text > 590 Then
            If TimeLeft.Text <= 600 Then
                r4i60.Text = r4i60.Text + 1
            End If
        End If
        If TimeLeft.Text > 600 Then
            If TimeLeft.Text <= 610 Then
                r4i61.Text = r4i61.Text + 1
            End If
        End If
        If TimeLeft.Text > 610 Then
            If TimeLeft.Text <= 620 Then
                r4i62.Text = r4i62.Text + 1
            End If
        End If
        If TimeLeft.Text > 620 Then
            If TimeLeft.Text <= 630 Then
                r4i63.Text = r4i63.Text + 1
            End If
        End If
        If TimeLeft.Text > 630 Then
            If TimeLeft.Text <= 640 Then
                r4i64.Text = r4i64.Text + 1
            End If
        End If
        If TimeLeft.Text > 640 Then
            If TimeLeft.Text <= 650 Then
                r4i65.Text = r4i65.Text + 1
            End If
        End If
        If TimeLeft.Text > 650 Then
            If TimeLeft.Text <= 660 Then
                r4i66.Text = r4i66.Text + 1
            End If
        End If
        If TimeLeft.Text > 660 Then
            If TimeLeft.Text <= 670 Then
                r4i67.Text = r4i67.Text + 1
            End If
        End If
        If TimeLeft.Text > 670 Then
            If TimeLeft.Text <= 680 Then
                r4i68.Text = r4i68.Text + 1
            End If
        End If
        If TimeLeft.Text > 680 Then
            If TimeLeft.Text <= 690 Then
                r4i69.Text = r4i69.Text + 1
            End If
        End If
        If TimeLeft.Text > 690 Then
            If TimeLeft.Text <= 700 Then
                r4i70.Text = r4i70.Text + 1
            End If
        End If
        If TimeLeft.Text > 700 Then
            If TimeLeft.Text <= 710 Then
                r4i71.Text = r4i71.Text + 1
            End If
        End If
        If TimeLeft.Text > 710 Then
            If TimeLeft.Text <= 720 Then
                r4i72.Text = r4i72.Text + 1
            End If
        End If
        If TimeLeft.Text > 720 Then
            If TimeLeft.Text <= 730 Then
                r4i73.Text = r4i73.Text + 1
            End If
        End If
        If TimeLeft.Text > 730 Then
            If TimeLeft.Text <= 740 Then
                r4i74.Text = r4i74.Text + 1
            End If
        End If
        If TimeLeft.Text > 740 Then
            If TimeLeft.Text <= 750 Then
                r4i75.Text = r4i75.Text + 1
            End If
        End If
        If TimeLeft.Text > 750 Then
            If TimeLeft.Text <= 760 Then
                r4i76.Text = r4i76.Text + 1
            End If
        End If
        If TimeLeft.Text > 760 Then
            If TimeLeft.Text <= 770 Then
                r4i77.Text = r4i77.Text + 1
            End If
        End If
        If TimeLeft.Text > 770 Then
            If TimeLeft.Text <= 780 Then
                r4i78.Text = r4i78.Text + 1
            End If
        End If
        If TimeLeft.Text > 780 Then
            If TimeLeft.Text <= 790 Then
                r4i79.Text = r4i79.Text + 1
            End If
        End If
        If TimeLeft.Text > 790 Then
            If TimeLeft.Text <= 800 Then
                r4i80.Text = r4i80.Text + 1
            End If
        End If
        If TimeLeft.Text > 800 Then
            If TimeLeft.Text <= 810 Then
                r4i81.Text = r4i81.Text + 1
            End If
        End If
        If TimeLeft.Text > 810 Then
            If TimeLeft.Text <= 820 Then
                r4i82.Text = r4i82.Text + 1
            End If
        End If
        If TimeLeft.Text > 820 Then
            If TimeLeft.Text <= 830 Then
                r4i83.Text = r4i83.Text + 1
            End If
        End If
        If TimeLeft.Text > 830 Then
            If TimeLeft.Text <= 840 Then
                r4i84.Text = r4i84.Text + 1
            End If
        End If
        If TimeLeft.Text > 840 Then
            If TimeLeft.Text <= 850 Then
                r4i85.Text = r4i85.Text + 1
            End If
        End If
        If TimeLeft.Text > 850 Then
            If TimeLeft.Text <= 860 Then
                r4i86.Text = r4i86.Text + 1
            End If
        End If
        If TimeLeft.Text > 860 Then
            If TimeLeft.Text <= 870 Then
                r4i87.Text = r4i87.Text + 1
            End If
        End If
        If TimeLeft.Text > 870 Then
            If TimeLeft.Text <= 880 Then
                r4i88.Text = r4i88.Text + 1
            End If
        End If
        If TimeLeft.Text > 880 Then
            If TimeLeft.Text <= 890 Then
                r4i89.Text = r4i89.Text + 1
            End If
        End If
        If TimeLeft.Text > 890 Then
            If TimeLeft.Text <= 900 Then
                r4i90.Text = r4i90.Text + 1
            End If
        End If
        If TimeLeft.Text > 900 Then
            If TimeLeft.Text <= 910 Then
                r4i91.Text = r4i91.Text + 1
            End If
        End If
        If TimeLeft.Text > 910 Then
            If TimeLeft.Text <= 920 Then
                r4i92.Text = r4i92.Text + 1
            End If
        End If
        If TimeLeft.Text > 920 Then
            If TimeLeft.Text <= 930 Then
                r4i93.Text = r4i93.Text + 1
            End If
        End If
        If TimeLeft.Text > 930 Then
            If TimeLeft.Text <= 940 Then
                r4i94.Text = r4i94.Text + 1
            End If
        End If
        If TimeLeft.Text > 940 Then
            If TimeLeft.Text <= 950 Then
                r4i95.Text = r4i95.Text + 1
            End If
        End If
        If TimeLeft.Text > 950 Then
            If TimeLeft.Text <= 960 Then
                r4i96.Text = r4i96.Text + 1
            End If
        End If
        If TimeLeft.Text > 960 Then
            If TimeLeft.Text <= 970 Then
                r4i97.Text = r4i97.Text + 1
            End If
        End If
        If TimeLeft.Text > 970 Then
            If TimeLeft.Text <= 980 Then
                r4i98.Text = r4i98.Text + 1
            End If
        End If
        If TimeLeft.Text > 980 Then
            If TimeLeft.Text <= 990 Then
                r4i99.Text = r4i99.Text + 1
            End If
        End If
        If TimeLeft.Text > 990 Then
            If TimeLeft.Text <= 1000 Then
                r4i100.Text = r4i100.Text + 1
            End If
        End If
        If TimeLeft.Text > 1000 Then
            If TimeLeft.Text <= 1010 Then
                r4i101.Text = r4i101.Text + 1
            End If
        End If
        If TimeLeft.Text > 1010 Then
            If TimeLeft.Text <= 1020 Then
                r4i102.Text = r4i102.Text + 1
            End If
        End If
        If TimeLeft.Text > 1020 Then
            If TimeLeft.Text <= 1030 Then
                r4i103.Text = r4i103.Text + 1
            End If
        End If
        If TimeLeft.Text > 1030 Then
            If TimeLeft.Text <= 1040 Then
                r4i104.Text = r4i104.Text + 1
            End If
        End If
        If TimeLeft.Text > 1040 Then
            If TimeLeft.Text <= 1050 Then
                r4i105.Text = r4i105.Text + 1
            End If
        End If
        If TimeLeft.Text > 1050 Then
            If TimeLeft.Text <= 1060 Then
                r4i106.Text = r4i106.Text + 1
            End If
        End If
        If TimeLeft.Text > 1060 Then
            If TimeLeft.Text <= 1070 Then
                r4i107.Text = r4i107.Text + 1
            End If
        End If
        If TimeLeft.Text > 1070 Then
            If TimeLeft.Text <= 1080 Then
                r4i108.Text = r4i108.Text + 1
            End If
        End If
        If TimeLeft.Text > 1080 Then
            If TimeLeft.Text <= 1090 Then
                r4i109.Text = r4i109.Text + 1
            End If
        End If
        If TimeLeft.Text > 1090 Then
            If TimeLeft.Text <= 1100 Then
                r4i200.Text = r4i200.Text + 1
            End If
        End If
        If TimeLeft.Text > 1100 Then
            If TimeLeft.Text <= 1110 Then
                r4i111.Text = r4i111.Text + 1
            End If
        End If
        If TimeLeft.Text > 1110 Then
            If TimeLeft.Text <= 1120 Then
                r4i112.Text = r4i112.Text + 1
            End If
        End If
        If TimeLeft.Text > 1120 Then
            If TimeLeft.Text <= 1130 Then
                r4i113.Text = r4i113.Text + 1
            End If
        End If
        If TimeLeft.Text > 1130 Then
            If TimeLeft.Text <= 1140 Then
                r4i114.Text = r4i114.Text + 1
            End If
        End If
        If TimeLeft.Text > 1140 Then
            If TimeLeft.Text <= 1150 Then
                r4i115.Text = r4i115.Text + 1
            End If
        End If
        If TimeLeft.Text > 1150 Then
            If TimeLeft.Text <= 1160 Then
                r4i116.Text = r4i116.Text + 1
            End If
        End If
        If TimeLeft.Text > 1160 Then
            If TimeLeft.Text <= 1170 Then
                r4i117.Text = r4i117.Text + 1
            End If
        End If
        If TimeLeft.Text > 1170 Then
            If TimeLeft.Text <= 1180 Then
                r4i118.Text = r4i118.Text + 1
            End If
        End If
        If TimeLeft.Text > 1180 Then
            If TimeLeft.Text <= 1190 Then
                r4i119.Text = r4i119.Text + 1
            End If
        End If
        If TimeLeft.Text > 1190 Then
            If TimeLeft.Text <= 1200 Then
                r4i120.Text = r4i120.Text + 1
            End If
        End If
        If TimeLeft.Text > 1200 Then
            If TimeLeft.Text <= 1210 Then
                r4i121.Text = r4i121.Text + 1
            End If
        End If
        If TimeLeft.Text > 1210 Then
            If TimeLeft.Text <= 1220 Then
                r4i122.Text = r4i122.Text + 1
            End If
        End If
        If TimeLeft.Text > 1220 Then
            If TimeLeft.Text <= 1230 Then
                r4i123.Text = r4i123.Text + 1
            End If
        End If
        If TimeLeft.Text > 1230 Then
            If TimeLeft.Text <= 1240 Then
                r4i124.Text = r4i124.Text + 1
            End If
        End If
        If TimeLeft.Text > 1240 Then
            If TimeLeft.Text <= 1250 Then
                r4i125.Text = r4i125.Text + 1
            End If
        End If
        If TimeLeft.Text > 1250 Then
            If TimeLeft.Text <= 1260 Then
                r4i126.Text = r4i126.Text + 1
            End If
        End If
        If TimeLeft.Text > 1260 Then
            If TimeLeft.Text <= 1270 Then
                r4i127.Text = r4i127.Text + 1
            End If
        End If
        If TimeLeft.Text > 1270 Then
            If TimeLeft.Text <= 1280 Then
                r4i128.Text = r4i128.Text + 1
            End If
        End If
        If TimeLeft.Text > 1280 Then
            If TimeLeft.Text <= 1290 Then
                r4i129.Text = r4i129.Text + 1
            End If
        End If
        If TimeLeft.Text > 1290 Then
            If TimeLeft.Text <= 1300 Then
                r4i130.Text = r4i130.Text + 1
            End If
        End If
        If TimeLeft.Text > 1300 Then
            If TimeLeft.Text <= 1310 Then
                r4i131.Text = r4i131.Text + 1
            End If
        End If
        If TimeLeft.Text > 1310 Then
            If TimeLeft.Text <= 1320 Then
                r4i132.Text = r4i132.Text + 1
            End If
        End If
        If TimeLeft.Text > 1320 Then
            If TimeLeft.Text <= 1330 Then
                r4i133.Text = r4i133.Text + 1
            End If
        End If
        If TimeLeft.Text > 1330 Then
            If TimeLeft.Text <= 1340 Then
                r4i134.Text = r4i134.Text + 1
            End If
        End If
        If TimeLeft.Text > 1340 Then
            If TimeLeft.Text <= 1350 Then
                r4i135.Text = r4i135.Text + 1
            End If
        End If
        If TimeLeft.Text > 1350 Then
            If TimeLeft.Text <= 1360 Then
                r4i136.Text = r4i136.Text + 1
            End If
        End If
        If TimeLeft.Text > 1360 Then
            If TimeLeft.Text <= 1370 Then
                r4i137.Text = r4i137.Text + 1
            End If
        End If
        If TimeLeft.Text > 1370 Then
            If TimeLeft.Text <= 1380 Then
                r4i138.Text = r4i138.Text + 1
            End If
        End If
        If TimeLeft.Text > 1380 Then
            If TimeLeft.Text <= 1390 Then
                r4i139.Text = r4i139.Text + 1
            End If
        End If
        If TimeLeft.Text > 1390 Then
            If TimeLeft.Text <= 1400 Then
                r4i140.Text = r4i140.Text + 1
            End If
        End If
        If TimeLeft.Text > 1400 Then
            If TimeLeft.Text <= 1410 Then
                r4i141.Text = r4i141.Text + 1
            End If
        End If
        If TimeLeft.Text > 1410 Then
            If TimeLeft.Text <= 1420 Then
                r4i142.Text = r4i142.Text + 1
            End If
        End If
        If TimeLeft.Text > 1420 Then
            If TimeLeft.Text <= 1430 Then
                r4i143.Text = r4i143.Text + 1
            End If
        End If
        If TimeLeft.Text > 1430 Then
            If TimeLeft.Text <= 1440 Then
                r4i144.Text = r4i144.Text + 1
            End If
        End If
        If TimeLeft.Text > 1440 Then
            If TimeLeft.Text <= 1450 Then
                r4i145.Text = r4i145.Text + 1
            End If
        End If
        If TimeLeft.Text > 1450 Then
            If TimeLeft.Text <= 1460 Then
                r4i146.Text = r4i146.Text + 1
            End If
        End If
        If TimeLeft.Text > 1460 Then
            If TimeLeft.Text <= 1470 Then
                r4i147.Text = r4i147.Text + 1
            End If
        End If
        If TimeLeft.Text > 1470 Then
            If TimeLeft.Text <= 1480 Then
                r4i148.Text = r4i148.Text + 1
            End If
        End If
        If TimeLeft.Text > 1480 Then
            If TimeLeft.Text <= 1490 Then
                r4i149.Text = r4i149.Text + 1
            End If
        End If
        If TimeLeft.Text > 1490 Then
            If TimeLeft.Text <= 1500 Then
                r4i150.Text = r4i150.Text + 1
            End If
        End If
        If TimeLeft.Text > 1500 Then
            If TimeLeft.Text <= 1510 Then
                r4i151.Text = r4i151.Text + 1
            End If
        End If
        If TimeLeft.Text > 1510 Then
            If TimeLeft.Text <= 1520 Then
                r4i152.Text = r4i152.Text + 1
            End If
        End If
        If TimeLeft.Text > 1520 Then
            If TimeLeft.Text <= 1530 Then
                r4i153.Text = r4i153.Text + 1
            End If
        End If
        If TimeLeft.Text > 1530 Then
            If TimeLeft.Text <= 1540 Then
                r4i154.Text = r4i154.Text + 1
            End If
        End If
        If TimeLeft.Text > 1540 Then
            If TimeLeft.Text <= 1550 Then
                r4i155.Text = r4i155.Text + 1
            End If
        End If
        If TimeLeft.Text > 1550 Then
            If TimeLeft.Text <= 1560 Then
                r4i156.Text = r4i156.Text + 1
            End If
        End If
        If TimeLeft.Text > 1560 Then
            If TimeLeft.Text <= 1570 Then
                r4i157.Text = r4i157.Text + 1
            End If
        End If
        If TimeLeft.Text > 1570 Then
            If TimeLeft.Text <= 1580 Then
                r4i158.Text = r4i158.Text + 1
            End If
        End If
        If TimeLeft.Text > 1580 Then
            If TimeLeft.Text <= 1590 Then
                r4i159.Text = r4i159.Text + 1
            End If
        End If
        If TimeLeft.Text > 1590 Then
            If TimeLeft.Text <= 1600 Then
                r4i160.Text = r4i160.Text + 1
            End If
        End If
        If TimeLeft.Text > 1600 Then
            If TimeLeft.Text <= 1610 Then
                r4i161.Text = r4i161.Text + 1
            End If
        End If
        If TimeLeft.Text > 1610 Then
            If TimeLeft.Text <= 1620 Then
                r4i162.Text = r4i162.Text + 1
            End If
        End If
        If TimeLeft.Text > 1620 Then
            If TimeLeft.Text <= 1630 Then
                r4i163.Text = r4i163.Text + 1
            End If
        End If
        If TimeLeft.Text > 1630 Then
            If TimeLeft.Text <= 1640 Then
                r4i164.Text = r4i164.Text + 1
            End If
        End If
        If TimeLeft.Text > 1640 Then
            If TimeLeft.Text <= 1650 Then
                r4i165.Text = r4i165.Text + 1
            End If
        End If
        If TimeLeft.Text > 1650 Then
            If TimeLeft.Text <= 1660 Then
                r4i166.Text = r4i166.Text + 1
            End If
        End If
        If TimeLeft.Text > 1660 Then
            If TimeLeft.Text <= 1670 Then
                r4i167.Text = r4i167.Text + 1
            End If
        End If
        If TimeLeft.Text > 1670 Then
            If TimeLeft.Text <= 1680 Then
                r4i168.Text = r4i168.Text + 1
            End If
        End If
        If TimeLeft.Text > 1680 Then
            If TimeLeft.Text <= 1690 Then
                r4i169.Text = r4i169.Text + 1
            End If
        End If
        If TimeLeft.Text > 1690 Then
            If TimeLeft.Text <= 1700 Then
                r4i170.Text = r4i170.Text + 1
            End If
        End If
        If TimeLeft.Text > 1700 Then
            If TimeLeft.Text <= 1710 Then
                r4i171.Text = r4i171.Text + 1
            End If
        End If
        If TimeLeft.Text > 1710 Then
            If TimeLeft.Text <= 1720 Then
                r4i172.Text = r4i172.Text + 1
            End If
        End If
        If TimeLeft.Text > 1720 Then
            If TimeLeft.Text <= 1730 Then
                r4i173.Text = r4i173.Text + 1
            End If
        End If
        If TimeLeft.Text > 1730 Then
            If TimeLeft.Text <= 1740 Then
                r4i174.Text = r4i174.Text + 1
            End If
        End If
        If TimeLeft.Text > 1740 Then
            If TimeLeft.Text <= 1750 Then
                r4i175.Text = r4i175.Text + 1
            End If
        End If
        If TimeLeft.Text > 1750 Then
            If TimeLeft.Text <= 1760 Then
                r4i176.Text = r4i176.Text + 1
            End If
        End If
        If TimeLeft.Text > 1760 Then
            If TimeLeft.Text <= 1770 Then
                r4i177.Text = r4i177.Text + 1
            End If
        End If
        If TimeLeft.Text > 1770 Then
            If TimeLeft.Text <= 1780 Then
                r4i178.Text = r4i178.Text + 1
            End If
        End If
        If TimeLeft.Text > 1780 Then
            If TimeLeft.Text <= 1790 Then
                r4i179.Text = r4i179.Text + 1
            End If
        End If
        If TimeLeft.Text > 1790 Then
            If TimeLeft.Text <= 1800 Then
                r4i180.Text = r4i180.Text + 1
            End If
        End If
        If TimeLeft.Text > 1800 Then
            If TimeLeft.Text <= 1810 Then
                r4i181.Text = r4i181.Text + 1
            End If
        End If
        If TimeLeft.Text > 1810 Then
            If TimeLeft.Text <= 1820 Then
                r4i182.Text = r4i182.Text + 1
            End If
        End If
        If TimeLeft.Text > 1820 Then
            If TimeLeft.Text <= 1830 Then
                r4i183.Text = r4i183.Text + 1
            End If
        End If
        If TimeLeft.Text > 1830 Then
            If TimeLeft.Text <= 1840 Then
                r4i184.Text = r4i184.Text + 1
            End If
        End If
        If TimeLeft.Text > 1840 Then
            If TimeLeft.Text <= 1850 Then
                r4i185.Text = r4i185.Text + 1
            End If
        End If
        If TimeLeft.Text > 1850 Then
            If TimeLeft.Text <= 1860 Then
                r4i186.Text = r4i186.Text + 1
            End If
        End If
        If TimeLeft.Text > 1860 Then
            If TimeLeft.Text <= 1870 Then
                r4i187.Text = r4i187.Text + 1
            End If
        End If
        If TimeLeft.Text > 1870 Then
            If TimeLeft.Text <= 1880 Then
                r4i188.Text = r4i188.Text + 1
            End If
        End If
        If TimeLeft.Text > 1880 Then
            If TimeLeft.Text <= 1890 Then
                r4i189.Text = r4i189.Text + 1
            End If
        End If
        If TimeLeft.Text > 1890 Then
            If TimeLeft.Text <= 1900 Then
                r4i190.Text = r4i190.Text + 1
            End If
        End If
        If TimeLeft.Text > 1900 Then
            If TimeLeft.Text <= 1910 Then
                r4i191.Text = r4i191.Text + 1
            End If
        End If
        If TimeLeft.Text > 1910 Then
            If TimeLeft.Text <= 1920 Then
                r4i192.Text = r4i192.Text + 1
            End If
        End If
        If TimeLeft.Text > 1920 Then
            If TimeLeft.Text <= 1930 Then
                r4i193.Text = r4i193.Text + 1
            End If
        End If
        If TimeLeft.Text > 1930 Then
            If TimeLeft.Text <= 1940 Then
                r4i194.Text = r4i194.Text + 1
            End If
        End If
        If TimeLeft.Text > 1940 Then
            If TimeLeft.Text <= 1950 Then
                r4i195.Text = r4i195.Text + 1
            End If
        End If
        If TimeLeft.Text > 1950 Then
            If TimeLeft.Text <= 1960 Then
                r4i196.Text = r4i196.Text + 1
            End If
        End If
        If TimeLeft.Text > 1960 Then
            If TimeLeft.Text <= 1970 Then
                r4i197.Text = r4i197.Text + 1
            End If
        End If
        If TimeLeft.Text > 1970 Then
            If TimeLeft.Text <= 1980 Then
                r4i198.Text = r4i198.Text + 1
            End If
        End If
        If TimeLeft.Text > 1980 Then
            If TimeLeft.Text <= 1990 Then
                r4i199.Text = r4i199.Text + 1
            End If
        End If
        If TimeLeft.Text > 2000 Then
            If TimeLeft.Text <= 2010 Then
                r4i201.Text = r4i201.Text + 1
            End If
        End If
        If TimeLeft.Text > 2010 Then
            If TimeLeft.Text <= 2020 Then
                r4i202.Text = r4i202.Text + 1
            End If
        End If
        If TimeLeft.Text > 2020 Then
            If TimeLeft.Text <= 2030 Then
                r4i203.Text = r4i203.Text + 1
            End If
        End If
        If TimeLeft.Text > 2030 Then
            If TimeLeft.Text <= 2040 Then
                r4i204.Text = r4i204.Text + 1
            End If
        End If
        If TimeLeft.Text > 2040 Then
            If TimeLeft.Text <= 2050 Then
                r4i205.Text = r4i205.Text + 1
            End If
        End If
        If TimeLeft.Text > 2050 Then
            If TimeLeft.Text <= 2060 Then
                r4i206.Text = r4i206.Text + 1
            End If
        End If
        If TimeLeft.Text > 2060 Then
            If TimeLeft.Text <= 2070 Then
                r4i207.Text = r4i207.Text + 1
            End If
        End If
        If TimeLeft.Text > 2070 Then
            If TimeLeft.Text <= 2080 Then
                r4i208.Text = r4i208.Text + 1
            End If
        End If
        If TimeLeft.Text > 2080 Then
            If TimeLeft.Text <= 2090 Then
                r4i209.Text = r4i209.Text + 1
            End If
        End If
        If TimeLeft.Text > 2090 Then
            If TimeLeft.Text <= 2100 Then
                r4i210.Text = r4i210.Text + 1
            End If
        End If
        If TimeLeft.Text > 2100 Then
            If TimeLeft.Text <= 2110 Then
                r4i211.Text = r4i211.Text + 1
            End If
        End If
        If TimeLeft.Text > 2110 Then
            If TimeLeft.Text <= 2120 Then
                r4i212.Text = r4i212.Text + 1
            End If
        End If
        If TimeLeft.Text > 2120 Then
            If TimeLeft.Text <= 2130 Then
                r4i213.Text = r4i213.Text + 1
            End If
        End If
        If TimeLeft.Text > 2130 Then
            If TimeLeft.Text <= 2140 Then
                r4i214.Text = r4i214.Text + 1
            End If
        End If
        If TimeLeft.Text > 2140 Then
            If TimeLeft.Text <= 2150 Then
                r4i215.Text = r4i215.Text + 1
            End If
        End If
        If TimeLeft.Text > 2150 Then
            If TimeLeft.Text <= 2160 Then
                r4i216.Text = r4i216.Text + 1
            End If
        End If
        If TimeLeft.Text > 2160 Then
            If TimeLeft.Text <= 2170 Then
                r4i217.Text = r4i217.Text + 1
            End If
        End If
        If TimeLeft.Text > 2170 Then
            If TimeLeft.Text <= 2180 Then
                r4i218.Text = r4i218.Text + 1
            End If
        End If
        If TimeLeft.Text > 2180 Then
            If TimeLeft.Text <= 2190 Then
                r4i219.Text = r4i219.Text + 1
            End If
        End If
        If TimeLeft.Text > 2190 Then
            If TimeLeft.Text <= 2200 Then
                r4i220.Text = r4i220.Text + 1
            End If
        End If
        If TimeLeft.Text > 2200 Then
            If TimeLeft.Text <= 2210 Then
                r4i221.Text = r4i221.Text + 1
            End If
        End If
        If TimeLeft.Text > 2210 Then
            If TimeLeft.Text <= 2220 Then
                r4i222.Text = r4i222.Text + 1
            End If
        End If
        If TimeLeft.Text > 2220 Then
            If TimeLeft.Text <= 2230 Then
                r4i223.Text = r4i223.Text + 1
            End If
        End If
        If TimeLeft.Text > 2230 Then
            If TimeLeft.Text <= 2240 Then
                r4i224.Text = r4i224.Text + 1
            End If
        End If
        If TimeLeft.Text > 2240 Then
            If TimeLeft.Text <= 2250 Then
                r4i225.Text = r4i225.Text + 1
            End If
        End If
        If TimeLeft.Text > 2250 Then
            If TimeLeft.Text <= 2260 Then
                r4i226.Text = r4i226.Text + 1
            End If
        End If
        If TimeLeft.Text > 2260 Then
            If TimeLeft.Text <= 2270 Then
                r4i227.Text = r4i227.Text + 1
            End If
        End If
        If TimeLeft.Text > 2270 Then
            If TimeLeft.Text <= 2280 Then
                r4i228.Text = r4i228.Text + 1
            End If
        End If
        If TimeLeft.Text > 2280 Then
            If TimeLeft.Text <= 2290 Then
                r4i229.Text = r4i229.Text + 1
            End If
        End If
        If TimeLeft.Text > 2290 Then
            If TimeLeft.Text <= 2300 Then
                r4i230.Text = r4i230.Text + 1
            End If
        End If
        If TimeLeft.Text > 2300 Then
            If TimeLeft.Text <= 2310 Then
                r4i231.Text = r4i231.Text + 1
            End If
        End If
        If TimeLeft.Text > 2310 Then
            If TimeLeft.Text <= 2320 Then
                r4i232.Text = r4i232.Text + 1
            End If
        End If
        If TimeLeft.Text > 2320 Then
            If TimeLeft.Text <= 2330 Then
                r4i233.Text = r4i233.Text + 1
            End If
        End If
        If TimeLeft.Text > 2330 Then
            If TimeLeft.Text <= 2340 Then
                r4i234.Text = r4i234.Text + 1
            End If
        End If
        If TimeLeft.Text > 2340 Then
            If TimeLeft.Text <= 2350 Then
                r4i235.Text = r4i235.Text + 1
            End If
        End If
        If TimeLeft.Text > 2350 Then
            If TimeLeft.Text <= 2360 Then
                r4i236.Text = r4i236.Text + 1
            End If
        End If
        If TimeLeft.Text > 2360 Then
            If TimeLeft.Text <= 2370 Then
                r4i237.Text = r4i237.Text + 1
            End If
        End If
        If TimeLeft.Text > 2370 Then
            If TimeLeft.Text <= 2380 Then
                r4i238.Text = r4i238.Text + 1
            End If
        End If
        If TimeLeft.Text > 2380 Then
            If TimeLeft.Text <= 2390 Then
                r4i239.Text = r4i239.Text + 1
            End If
        End If
        If TimeLeft.Text > 2390 Then
            If TimeLeft.Text <= 2400 Then
                r4i240.Text = r4i240.Text + 1
            End If
        End If
        If TimeLeft.Text > 2400 Then
            If TimeLeft.Text <= 2410 Then
                r4i241.Text = r4i241.Text + 1
            End If
        End If
        If TimeLeft.Text > 2410 Then
            If TimeLeft.Text <= 2420 Then
                r4i242.Text = r4i242.Text + 1
            End If
        End If
        If TimeLeft.Text > 2420 Then
            If TimeLeft.Text <= 2430 Then
                r4i243.Text = r4i243.Text + 1
            End If
        End If
        If TimeLeft.Text > 2430 Then
            If TimeLeft.Text <= 2440 Then
                r4i244.Text = r4i244.Text + 1
            End If
        End If
        If TimeLeft.Text > 2440 Then
            If TimeLeft.Text <= 2450 Then
                r4i245.Text = r4i245.Text + 1
            End If
        End If
        If TimeLeft.Text > 2450 Then
            If TimeLeft.Text <= 2460 Then
                r4i246.Text = r4i246.Text + 1
            End If
        End If
        If TimeLeft.Text > 2460 Then
            If TimeLeft.Text <= 2470 Then
                r4i247.Text = r4i247.Text + 1
            End If
        End If
        If TimeLeft.Text > 2470 Then
            If TimeLeft.Text <= 2480 Then
                r4i248.Text = r4i248.Text + 1
            End If
        End If
        If TimeLeft.Text > 2480 Then
            If TimeLeft.Text <= 2490 Then
                r4i249.Text = r4i249.Text + 1
            End If
        End If
        If TimeLeft.Text > 2490 Then
            If TimeLeft.Text <= 2500 Then
                r4i250.Text = r4i250.Text + 1
            End If
        End If
        If TimeLeft.Text > 2500 Then
            If TimeLeft.Text <= 2510 Then
                r4i251.Text = r4i251.Text + 1
            End If
        End If
        If TimeLeft.Text > 2510 Then
            If TimeLeft.Text <= 2520 Then
                r4i252.Text = r4i252.Text + 1
            End If
        End If
        If TimeLeft.Text > 2520 Then
            If TimeLeft.Text <= 2530 Then
                r4i253.Text = r4i253.Text + 1
            End If
        End If
        If TimeLeft.Text > 2530 Then
            If TimeLeft.Text <= 2540 Then
                r4i254.Text = r4i254.Text + 1
            End If
        End If
        If TimeLeft.Text > 2540 Then
            If TimeLeft.Text <= 2550 Then
                r4i255.Text = r4i255.Text + 1
            End If
        End If
        If TimeLeft.Text > 2550 Then
            If TimeLeft.Text <= 2560 Then
                r4i256.Text = r4i256.Text + 1
            End If
        End If
        If TimeLeft.Text > 2560 Then
            If TimeLeft.Text <= 2570 Then
                r4i257.Text = r4i257.Text + 1
            End If
        End If
        If TimeLeft.Text > 2570 Then
            If TimeLeft.Text <= 2580 Then
                r4i258.Text = r4i258.Text + 1
            End If
        End If
        If TimeLeft.Text > 2580 Then
            If TimeLeft.Text <= 2590 Then
                r4i259.Text = r4i259.Text + 1
            End If
        End If
        If TimeLeft.Text > 2590 Then
            If TimeLeft.Text <= 2600 Then
                r4i260.Text = r4i260.Text + 1
            End If
        End If
        If TimeLeft.Text > 2600 Then
            If TimeLeft.Text <= 2610 Then
                r4i261.Text = r4i261.Text + 1
            End If
        End If
        If TimeLeft.Text > 2610 Then
            If TimeLeft.Text <= 2620 Then
                r4i262.Text = r4i262.Text + 1
            End If
        End If
        If TimeLeft.Text > 2620 Then
            If TimeLeft.Text <= 2630 Then
                r4i263.Text = r4i263.Text + 1
            End If
        End If
        If TimeLeft.Text > 2630 Then
            If TimeLeft.Text <= 2640 Then
                r4i264.Text = r4i264.Text + 1
            End If
        End If
        If TimeLeft.Text > 2640 Then
            If TimeLeft.Text <= 2650 Then
                r4i265.Text = r4i265.Text + 1
            End If
        End If
        If TimeLeft.Text > 2650 Then
            If TimeLeft.Text <= 2660 Then
                r4i266.Text = r4i266.Text + 1
            End If
        End If
        If TimeLeft.Text > 2660 Then
            If TimeLeft.Text <= 2670 Then
                r4i267.Text = r4i267.Text + 1
            End If
        End If
        If TimeLeft.Text > 2670 Then
            If TimeLeft.Text <= 2680 Then
                r4i268.Text = r4i268.Text + 1
            End If
        End If
        If TimeLeft.Text > 2680 Then
            If TimeLeft.Text <= 2690 Then
                r4i269.Text = r4i269.Text + 1
            End If
        End If
        If TimeLeft.Text > 2690 Then
            If TimeLeft.Text <= 2700 Then
                r4i270.Text = r4i270.Text + 1
            End If
        End If
        If TimeLeft.Text > 2700 Then
            If TimeLeft.Text <= 2710 Then
                r4i271.Text = r4i271.Text + 1
            End If
        End If
        If TimeLeft.Text > 2710 Then
            If TimeLeft.Text <= 2720 Then
                r4i272.Text = r4i272.Text + 1
            End If
        End If
        If TimeLeft.Text > 2720 Then
            If TimeLeft.Text <= 2730 Then
                r4i273.Text = r4i273.Text + 1
            End If
        End If
        If TimeLeft.Text > 2730 Then
            If TimeLeft.Text <= 2740 Then
                r4i274.Text = r4i274.Text + 1
            End If
        End If
        If TimeLeft.Text > 2740 Then
            If TimeLeft.Text <= 2750 Then
                r4i275.Text = r4i275.Text + 1
            End If
        End If
        If TimeLeft.Text > 2750 Then
            If TimeLeft.Text <= 2760 Then
                r4i276.Text = r4i276.Text + 1
            End If
        End If
        If TimeLeft.Text > 2760 Then
            If TimeLeft.Text <= 2770 Then
                r4i277.Text = r4i277.Text + 1
            End If
        End If
        If TimeLeft.Text > 2770 Then
            If TimeLeft.Text <= 2780 Then
                r4i278.Text = r4i278.Text + 1
            End If
        End If
        If TimeLeft.Text > 2780 Then
            If TimeLeft.Text <= 2790 Then
                r4i279.Text = r4i279.Text + 1
            End If
        End If
        If TimeLeft.Text > 2790 Then
            If TimeLeft.Text <= 2800 Then
                r4i281.Text = r4i280.Text + 1
            End If
        End If
        If TimeLeft.Text > 2800 Then
            If TimeLeft.Text <= 2810 Then
                r4i281.Text = r4i281.Text + 1
            End If
        End If
        If TimeLeft.Text > 2810 Then
            If TimeLeft.Text <= 2820 Then
                r4i282.Text = r4i282.Text + 1
            End If
        End If
        If TimeLeft.Text > 2820 Then
            If TimeLeft.Text <= 2830 Then
                r4i283.Text = r4i283.Text + 1
            End If
        End If
        If TimeLeft.Text > 2830 Then
            If TimeLeft.Text <= 2840 Then
                r4i284.Text = r4i284.Text + 1
            End If
        End If
        If TimeLeft.Text > 2840 Then
            If TimeLeft.Text <= 2850 Then
                r4i285.Text = r4i285.Text + 1
            End If
        End If
        If TimeLeft.Text > 2850 Then
            If TimeLeft.Text <= 2860 Then
                r4i286.Text = r4i286.Text + 1
            End If
        End If
        If TimeLeft.Text > 2860 Then
            If TimeLeft.Text <= 2870 Then
                r4i287.Text = r4i287.Text + 1
            End If
        End If
        If TimeLeft.Text > 2870 Then
            If TimeLeft.Text <= 2880 Then
                r4i288.Text = r4i288.Text + 1
            End If
        End If

    End Sub

    'Code for alternative three response. 
    Private Sub r0501_Click(sender As Object, e As EventArgs) Handles r0501.Click
        r0501.Visible = False
        r0502.Visible = True
        r0101.Visible = True
        r0102.Visible = False
        r0103.Visible = False
        r0104.Visible = False
        r0105.Visible = False
        r0106.Visible = False
        r0201.Visible = True
        r0202.Visible = False
        r0203.Visible = False
        r0204.Visible = False
        r0205.Visible = False
        r0206.Visible = False
        r0301.Visible = True
        r0302.Visible = False
        r0303.Visible = False
        r0304.Visible = False
        r0305.Visible = False
        r0306.Visible = False
        r0401.Visible = True
        r0402.Visible = False
        r0403.Visible = False
        r0404.Visible = False
        r0405.Visible = False
        r0406.Visible = False
        r0601.Visible = True
        r0602.Visible = False
        r0603.Visible = False
        r0604.Visible = False
        r0605.Visible = False
        r0606.Visible = False
    End Sub
    Private Sub r0502_Click(sender As Object, e As EventArgs) Handles r0502.Click
        r0502.Visible = False
        r0503.Visible = True
    End Sub
    Private Sub r0503_Click(sender As Object, e As EventArgs) Handles r0503.Click
        r0503.Visible = False
        r0504.Visible = True
    End Sub
    Private Sub r0504_Click(sender As Object, e As EventArgs) Handles r0504.Click
        r0504.Visible = False
        r0505.Visible = True
    End Sub
    Private Sub r0505_Click(sender As Object, e As EventArgs) Handles r0505.Click
        r0505.Visible = False
        r0506.Visible = True
    End Sub
    Private Sub r0506_Click(sender As Object, e As EventArgs) Handles r0506.Click
        r0506.Visible = False
        r0501.Visible = True
        'Code for changeover (CO) response. That is, the first response following switching cannot contact reinforcement. 
        If r5CO.Text < 2 Then
            r5CO.Text = Val(r5CO.Text) + 1
            r1CO.Text = 0
            r2CO.Text = 0
            r3CO.Text = 0
            r4CO.Text = 0
            r6CO.Text = 0
        End If
        If r5CO.Text = 2 Then
            If r5VIval.Text = 0 Then
                pointText.Visible = True
                consumResp.Visible = True
                Alt3TimeDeliver.Text = Alt3TimeDeliver.Text + TimeLeft.Text + ","
            End If
        End If
        'Code for count per 2-min session. 
        If TimeLeft.Text > 0 Then
            If TimeLeft.Text <= 120 Then
                r5sess1.Text = r5sess1.Text + 1
            End If
        End If
        If TimeLeft.Text > 120 Then
            If TimeLeft.Text <= 240 Then
                r5sess2.Text = r5sess2.Text + 1
            End If
        End If
        If TimeLeft.Text > 240 Then
            If TimeLeft.Text <= 360 Then
                r5sess3.Text = r5sess3.Text + 1
            End If
        End If
        If TimeLeft.Text > 360 Then
            If TimeLeft.Text <= 480 Then
                r5sess4.Text = r5sess4.Text + 1
            End If
        End If
        If TimeLeft.Text > 480 Then
            If TimeLeft.Text <= 600 Then
                r5sess5.Text = r5sess5.Text + 1
            End If
        End If
        If TimeLeft.Text > 600 Then
            If TimeLeft.Text <= 720 Then
                r5sess6.Text = r5sess6.Text + 1
            End If
        End If
        If TimeLeft.Text > 720 Then
            If TimeLeft.Text <= 840 Then
                r5sess7.Text = r5sess7.Text + 1
            End If
        End If
        If TimeLeft.Text > 840 Then
            If TimeLeft.Text <= 960 Then
                r5sess8.Text = r5sess8.Text + 1
            End If
        End If
        If TimeLeft.Text > 960 Then
            If TimeLeft.Text <= 1080 Then
                r5sess9.Text = r5sess9.Text + 1
            End If
        End If
        If TimeLeft.Text > 1080 Then
            If TimeLeft.Text <= 1200 Then
                r5sess10.Text = r5sess10.Text + 1
            End If
        End If
        If TimeLeft.Text > 1200 Then
            If TimeLeft.Text <= 1320 Then
                r5sess11.Text = r5sess11.Text + 1
            End If
        End If
        If TimeLeft.Text > 1320 Then
            If TimeLeft.Text <= 1440 Then
                r5sess12.Text = r5sess12.Text + 1
            End If
        End If
        If TimeLeft.Text > 1440 Then
            If TimeLeft.Text <= 1560 Then
                r5sess13.Text = r5sess13.Text + 1
            End If
        End If
        If TimeLeft.Text > 1560 Then
            If TimeLeft.Text <= 1680 Then
                r5sess14.Text = r5sess14.Text + 1
            End If
        End If
        If TimeLeft.Text > 1680 Then
            If TimeLeft.Text <= 1800 Then
                r5sess15.Text = r5sess15.Text + 1
            End If
        End If
        If TimeLeft.Text > 1800 Then
            If TimeLeft.Text <= 1920 Then
                r5sess16.Text = r5sess16.Text + 1
            End If
        End If
        If TimeLeft.Text > 1920 Then
            If TimeLeft.Text <= 2040 Then
                r5sess17.Text = r5sess17.Text + 1
            End If
        End If
        If TimeLeft.Text > 2040 Then
            If TimeLeft.Text <= 2160 Then
                r5sess18.Text = r5sess18.Text + 1
            End If
        End If
        If TimeLeft.Text > 2160 Then
            If TimeLeft.Text <= 2280 Then
                r5sess19.Text = r5sess19.Text + 1
            End If
        End If
        If TimeLeft.Text > 2280 Then
            If TimeLeft.Text <= 2400 Then
                r5sess20.Text = r5sess20.Text + 1
            End If
        End If
        If TimeLeft.Text > 2400 Then
            If TimeLeft.Text <= 2520 Then
                r5sess21.Text = r5sess21.Text + 1
            End If
        End If
        If TimeLeft.Text > 2520 Then
            If TimeLeft.Text <= 2640 Then
                r5sess22.Text = r5sess22.Text + 1
            End If
        End If
        If TimeLeft.Text > 2640 Then
            If TimeLeft.Text <= 2760 Then
                r5sess23.Text = r5sess23.Text + 1
            End If
        End If
        If TimeLeft.Text > 2760 Then
            If TimeLeft.Text <= 2880 Then
                r5sess24.Text = r5sess24.Text + 1
            End If
        End If


        'Code for count per 10-sec interval.
        If TimeLeft.Text > 0 Then
            If TimeLeft.Text <= 10 Then
                r5i01.Text = r5i01.Text + 1
            End If
        End If
        If TimeLeft.Text > 10 Then
            If TimeLeft.Text <= 20 Then
                r5i02.Text = r5i02.Text + 1
            End If
        End If
        If TimeLeft.Text > 20 Then
            If TimeLeft.Text <= 30 Then
                r5i03.Text = r5i03.Text + 1
            End If
        End If
        If TimeLeft.Text > 30 Then
            If TimeLeft.Text <= 40 Then
                r5i04.Text = r5i04.Text + 1
            End If
        End If
        If TimeLeft.Text > 40 Then
            If TimeLeft.Text <= 50 Then
                r5i05.Text = r5i05.Text + 1
            End If
        End If
        If TimeLeft.Text > 50 Then
            If TimeLeft.Text <= 60 Then
                r5i06.Text = r5i06.Text + 1
            End If
        End If
        If TimeLeft.Text > 60 Then
            If TimeLeft.Text <= 70 Then
                r5i07.Text = r5i07.Text + 1
            End If
        End If
        If TimeLeft.Text > 70 Then
            If TimeLeft.Text <= 80 Then
                r5i08.Text = r5i08.Text + 1
            End If
        End If
        If TimeLeft.Text > 80 Then
            If TimeLeft.Text <= 90 Then
                r5i09.Text = r5i09.Text + 1
            End If
        End If
        If TimeLeft.Text > 90 Then
            If TimeLeft.Text <= 100 Then
                r5i10.Text = r5i10.Text + 1
            End If
        End If
        If TimeLeft.Text > 100 Then
            If TimeLeft.Text <= 110 Then
                r5i11.Text = r5i11.Text + 1
            End If
        End If
        If TimeLeft.Text > 110 Then
            If TimeLeft.Text <= 120 Then
                r5i12.Text = r5i12.Text + 1
            End If
        End If
        If TimeLeft.Text > 120 Then
            If TimeLeft.Text <= 130 Then
                r5i13.Text = r5i13.Text + 1
            End If
        End If
        If TimeLeft.Text > 130 Then
            If TimeLeft.Text <= 140 Then
                r5i14.Text = r5i14.Text + 1
            End If
        End If
        If TimeLeft.Text > 140 Then
            If TimeLeft.Text <= 150 Then
                r5i15.Text = r5i15.Text + 1
            End If
        End If
        If TimeLeft.Text > 150 Then
            If TimeLeft.Text <= 160 Then
                r5i16.Text = r5i16.Text + 1
            End If
        End If
        If TimeLeft.Text > 160 Then
            If TimeLeft.Text <= 170 Then
                r5i17.Text = r5i17.Text + 1
            End If
        End If
        If TimeLeft.Text > 170 Then
            If TimeLeft.Text <= 180 Then
                r5i18.Text = r5i18.Text + 1
            End If
        End If
        If TimeLeft.Text > 180 Then
            If TimeLeft.Text <= 190 Then
                r5i19.Text = r5i19.Text + 1
            End If
        End If
        If TimeLeft.Text > 190 Then
            If TimeLeft.Text <= 200 Then
                r5i20.Text = r5i20.Text + 1
            End If
        End If
        If TimeLeft.Text > 200 Then
            If TimeLeft.Text <= 210 Then
                r5i21.Text = r5i21.Text + 1
            End If
        End If
        If TimeLeft.Text > 210 Then
            If TimeLeft.Text <= 220 Then
                r5i22.Text = r5i22.Text + 1
            End If
        End If
        If TimeLeft.Text > 220 Then
            If TimeLeft.Text <= 230 Then
                r5i23.Text = r5i23.Text + 1
            End If
        End If
        If TimeLeft.Text > 230 Then
            If TimeLeft.Text <= 240 Then
                r5i24.Text = r5i24.Text + 1
            End If
        End If
        If TimeLeft.Text > 240 Then
            If TimeLeft.Text <= 250 Then
                r5i25.Text = r5i25.Text + 1
            End If
        End If
        If TimeLeft.Text > 250 Then
            If TimeLeft.Text <= 260 Then
                r5i26.Text = r5i26.Text + 1
            End If
        End If
        If TimeLeft.Text > 260 Then
            If TimeLeft.Text <= 270 Then
                r5i27.Text = r5i27.Text + 1
            End If
        End If
        If TimeLeft.Text > 270 Then
            If TimeLeft.Text <= 280 Then
                r5i28.Text = r5i28.Text + 1
            End If
        End If
        If TimeLeft.Text > 280 Then
            If TimeLeft.Text <= 290 Then
                r5i29.Text = r5i29.Text + 1
            End If
        End If
        If TimeLeft.Text > 290 Then
            If TimeLeft.Text <= 300 Then
                r5i30.Text = r5i30.Text + 1
            End If
        End If
        If TimeLeft.Text > 300 Then
            If TimeLeft.Text <= 310 Then
                r5i31.Text = r5i31.Text + 1
            End If
        End If
        If TimeLeft.Text > 310 Then
            If TimeLeft.Text <= 320 Then
                r5i32.Text = r5i32.Text + 1
            End If
        End If
        If TimeLeft.Text > 320 Then
            If TimeLeft.Text <= 330 Then
                r5i33.Text = r5i33.Text + 1
            End If
        End If
        If TimeLeft.Text > 330 Then
            If TimeLeft.Text <= 340 Then
                r5i34.Text = r5i34.Text + 1
            End If
        End If
        If TimeLeft.Text > 340 Then
            If TimeLeft.Text <= 350 Then
                r5i35.Text = r5i35.Text + 1
            End If
        End If
        If TimeLeft.Text > 350 Then
            If TimeLeft.Text <= 360 Then
                r5i36.Text = r5i36.Text + 1
            End If
        End If
        If TimeLeft.Text > 360 Then
            If TimeLeft.Text <= 370 Then
                r5i37.Text = r5i37.Text + 1
            End If
        End If
        If TimeLeft.Text > 370 Then
            If TimeLeft.Text <= 380 Then
                r5i38.Text = r5i38.Text + 1
            End If
        End If
        If TimeLeft.Text > 380 Then
            If TimeLeft.Text <= 390 Then
                r5i39.Text = r5i39.Text + 1
            End If
        End If
        If TimeLeft.Text > 390 Then
            If TimeLeft.Text <= 400 Then
                r5i40.Text = r5i40.Text + 1
            End If
        End If
        If TimeLeft.Text > 400 Then
            If TimeLeft.Text <= 410 Then
                r5i41.Text = r5i41.Text + 1
            End If
        End If
        If TimeLeft.Text > 410 Then
            If TimeLeft.Text <= 420 Then
                r5i42.Text = r5i42.Text + 1
            End If
        End If
        If TimeLeft.Text > 420 Then
            If TimeLeft.Text <= 430 Then
                r5i43.Text = r5i43.Text + 1
            End If
        End If
        If TimeLeft.Text > 430 Then
            If TimeLeft.Text <= 440 Then
                r5i44.Text = r5i44.Text + 1
            End If
        End If
        If TimeLeft.Text > 440 Then
            If TimeLeft.Text <= 450 Then
                r5i45.Text = r5i45.Text + 1
            End If
        End If
        If TimeLeft.Text > 450 Then
            If TimeLeft.Text <= 460 Then
                r5i46.Text = r5i46.Text + 1
            End If
        End If
        If TimeLeft.Text > 460 Then
            If TimeLeft.Text <= 470 Then
                r5i47.Text = r5i47.Text + 1
            End If
        End If
        If TimeLeft.Text > 470 Then
            If TimeLeft.Text <= 480 Then
                r5i48.Text = r5i48.Text + 1
            End If
        End If
        If TimeLeft.Text > 480 Then
            If TimeLeft.Text <= 490 Then
                r5i49.Text = r5i49.Text + 1
            End If
        End If
        If TimeLeft.Text > 490 Then
            If TimeLeft.Text <= 500 Then
                r5i50.Text = r5i50.Text + 1
            End If
        End If
        If TimeLeft.Text > 500 Then
            If TimeLeft.Text <= 510 Then
                r5i51.Text = r5i51.Text + 1
            End If
        End If
        If TimeLeft.Text > 510 Then
            If TimeLeft.Text <= 520 Then
                r5i52.Text = r5i52.Text + 1
            End If
        End If
        If TimeLeft.Text > 520 Then
            If TimeLeft.Text <= 530 Then
                r5i53.Text = r5i53.Text + 1
            End If
        End If
        If TimeLeft.Text > 530 Then
            If TimeLeft.Text <= 540 Then
                r5i54.Text = r5i54.Text + 1
            End If
        End If
        If TimeLeft.Text > 540 Then
            If TimeLeft.Text <= 550 Then
                r5i55.Text = r5i55.Text + 1
            End If
        End If
        If TimeLeft.Text > 550 Then
            If TimeLeft.Text <= 560 Then
                r5i56.Text = r5i56.Text + 1
            End If
        End If
        If TimeLeft.Text > 560 Then
            If TimeLeft.Text <= 570 Then
                r5i57.Text = r5i57.Text + 1
            End If
        End If
        If TimeLeft.Text > 570 Then
            If TimeLeft.Text <= 580 Then
                r5i58.Text = r5i58.Text + 1
            End If
        End If
        If TimeLeft.Text > 580 Then
            If TimeLeft.Text <= 590 Then
                r5i59.Text = r5i59.Text + 1
            End If
        End If
        If TimeLeft.Text > 590 Then
            If TimeLeft.Text <= 600 Then
                r5i60.Text = r5i60.Text + 1
            End If
        End If
        If TimeLeft.Text > 600 Then
            If TimeLeft.Text <= 610 Then
                r5i61.Text = r5i61.Text + 1
            End If
        End If
        If TimeLeft.Text > 610 Then
            If TimeLeft.Text <= 620 Then
                r5i62.Text = r5i62.Text + 1
            End If
        End If
        If TimeLeft.Text > 620 Then
            If TimeLeft.Text <= 630 Then
                r5i63.Text = r5i63.Text + 1
            End If
        End If
        If TimeLeft.Text > 630 Then
            If TimeLeft.Text <= 640 Then
                r5i64.Text = r5i64.Text + 1
            End If
        End If
        If TimeLeft.Text > 640 Then
            If TimeLeft.Text <= 650 Then
                r5i65.Text = r5i65.Text + 1
            End If
        End If
        If TimeLeft.Text > 650 Then
            If TimeLeft.Text <= 660 Then
                r5i66.Text = r5i66.Text + 1
            End If
        End If
        If TimeLeft.Text > 660 Then
            If TimeLeft.Text <= 670 Then
                r5i67.Text = r5i67.Text + 1
            End If
        End If
        If TimeLeft.Text > 670 Then
            If TimeLeft.Text <= 680 Then
                r5i68.Text = r5i68.Text + 1
            End If
        End If
        If TimeLeft.Text > 680 Then
            If TimeLeft.Text <= 690 Then
                r5i69.Text = r5i69.Text + 1
            End If
        End If
        If TimeLeft.Text > 690 Then
            If TimeLeft.Text <= 700 Then
                r5i70.Text = r5i70.Text + 1
            End If
        End If
        If TimeLeft.Text > 700 Then
            If TimeLeft.Text <= 710 Then
                r5i71.Text = r5i71.Text + 1
            End If
        End If
        If TimeLeft.Text > 710 Then
            If TimeLeft.Text <= 720 Then
                r5i72.Text = r5i72.Text + 1
            End If
        End If
        If TimeLeft.Text > 720 Then
            If TimeLeft.Text <= 730 Then
                r5i73.Text = r5i73.Text + 1
            End If
        End If
        If TimeLeft.Text > 730 Then
            If TimeLeft.Text <= 740 Then
                r5i74.Text = r5i74.Text + 1
            End If
        End If
        If TimeLeft.Text > 740 Then
            If TimeLeft.Text <= 750 Then
                r5i75.Text = r5i75.Text + 1
            End If
        End If
        If TimeLeft.Text > 750 Then
            If TimeLeft.Text <= 760 Then
                r5i76.Text = r5i76.Text + 1
            End If
        End If
        If TimeLeft.Text > 760 Then
            If TimeLeft.Text <= 770 Then
                r5i77.Text = r5i77.Text + 1
            End If
        End If
        If TimeLeft.Text > 770 Then
            If TimeLeft.Text <= 780 Then
                r5i78.Text = r5i78.Text + 1
            End If
        End If
        If TimeLeft.Text > 780 Then
            If TimeLeft.Text <= 790 Then
                r5i79.Text = r5i79.Text + 1
            End If
        End If
        If TimeLeft.Text > 790 Then
            If TimeLeft.Text <= 800 Then
                r5i80.Text = r5i80.Text + 1
            End If
        End If
        If TimeLeft.Text > 800 Then
            If TimeLeft.Text <= 810 Then
                r5i81.Text = r5i81.Text + 1
            End If
        End If
        If TimeLeft.Text > 810 Then
            If TimeLeft.Text <= 820 Then
                r5i82.Text = r5i82.Text + 1
            End If
        End If
        If TimeLeft.Text > 820 Then
            If TimeLeft.Text <= 830 Then
                r5i83.Text = r5i83.Text + 1
            End If
        End If
        If TimeLeft.Text > 830 Then
            If TimeLeft.Text <= 840 Then
                r5i84.Text = r5i84.Text + 1
            End If
        End If
        If TimeLeft.Text > 840 Then
            If TimeLeft.Text <= 850 Then
                r5i85.Text = r5i85.Text + 1
            End If
        End If
        If TimeLeft.Text > 850 Then
            If TimeLeft.Text <= 860 Then
                r5i86.Text = r5i86.Text + 1
            End If
        End If
        If TimeLeft.Text > 860 Then
            If TimeLeft.Text <= 870 Then
                r5i87.Text = r5i87.Text + 1
            End If
        End If
        If TimeLeft.Text > 870 Then
            If TimeLeft.Text <= 880 Then
                r5i88.Text = r5i88.Text + 1
            End If
        End If
        If TimeLeft.Text > 880 Then
            If TimeLeft.Text <= 890 Then
                r5i89.Text = r5i89.Text + 1
            End If
        End If
        If TimeLeft.Text > 890 Then
            If TimeLeft.Text <= 900 Then
                r5i90.Text = r5i90.Text + 1
            End If
        End If
        If TimeLeft.Text > 900 Then
            If TimeLeft.Text <= 910 Then
                r5i91.Text = r5i91.Text + 1
            End If
        End If
        If TimeLeft.Text > 910 Then
            If TimeLeft.Text <= 920 Then
                r5i92.Text = r5i92.Text + 1
            End If
        End If
        If TimeLeft.Text > 920 Then
            If TimeLeft.Text <= 930 Then
                r5i93.Text = r5i93.Text + 1
            End If
        End If
        If TimeLeft.Text > 930 Then
            If TimeLeft.Text <= 940 Then
                r5i94.Text = r5i94.Text + 1
            End If
        End If
        If TimeLeft.Text > 940 Then
            If TimeLeft.Text <= 950 Then
                r5i95.Text = r5i95.Text + 1
            End If
        End If
        If TimeLeft.Text > 950 Then
            If TimeLeft.Text <= 960 Then
                r5i96.Text = r5i96.Text + 1
            End If
        End If
        If TimeLeft.Text > 960 Then
            If TimeLeft.Text <= 970 Then
                r5i97.Text = r5i97.Text + 1
            End If
        End If
        If TimeLeft.Text > 970 Then
            If TimeLeft.Text <= 980 Then
                r5i98.Text = r5i98.Text + 1
            End If
        End If
        If TimeLeft.Text > 980 Then
            If TimeLeft.Text <= 990 Then
                r5i99.Text = r5i99.Text + 1
            End If
        End If
        If TimeLeft.Text > 990 Then
            If TimeLeft.Text <= 1000 Then
                r5i100.Text = r5i100.Text + 1
            End If
        End If
        If TimeLeft.Text > 1000 Then
            If TimeLeft.Text <= 1010 Then
                r5i101.Text = r5i101.Text + 1
            End If
        End If
        If TimeLeft.Text > 1010 Then
            If TimeLeft.Text <= 1020 Then
                r5i102.Text = r5i102.Text + 1
            End If
        End If
        If TimeLeft.Text > 1020 Then
            If TimeLeft.Text <= 1030 Then
                r5i103.Text = r5i103.Text + 1
            End If
        End If
        If TimeLeft.Text > 1030 Then
            If TimeLeft.Text <= 1040 Then
                r5i104.Text = r5i104.Text + 1
            End If
        End If
        If TimeLeft.Text > 1040 Then
            If TimeLeft.Text <= 1050 Then
                r5i105.Text = r5i105.Text + 1
            End If
        End If
        If TimeLeft.Text > 1050 Then
            If TimeLeft.Text <= 1060 Then
                r5i106.Text = r5i106.Text + 1
            End If
        End If
        If TimeLeft.Text > 1060 Then
            If TimeLeft.Text <= 1070 Then
                r5i107.Text = r5i107.Text + 1
            End If
        End If
        If TimeLeft.Text > 1070 Then
            If TimeLeft.Text <= 1080 Then
                r5i108.Text = r5i108.Text + 1
            End If
        End If
        If TimeLeft.Text > 1080 Then
            If TimeLeft.Text <= 1090 Then
                r5i109.Text = r5i109.Text + 1
            End If
        End If
        If TimeLeft.Text > 1090 Then
            If TimeLeft.Text <= 1100 Then
                r5i200.Text = r5i200.Text + 1
            End If
        End If
        If TimeLeft.Text > 1100 Then
            If TimeLeft.Text <= 1110 Then
                r5i111.Text = r5i111.Text + 1
            End If
        End If
        If TimeLeft.Text > 1110 Then
            If TimeLeft.Text <= 1120 Then
                r5i112.Text = r5i112.Text + 1
            End If
        End If
        If TimeLeft.Text > 1120 Then
            If TimeLeft.Text <= 1130 Then
                r5i113.Text = r5i113.Text + 1
            End If
        End If
        If TimeLeft.Text > 1130 Then
            If TimeLeft.Text <= 1140 Then
                r5i114.Text = r5i114.Text + 1
            End If
        End If
        If TimeLeft.Text > 1140 Then
            If TimeLeft.Text <= 1150 Then
                r5i115.Text = r5i115.Text + 1
            End If
        End If
        If TimeLeft.Text > 1150 Then
            If TimeLeft.Text <= 1160 Then
                r5i116.Text = r5i116.Text + 1
            End If
        End If
        If TimeLeft.Text > 1160 Then
            If TimeLeft.Text <= 1170 Then
                r5i117.Text = r5i117.Text + 1
            End If
        End If
        If TimeLeft.Text > 1170 Then
            If TimeLeft.Text <= 1180 Then
                r5i118.Text = r5i118.Text + 1
            End If
        End If
        If TimeLeft.Text > 1180 Then
            If TimeLeft.Text <= 1190 Then
                r5i119.Text = r5i119.Text + 1
            End If
        End If
        If TimeLeft.Text > 1190 Then
            If TimeLeft.Text <= 1200 Then
                r5i120.Text = r5i120.Text + 1
            End If
        End If
        If TimeLeft.Text > 1200 Then
            If TimeLeft.Text <= 1210 Then
                r5i121.Text = r5i121.Text + 1
            End If
        End If
        If TimeLeft.Text > 1210 Then
            If TimeLeft.Text <= 1220 Then
                r5i122.Text = r5i122.Text + 1
            End If
        End If
        If TimeLeft.Text > 1220 Then
            If TimeLeft.Text <= 1230 Then
                r5i123.Text = r5i123.Text + 1
            End If
        End If
        If TimeLeft.Text > 1230 Then
            If TimeLeft.Text <= 1240 Then
                r5i124.Text = r5i124.Text + 1
            End If
        End If
        If TimeLeft.Text > 1240 Then
            If TimeLeft.Text <= 1250 Then
                r5i125.Text = r5i125.Text + 1
            End If
        End If
        If TimeLeft.Text > 1250 Then
            If TimeLeft.Text <= 1260 Then
                r5i126.Text = r5i126.Text + 1
            End If
        End If
        If TimeLeft.Text > 1260 Then
            If TimeLeft.Text <= 1270 Then
                r5i127.Text = r5i127.Text + 1
            End If
        End If
        If TimeLeft.Text > 1270 Then
            If TimeLeft.Text <= 1280 Then
                r5i128.Text = r5i128.Text + 1
            End If
        End If
        If TimeLeft.Text > 1280 Then
            If TimeLeft.Text <= 1290 Then
                r5i129.Text = r5i129.Text + 1
            End If
        End If
        If TimeLeft.Text > 1290 Then
            If TimeLeft.Text <= 1300 Then
                r5i130.Text = r5i130.Text + 1
            End If
        End If
        If TimeLeft.Text > 1300 Then
            If TimeLeft.Text <= 1310 Then
                r5i131.Text = r5i131.Text + 1
            End If
        End If
        If TimeLeft.Text > 1310 Then
            If TimeLeft.Text <= 1320 Then
                r5i132.Text = r5i132.Text + 1
            End If
        End If
        If TimeLeft.Text > 1320 Then
            If TimeLeft.Text <= 1330 Then
                r5i133.Text = r5i133.Text + 1
            End If
        End If
        If TimeLeft.Text > 1330 Then
            If TimeLeft.Text <= 1340 Then
                r5i134.Text = r5i134.Text + 1
            End If
        End If
        If TimeLeft.Text > 1340 Then
            If TimeLeft.Text <= 1350 Then
                r5i135.Text = r5i135.Text + 1
            End If
        End If
        If TimeLeft.Text > 1350 Then
            If TimeLeft.Text <= 1360 Then
                r5i136.Text = r5i136.Text + 1
            End If
        End If
        If TimeLeft.Text > 1360 Then
            If TimeLeft.Text <= 1370 Then
                r5i137.Text = r5i137.Text + 1
            End If
        End If
        If TimeLeft.Text > 1370 Then
            If TimeLeft.Text <= 1380 Then
                r5i138.Text = r5i138.Text + 1
            End If
        End If
        If TimeLeft.Text > 1380 Then
            If TimeLeft.Text <= 1390 Then
                r5i139.Text = r5i139.Text + 1
            End If
        End If
        If TimeLeft.Text > 1390 Then
            If TimeLeft.Text <= 1400 Then
                r5i140.Text = r5i140.Text + 1
            End If
        End If
        If TimeLeft.Text > 1400 Then
            If TimeLeft.Text <= 1410 Then
                r5i141.Text = r5i141.Text + 1
            End If
        End If
        If TimeLeft.Text > 1410 Then
            If TimeLeft.Text <= 1420 Then
                r5i142.Text = r5i142.Text + 1
            End If
        End If
        If TimeLeft.Text > 1420 Then
            If TimeLeft.Text <= 1430 Then
                r5i143.Text = r5i143.Text + 1
            End If
        End If
        If TimeLeft.Text > 1430 Then
            If TimeLeft.Text <= 1440 Then
                r5i144.Text = r5i144.Text + 1
            End If
        End If
        If TimeLeft.Text > 1440 Then
            If TimeLeft.Text <= 1450 Then
                r5i145.Text = r5i145.Text + 1
            End If
        End If
        If TimeLeft.Text > 1450 Then
            If TimeLeft.Text <= 1460 Then
                r5i146.Text = r5i146.Text + 1
            End If
        End If
        If TimeLeft.Text > 1460 Then
            If TimeLeft.Text <= 1470 Then
                r5i147.Text = r5i147.Text + 1
            End If
        End If
        If TimeLeft.Text > 1470 Then
            If TimeLeft.Text <= 1480 Then
                r5i148.Text = r5i148.Text + 1
            End If
        End If
        If TimeLeft.Text > 1480 Then
            If TimeLeft.Text <= 1490 Then
                r5i149.Text = r5i149.Text + 1
            End If
        End If
        If TimeLeft.Text > 1490 Then
            If TimeLeft.Text <= 1500 Then
                r5i150.Text = r5i150.Text + 1
            End If
        End If
        If TimeLeft.Text > 1500 Then
            If TimeLeft.Text <= 1510 Then
                r5i151.Text = r5i151.Text + 1
            End If
        End If
        If TimeLeft.Text > 1510 Then
            If TimeLeft.Text <= 1520 Then
                r5i152.Text = r5i152.Text + 1
            End If
        End If
        If TimeLeft.Text > 1520 Then
            If TimeLeft.Text <= 1530 Then
                r5i153.Text = r5i153.Text + 1
            End If
        End If
        If TimeLeft.Text > 1530 Then
            If TimeLeft.Text <= 1540 Then
                r5i154.Text = r5i154.Text + 1
            End If
        End If
        If TimeLeft.Text > 1540 Then
            If TimeLeft.Text <= 1550 Then
                r5i155.Text = r5i155.Text + 1
            End If
        End If
        If TimeLeft.Text > 1550 Then
            If TimeLeft.Text <= 1560 Then
                r5i156.Text = r5i156.Text + 1
            End If
        End If
        If TimeLeft.Text > 1560 Then
            If TimeLeft.Text <= 1570 Then
                r5i157.Text = r5i157.Text + 1
            End If
        End If
        If TimeLeft.Text > 1570 Then
            If TimeLeft.Text <= 1580 Then
                r5i158.Text = r5i158.Text + 1
            End If
        End If
        If TimeLeft.Text > 1580 Then
            If TimeLeft.Text <= 1590 Then
                r5i159.Text = r5i159.Text + 1
            End If
        End If
        If TimeLeft.Text > 1590 Then
            If TimeLeft.Text <= 1600 Then
                r5i160.Text = r5i160.Text + 1
            End If
        End If
        If TimeLeft.Text > 1600 Then
            If TimeLeft.Text <= 1610 Then
                r5i161.Text = r5i161.Text + 1
            End If
        End If
        If TimeLeft.Text > 1610 Then
            If TimeLeft.Text <= 1620 Then
                r5i162.Text = r5i162.Text + 1
            End If
        End If
        If TimeLeft.Text > 1620 Then
            If TimeLeft.Text <= 1630 Then
                r5i163.Text = r5i163.Text + 1
            End If
        End If
        If TimeLeft.Text > 1630 Then
            If TimeLeft.Text <= 1640 Then
                r5i164.Text = r5i164.Text + 1
            End If
        End If
        If TimeLeft.Text > 1640 Then
            If TimeLeft.Text <= 1650 Then
                r5i165.Text = r5i165.Text + 1
            End If
        End If
        If TimeLeft.Text > 1650 Then
            If TimeLeft.Text <= 1660 Then
                r5i166.Text = r5i166.Text + 1
            End If
        End If
        If TimeLeft.Text > 1660 Then
            If TimeLeft.Text <= 1670 Then
                r5i167.Text = r5i167.Text + 1
            End If
        End If
        If TimeLeft.Text > 1670 Then
            If TimeLeft.Text <= 1680 Then
                r5i168.Text = r5i168.Text + 1
            End If
        End If
        If TimeLeft.Text > 1680 Then
            If TimeLeft.Text <= 1690 Then
                r5i169.Text = r5i169.Text + 1
            End If
        End If
        If TimeLeft.Text > 1690 Then
            If TimeLeft.Text <= 1700 Then
                r5i170.Text = r5i170.Text + 1
            End If
        End If
        If TimeLeft.Text > 1700 Then
            If TimeLeft.Text <= 1710 Then
                r5i171.Text = r5i171.Text + 1
            End If
        End If
        If TimeLeft.Text > 1710 Then
            If TimeLeft.Text <= 1720 Then
                r5i172.Text = r5i172.Text + 1
            End If
        End If
        If TimeLeft.Text > 1720 Then
            If TimeLeft.Text <= 1730 Then
                r5i173.Text = r5i173.Text + 1
            End If
        End If
        If TimeLeft.Text > 1730 Then
            If TimeLeft.Text <= 1740 Then
                r5i174.Text = r5i174.Text + 1
            End If
        End If
        If TimeLeft.Text > 1740 Then
            If TimeLeft.Text <= 1750 Then
                r5i175.Text = r5i175.Text + 1
            End If
        End If
        If TimeLeft.Text > 1750 Then
            If TimeLeft.Text <= 1760 Then
                r5i176.Text = r5i176.Text + 1
            End If
        End If
        If TimeLeft.Text > 1760 Then
            If TimeLeft.Text <= 1770 Then
                r5i177.Text = r5i177.Text + 1
            End If
        End If
        If TimeLeft.Text > 1770 Then
            If TimeLeft.Text <= 1780 Then
                r5i178.Text = r5i178.Text + 1
            End If
        End If
        If TimeLeft.Text > 1780 Then
            If TimeLeft.Text <= 1790 Then
                r5i179.Text = r5i179.Text + 1
            End If
        End If
        If TimeLeft.Text > 1790 Then
            If TimeLeft.Text <= 1800 Then
                r5i180.Text = r5i180.Text + 1
            End If
        End If
        If TimeLeft.Text > 1800 Then
            If TimeLeft.Text <= 1810 Then
                r5i181.Text = r5i181.Text + 1
            End If
        End If
        If TimeLeft.Text > 1810 Then
            If TimeLeft.Text <= 1820 Then
                r5i182.Text = r5i182.Text + 1
            End If
        End If
        If TimeLeft.Text > 1820 Then
            If TimeLeft.Text <= 1830 Then
                r5i183.Text = r5i183.Text + 1
            End If
        End If
        If TimeLeft.Text > 1830 Then
            If TimeLeft.Text <= 1840 Then
                r5i184.Text = r5i184.Text + 1
            End If
        End If
        If TimeLeft.Text > 1840 Then
            If TimeLeft.Text <= 1850 Then
                r5i185.Text = r5i185.Text + 1
            End If
        End If
        If TimeLeft.Text > 1850 Then
            If TimeLeft.Text <= 1860 Then
                r5i186.Text = r5i186.Text + 1
            End If
        End If
        If TimeLeft.Text > 1860 Then
            If TimeLeft.Text <= 1870 Then
                r5i187.Text = r5i187.Text + 1
            End If
        End If
        If TimeLeft.Text > 1870 Then
            If TimeLeft.Text <= 1880 Then
                r5i188.Text = r5i188.Text + 1
            End If
        End If
        If TimeLeft.Text > 1880 Then
            If TimeLeft.Text <= 1890 Then
                r5i189.Text = r5i189.Text + 1
            End If
        End If
        If TimeLeft.Text > 1890 Then
            If TimeLeft.Text <= 1900 Then
                r5i190.Text = r5i190.Text + 1
            End If
        End If
        If TimeLeft.Text > 1900 Then
            If TimeLeft.Text <= 1910 Then
                r5i191.Text = r5i191.Text + 1
            End If
        End If
        If TimeLeft.Text > 1910 Then
            If TimeLeft.Text <= 1920 Then
                r5i192.Text = r5i192.Text + 1
            End If
        End If
        If TimeLeft.Text > 1920 Then
            If TimeLeft.Text <= 1930 Then
                r5i193.Text = r5i193.Text + 1
            End If
        End If
        If TimeLeft.Text > 1930 Then
            If TimeLeft.Text <= 1940 Then
                r5i194.Text = r5i194.Text + 1
            End If
        End If
        If TimeLeft.Text > 1940 Then
            If TimeLeft.Text <= 1950 Then
                r5i195.Text = r5i195.Text + 1
            End If
        End If
        If TimeLeft.Text > 1950 Then
            If TimeLeft.Text <= 1960 Then
                r5i196.Text = r5i196.Text + 1
            End If
        End If
        If TimeLeft.Text > 1960 Then
            If TimeLeft.Text <= 1970 Then
                r5i197.Text = r5i197.Text + 1
            End If
        End If
        If TimeLeft.Text > 1970 Then
            If TimeLeft.Text <= 1980 Then
                r5i198.Text = r5i198.Text + 1
            End If
        End If
        If TimeLeft.Text > 1980 Then
            If TimeLeft.Text <= 1990 Then
                r5i199.Text = r5i199.Text + 1
            End If
        End If
        If TimeLeft.Text > 2000 Then
            If TimeLeft.Text <= 2010 Then
                r5i201.Text = r5i201.Text + 1
            End If
        End If
        If TimeLeft.Text > 2010 Then
            If TimeLeft.Text <= 2020 Then
                r5i202.Text = r5i202.Text + 1
            End If
        End If
        If TimeLeft.Text > 2020 Then
            If TimeLeft.Text <= 2030 Then
                r5i203.Text = r5i203.Text + 1
            End If
        End If
        If TimeLeft.Text > 2030 Then
            If TimeLeft.Text <= 2040 Then
                r5i204.Text = r5i204.Text + 1
            End If
        End If
        If TimeLeft.Text > 2040 Then
            If TimeLeft.Text <= 2050 Then
                r5i205.Text = r5i205.Text + 1
            End If
        End If
        If TimeLeft.Text > 2050 Then
            If TimeLeft.Text <= 2060 Then
                r5i206.Text = r5i206.Text + 1
            End If
        End If
        If TimeLeft.Text > 2060 Then
            If TimeLeft.Text <= 2070 Then
                r5i207.Text = r5i207.Text + 1
            End If
        End If
        If TimeLeft.Text > 2070 Then
            If TimeLeft.Text <= 2080 Then
                r5i208.Text = r5i208.Text + 1
            End If
        End If
        If TimeLeft.Text > 2080 Then
            If TimeLeft.Text <= 2090 Then
                r5i209.Text = r5i209.Text + 1
            End If
        End If
        If TimeLeft.Text > 2090 Then
            If TimeLeft.Text <= 2100 Then
                r5i210.Text = r5i210.Text + 1
            End If
        End If
        If TimeLeft.Text > 2100 Then
            If TimeLeft.Text <= 2110 Then
                r5i211.Text = r5i211.Text + 1
            End If
        End If
        If TimeLeft.Text > 2110 Then
            If TimeLeft.Text <= 2120 Then
                r5i212.Text = r5i212.Text + 1
            End If
        End If
        If TimeLeft.Text > 2120 Then
            If TimeLeft.Text <= 2130 Then
                r5i213.Text = r5i213.Text + 1
            End If
        End If
        If TimeLeft.Text > 2130 Then
            If TimeLeft.Text <= 2140 Then
                r5i214.Text = r5i214.Text + 1
            End If
        End If
        If TimeLeft.Text > 2140 Then
            If TimeLeft.Text <= 2150 Then
                r5i215.Text = r5i215.Text + 1
            End If
        End If
        If TimeLeft.Text > 2150 Then
            If TimeLeft.Text <= 2160 Then
                r5i216.Text = r5i216.Text + 1
            End If
        End If
        If TimeLeft.Text > 2160 Then
            If TimeLeft.Text <= 2170 Then
                r5i217.Text = r5i217.Text + 1
            End If
        End If
        If TimeLeft.Text > 2170 Then
            If TimeLeft.Text <= 2180 Then
                r5i218.Text = r5i218.Text + 1
            End If
        End If
        If TimeLeft.Text > 2180 Then
            If TimeLeft.Text <= 2190 Then
                r5i219.Text = r5i219.Text + 1
            End If
        End If
        If TimeLeft.Text > 2190 Then
            If TimeLeft.Text <= 2200 Then
                r5i220.Text = r5i220.Text + 1
            End If
        End If
        If TimeLeft.Text > 2200 Then
            If TimeLeft.Text <= 2210 Then
                r5i221.Text = r5i221.Text + 1
            End If
        End If
        If TimeLeft.Text > 2210 Then
            If TimeLeft.Text <= 2220 Then
                r5i222.Text = r5i222.Text + 1
            End If
        End If
        If TimeLeft.Text > 2220 Then
            If TimeLeft.Text <= 2230 Then
                r5i223.Text = r5i223.Text + 1
            End If
        End If
        If TimeLeft.Text > 2230 Then
            If TimeLeft.Text <= 2240 Then
                r5i224.Text = r5i224.Text + 1
            End If
        End If
        If TimeLeft.Text > 2240 Then
            If TimeLeft.Text <= 2250 Then
                r5i225.Text = r5i225.Text + 1
            End If
        End If
        If TimeLeft.Text > 2250 Then
            If TimeLeft.Text <= 2260 Then
                r5i226.Text = r5i226.Text + 1
            End If
        End If
        If TimeLeft.Text > 2260 Then
            If TimeLeft.Text <= 2270 Then
                r5i227.Text = r5i227.Text + 1
            End If
        End If
        If TimeLeft.Text > 2270 Then
            If TimeLeft.Text <= 2280 Then
                r5i228.Text = r5i228.Text + 1
            End If
        End If
        If TimeLeft.Text > 2280 Then
            If TimeLeft.Text <= 2290 Then
                r5i229.Text = r5i229.Text + 1
            End If
        End If
        If TimeLeft.Text > 2290 Then
            If TimeLeft.Text <= 2300 Then
                r5i230.Text = r5i230.Text + 1
            End If
        End If
        If TimeLeft.Text > 2300 Then
            If TimeLeft.Text <= 2310 Then
                r5i231.Text = r5i231.Text + 1
            End If
        End If
        If TimeLeft.Text > 2310 Then
            If TimeLeft.Text <= 2320 Then
                r5i232.Text = r5i232.Text + 1
            End If
        End If
        If TimeLeft.Text > 2320 Then
            If TimeLeft.Text <= 2330 Then
                r5i233.Text = r5i233.Text + 1
            End If
        End If
        If TimeLeft.Text > 2330 Then
            If TimeLeft.Text <= 2340 Then
                r5i234.Text = r5i234.Text + 1
            End If
        End If
        If TimeLeft.Text > 2340 Then
            If TimeLeft.Text <= 2350 Then
                r5i235.Text = r5i235.Text + 1
            End If
        End If
        If TimeLeft.Text > 2350 Then
            If TimeLeft.Text <= 2360 Then
                r5i236.Text = r5i236.Text + 1
            End If
        End If
        If TimeLeft.Text > 2360 Then
            If TimeLeft.Text <= 2370 Then
                r5i237.Text = r5i237.Text + 1
            End If
        End If
        If TimeLeft.Text > 2370 Then
            If TimeLeft.Text <= 2380 Then
                r5i238.Text = r5i238.Text + 1
            End If
        End If
        If TimeLeft.Text > 2380 Then
            If TimeLeft.Text <= 2390 Then
                r5i239.Text = r5i239.Text + 1
            End If
        End If
        If TimeLeft.Text > 2390 Then
            If TimeLeft.Text <= 2400 Then
                r5i240.Text = r5i240.Text + 1
            End If
        End If
        If TimeLeft.Text > 2400 Then
            If TimeLeft.Text <= 2410 Then
                r5i241.Text = r5i241.Text + 1
            End If
        End If
        If TimeLeft.Text > 2410 Then
            If TimeLeft.Text <= 2420 Then
                r5i242.Text = r5i242.Text + 1
            End If
        End If
        If TimeLeft.Text > 2420 Then
            If TimeLeft.Text <= 2430 Then
                r5i243.Text = r5i243.Text + 1
            End If
        End If
        If TimeLeft.Text > 2430 Then
            If TimeLeft.Text <= 2440 Then
                r5i244.Text = r5i244.Text + 1
            End If
        End If
        If TimeLeft.Text > 2440 Then
            If TimeLeft.Text <= 2450 Then
                r5i245.Text = r5i245.Text + 1
            End If
        End If
        If TimeLeft.Text > 2450 Then
            If TimeLeft.Text <= 2460 Then
                r5i246.Text = r5i246.Text + 1
            End If
        End If
        If TimeLeft.Text > 2460 Then
            If TimeLeft.Text <= 2470 Then
                r5i247.Text = r5i247.Text + 1
            End If
        End If
        If TimeLeft.Text > 2470 Then
            If TimeLeft.Text <= 2480 Then
                r5i248.Text = r5i248.Text + 1
            End If
        End If
        If TimeLeft.Text > 2480 Then
            If TimeLeft.Text <= 2490 Then
                r5i249.Text = r5i249.Text + 1
            End If
        End If
        If TimeLeft.Text > 2490 Then
            If TimeLeft.Text <= 2500 Then
                r5i250.Text = r5i250.Text + 1
            End If
        End If
        If TimeLeft.Text > 2500 Then
            If TimeLeft.Text <= 2510 Then
                r5i251.Text = r5i251.Text + 1
            End If
        End If
        If TimeLeft.Text > 2510 Then
            If TimeLeft.Text <= 2520 Then
                r5i252.Text = r5i252.Text + 1
            End If
        End If
        If TimeLeft.Text > 2520 Then
            If TimeLeft.Text <= 2530 Then
                r5i253.Text = r5i253.Text + 1
            End If
        End If
        If TimeLeft.Text > 2530 Then
            If TimeLeft.Text <= 2540 Then
                r5i254.Text = r5i254.Text + 1
            End If
        End If
        If TimeLeft.Text > 2540 Then
            If TimeLeft.Text <= 2550 Then
                r5i255.Text = r5i255.Text + 1
            End If
        End If
        If TimeLeft.Text > 2550 Then
            If TimeLeft.Text <= 2560 Then
                r5i256.Text = r5i256.Text + 1
            End If
        End If
        If TimeLeft.Text > 2560 Then
            If TimeLeft.Text <= 2570 Then
                r5i257.Text = r5i257.Text + 1
            End If
        End If
        If TimeLeft.Text > 2570 Then
            If TimeLeft.Text <= 2580 Then
                r5i258.Text = r5i258.Text + 1
            End If
        End If
        If TimeLeft.Text > 2580 Then
            If TimeLeft.Text <= 2590 Then
                r5i259.Text = r5i259.Text + 1
            End If
        End If
        If TimeLeft.Text > 2590 Then
            If TimeLeft.Text <= 2600 Then
                r5i260.Text = r5i260.Text + 1
            End If
        End If
        If TimeLeft.Text > 2600 Then
            If TimeLeft.Text <= 2610 Then
                r5i261.Text = r5i261.Text + 1
            End If
        End If
        If TimeLeft.Text > 2610 Then
            If TimeLeft.Text <= 2620 Then
                r5i262.Text = r5i262.Text + 1
            End If
        End If
        If TimeLeft.Text > 2620 Then
            If TimeLeft.Text <= 2630 Then
                r5i263.Text = r5i263.Text + 1
            End If
        End If
        If TimeLeft.Text > 2630 Then
            If TimeLeft.Text <= 2640 Then
                r5i264.Text = r5i264.Text + 1
            End If
        End If
        If TimeLeft.Text > 2640 Then
            If TimeLeft.Text <= 2650 Then
                r5i265.Text = r5i265.Text + 1
            End If
        End If
        If TimeLeft.Text > 2650 Then
            If TimeLeft.Text <= 2660 Then
                r5i266.Text = r5i266.Text + 1
            End If
        End If
        If TimeLeft.Text > 2660 Then
            If TimeLeft.Text <= 2670 Then
                r5i267.Text = r5i267.Text + 1
            End If
        End If
        If TimeLeft.Text > 2670 Then
            If TimeLeft.Text <= 2680 Then
                r5i268.Text = r5i268.Text + 1
            End If
        End If
        If TimeLeft.Text > 2680 Then
            If TimeLeft.Text <= 2690 Then
                r5i269.Text = r5i269.Text + 1
            End If
        End If
        If TimeLeft.Text > 2690 Then
            If TimeLeft.Text <= 2700 Then
                r5i270.Text = r5i270.Text + 1
            End If
        End If
        If TimeLeft.Text > 2700 Then
            If TimeLeft.Text <= 2710 Then
                r5i271.Text = r5i271.Text + 1
            End If
        End If
        If TimeLeft.Text > 2710 Then
            If TimeLeft.Text <= 2720 Then
                r5i272.Text = r5i272.Text + 1
            End If
        End If
        If TimeLeft.Text > 2720 Then
            If TimeLeft.Text <= 2730 Then
                r5i273.Text = r5i273.Text + 1
            End If
        End If
        If TimeLeft.Text > 2730 Then
            If TimeLeft.Text <= 2740 Then
                r5i274.Text = r5i274.Text + 1
            End If
        End If
        If TimeLeft.Text > 2740 Then
            If TimeLeft.Text <= 2750 Then
                r5i275.Text = r5i275.Text + 1
            End If
        End If
        If TimeLeft.Text > 2750 Then
            If TimeLeft.Text <= 2760 Then
                r5i276.Text = r5i276.Text + 1
            End If
        End If
        If TimeLeft.Text > 2760 Then
            If TimeLeft.Text <= 2770 Then
                r5i277.Text = r5i277.Text + 1
            End If
        End If
        If TimeLeft.Text > 2770 Then
            If TimeLeft.Text <= 2780 Then
                r5i278.Text = r5i278.Text + 1
            End If
        End If
        If TimeLeft.Text > 2780 Then
            If TimeLeft.Text <= 2790 Then
                r5i279.Text = r5i279.Text + 1
            End If
        End If
        If TimeLeft.Text > 2790 Then
            If TimeLeft.Text <= 2800 Then
                r5i281.Text = r5i280.Text + 1
            End If
        End If
        If TimeLeft.Text > 2800 Then
            If TimeLeft.Text <= 2810 Then
                r5i281.Text = r5i281.Text + 1
            End If
        End If
        If TimeLeft.Text > 2810 Then
            If TimeLeft.Text <= 2820 Then
                r5i282.Text = r5i282.Text + 1
            End If
        End If
        If TimeLeft.Text > 2820 Then
            If TimeLeft.Text <= 2830 Then
                r5i283.Text = r5i283.Text + 1
            End If
        End If
        If TimeLeft.Text > 2830 Then
            If TimeLeft.Text <= 2840 Then
                r5i284.Text = r5i284.Text + 1
            End If
        End If
        If TimeLeft.Text > 2840 Then
            If TimeLeft.Text <= 2850 Then
                r5i285.Text = r5i285.Text + 1
            End If
        End If
        If TimeLeft.Text > 2850 Then
            If TimeLeft.Text <= 2860 Then
                r5i286.Text = r5i286.Text + 1
            End If
        End If
        If TimeLeft.Text > 2860 Then
            If TimeLeft.Text <= 2870 Then
                r5i287.Text = r5i287.Text + 1
            End If
        End If
        If TimeLeft.Text > 2870 Then
            If TimeLeft.Text <= 2880 Then
                r5i288.Text = r5i288.Text + 1
            End If
        End If

    End Sub

    'Code for alternative four response. 
    Private Sub r0601_Click(sender As Object, e As EventArgs) Handles r0601.Click
        r0601.Visible = False
        r0602.Visible = True
        r0101.Visible = True
        r0102.Visible = False
        r0103.Visible = False
        r0104.Visible = False
        r0105.Visible = False
        r0106.Visible = False
        r0201.Visible = True
        r0202.Visible = False
        r0203.Visible = False
        r0204.Visible = False
        r0205.Visible = False
        r0206.Visible = False
        r0301.Visible = True
        r0302.Visible = False
        r0303.Visible = False
        r0304.Visible = False
        r0305.Visible = False
        r0306.Visible = False
        r0401.Visible = True
        r0402.Visible = False
        r0403.Visible = False
        r0404.Visible = False
        r0405.Visible = False
        r0406.Visible = False
        r0501.Visible = True
        r0502.Visible = False
        r0503.Visible = False
        r0504.Visible = False
        r0505.Visible = False
        r0506.Visible = False
    End Sub
    Private Sub r0602_Click(sender As Object, e As EventArgs) Handles r0602.Click
        r0602.Visible = False
        r0603.Visible = True
    End Sub
    Private Sub r0603_Click(sender As Object, e As EventArgs) Handles r0603.Click
        r0603.Visible = False
        r0604.Visible = True
    End Sub
    Private Sub r0604_Click(sender As Object, e As EventArgs) Handles r0604.Click
        r0604.Visible = False
        r0605.Visible = True
    End Sub
    Private Sub r0605_Click(sender As Object, e As EventArgs) Handles r0605.Click
        r0605.Visible = False
        r0606.Visible = True
    End Sub
    Private Sub r0606_Click(sender As Object, e As EventArgs) Handles r0606.Click
        r0606.Visible = False
        r0601.Visible = True
        'Code for changeover (CO) response. That is, the first response following switching cannot contact reinforcement. 
        If r6CO.Text < 2 Then
            r6CO.Text = Val(r6CO.Text) + 1
            r1CO.Text = 0
            r2CO.Text = 0
            r3CO.Text = 0
            r4CO.Text = 0
            r5CO.Text = 0
        End If
        If r6CO.Text = 2 Then
            If r6VIval.Text = 0 Then
                pointText.Visible = True
                consumResp.Visible = True
                Alt4TimeDeliver.Text = Alt4TimeDeliver.Text + TimeLeft.Text + ","
            End If
        End If
        'Code for count per 2-min session. 
        If TimeLeft.Text > 0 Then
            If TimeLeft.Text <= 120 Then
                r6sess1.Text = r6sess1.Text + 1
            End If
        End If
        If TimeLeft.Text > 120 Then
            If TimeLeft.Text <= 240 Then
                r6sess2.Text = r6sess2.Text + 1
            End If
        End If
        If TimeLeft.Text > 240 Then
            If TimeLeft.Text <= 360 Then
                r6sess3.Text = r6sess3.Text + 1
            End If
        End If
        If TimeLeft.Text > 360 Then
            If TimeLeft.Text <= 480 Then
                r6sess4.Text = r6sess4.Text + 1
            End If
        End If
        If TimeLeft.Text > 480 Then
            If TimeLeft.Text <= 600 Then
                r6sess5.Text = r6sess5.Text + 1
            End If
        End If
        If TimeLeft.Text > 600 Then
            If TimeLeft.Text <= 720 Then
                r6sess6.Text = r6sess6.Text + 1
            End If
        End If
        If TimeLeft.Text > 720 Then
            If TimeLeft.Text <= 840 Then
                r6sess7.Text = r6sess7.Text + 1
            End If
        End If
        If TimeLeft.Text > 840 Then
            If TimeLeft.Text <= 960 Then
                r6sess8.Text = r6sess8.Text + 1
            End If
        End If
        If TimeLeft.Text > 960 Then
            If TimeLeft.Text <= 1080 Then
                r6sess9.Text = r6sess9.Text + 1
            End If
        End If
        If TimeLeft.Text > 1080 Then
            If TimeLeft.Text <= 1200 Then
                r6sess10.Text = r6sess10.Text + 1
            End If
        End If
        If TimeLeft.Text > 1200 Then
            If TimeLeft.Text <= 1320 Then
                r6sess11.Text = r6sess11.Text + 1
            End If
        End If
        If TimeLeft.Text > 1320 Then
            If TimeLeft.Text <= 1440 Then
                r6sess12.Text = r6sess12.Text + 1
            End If
        End If
        If TimeLeft.Text > 1440 Then
            If TimeLeft.Text <= 1560 Then
                r6sess13.Text = r6sess13.Text + 1
            End If
        End If
        If TimeLeft.Text > 1560 Then
            If TimeLeft.Text <= 1680 Then
                r6sess14.Text = r6sess14.Text + 1
            End If
        End If
        If TimeLeft.Text > 1680 Then
            If TimeLeft.Text <= 1800 Then
                r6sess15.Text = r6sess15.Text + 1
            End If
        End If
        If TimeLeft.Text > 1800 Then
            If TimeLeft.Text <= 1920 Then
                r6sess16.Text = r6sess16.Text + 1
            End If
        End If
        If TimeLeft.Text > 1920 Then
            If TimeLeft.Text <= 2040 Then
                r6sess17.Text = r6sess17.Text + 1
            End If
        End If
        If TimeLeft.Text > 2040 Then
            If TimeLeft.Text <= 2160 Then
                r6sess18.Text = r6sess18.Text + 1
            End If
        End If
        If TimeLeft.Text > 2160 Then
            If TimeLeft.Text <= 2280 Then
                r6sess19.Text = r6sess19.Text + 1
            End If
        End If
        If TimeLeft.Text > 2280 Then
            If TimeLeft.Text <= 2400 Then
                r6sess20.Text = r6sess20.Text + 1
            End If
        End If
        If TimeLeft.Text > 2400 Then
            If TimeLeft.Text <= 2520 Then
                r6sess21.Text = r6sess21.Text + 1
            End If
        End If
        If TimeLeft.Text > 2520 Then
            If TimeLeft.Text <= 2640 Then
                r6sess22.Text = r6sess22.Text + 1
            End If
        End If
        If TimeLeft.Text > 2640 Then
            If TimeLeft.Text <= 2760 Then
                r6sess23.Text = r6sess23.Text + 1
            End If
        End If
        If TimeLeft.Text > 2760 Then
            If TimeLeft.Text <= 2880 Then
                r6sess24.Text = r6sess24.Text + 1
            End If
        End If


        'Code for count per 10-sec interval.
        If TimeLeft.Text > 0 Then
            If TimeLeft.Text <= 10 Then
                r6i01.Text = r6i01.Text + 1
            End If
        End If
        If TimeLeft.Text > 10 Then
            If TimeLeft.Text <= 20 Then
                r6i02.Text = r6i02.Text + 1
            End If
        End If
        If TimeLeft.Text > 20 Then
            If TimeLeft.Text <= 30 Then
                r6i03.Text = r6i03.Text + 1
            End If
        End If
        If TimeLeft.Text > 30 Then
            If TimeLeft.Text <= 40 Then
                r6i04.Text = r6i04.Text + 1
            End If
        End If
        If TimeLeft.Text > 40 Then
            If TimeLeft.Text <= 50 Then
                r6i05.Text = r6i05.Text + 1
            End If
        End If
        If TimeLeft.Text > 50 Then
            If TimeLeft.Text <= 60 Then
                r6i06.Text = r6i06.Text + 1
            End If
        End If
        If TimeLeft.Text > 60 Then
            If TimeLeft.Text <= 70 Then
                r6i07.Text = r6i07.Text + 1
            End If
        End If
        If TimeLeft.Text > 70 Then
            If TimeLeft.Text <= 80 Then
                r6i08.Text = r6i08.Text + 1
            End If
        End If
        If TimeLeft.Text > 80 Then
            If TimeLeft.Text <= 90 Then
                r6i09.Text = r6i09.Text + 1
            End If
        End If
        If TimeLeft.Text > 90 Then
            If TimeLeft.Text <= 100 Then
                r6i10.Text = r6i10.Text + 1
            End If
        End If
        If TimeLeft.Text > 100 Then
            If TimeLeft.Text <= 110 Then
                r6i11.Text = r6i11.Text + 1
            End If
        End If
        If TimeLeft.Text > 110 Then
            If TimeLeft.Text <= 120 Then
                r6i12.Text = r6i12.Text + 1
            End If
        End If
        If TimeLeft.Text > 120 Then
            If TimeLeft.Text <= 130 Then
                r6i13.Text = r6i13.Text + 1
            End If
        End If
        If TimeLeft.Text > 130 Then
            If TimeLeft.Text <= 140 Then
                r6i14.Text = r6i14.Text + 1
            End If
        End If
        If TimeLeft.Text > 140 Then
            If TimeLeft.Text <= 150 Then
                r6i15.Text = r6i15.Text + 1
            End If
        End If
        If TimeLeft.Text > 150 Then
            If TimeLeft.Text <= 160 Then
                r6i16.Text = r6i16.Text + 1
            End If
        End If
        If TimeLeft.Text > 160 Then
            If TimeLeft.Text <= 170 Then
                r6i17.Text = r6i17.Text + 1
            End If
        End If
        If TimeLeft.Text > 170 Then
            If TimeLeft.Text <= 180 Then
                r6i18.Text = r6i18.Text + 1
            End If
        End If
        If TimeLeft.Text > 180 Then
            If TimeLeft.Text <= 190 Then
                r6i19.Text = r6i19.Text + 1
            End If
        End If
        If TimeLeft.Text > 190 Then
            If TimeLeft.Text <= 200 Then
                r6i20.Text = r6i20.Text + 1
            End If
        End If
        If TimeLeft.Text > 200 Then
            If TimeLeft.Text <= 210 Then
                r6i21.Text = r6i21.Text + 1
            End If
        End If
        If TimeLeft.Text > 210 Then
            If TimeLeft.Text <= 220 Then
                r6i22.Text = r6i22.Text + 1
            End If
        End If
        If TimeLeft.Text > 220 Then
            If TimeLeft.Text <= 230 Then
                r6i23.Text = r6i23.Text + 1
            End If
        End If
        If TimeLeft.Text > 230 Then
            If TimeLeft.Text <= 240 Then
                r6i24.Text = r6i24.Text + 1
            End If
        End If
        If TimeLeft.Text > 240 Then
            If TimeLeft.Text <= 250 Then
                r6i25.Text = r6i25.Text + 1
            End If
        End If
        If TimeLeft.Text > 250 Then
            If TimeLeft.Text <= 260 Then
                r6i26.Text = r6i26.Text + 1
            End If
        End If
        If TimeLeft.Text > 260 Then
            If TimeLeft.Text <= 270 Then
                r6i27.Text = r6i27.Text + 1
            End If
        End If
        If TimeLeft.Text > 270 Then
            If TimeLeft.Text <= 280 Then
                r6i28.Text = r6i28.Text + 1
            End If
        End If
        If TimeLeft.Text > 280 Then
            If TimeLeft.Text <= 290 Then
                r6i29.Text = r6i29.Text + 1
            End If
        End If
        If TimeLeft.Text > 290 Then
            If TimeLeft.Text <= 300 Then
                r6i30.Text = r6i30.Text + 1
            End If
        End If
        If TimeLeft.Text > 300 Then
            If TimeLeft.Text <= 310 Then
                r6i31.Text = r6i31.Text + 1
            End If
        End If
        If TimeLeft.Text > 310 Then
            If TimeLeft.Text <= 320 Then
                r6i32.Text = r6i32.Text + 1
            End If
        End If
        If TimeLeft.Text > 320 Then
            If TimeLeft.Text <= 330 Then
                r6i33.Text = r6i33.Text + 1
            End If
        End If
        If TimeLeft.Text > 330 Then
            If TimeLeft.Text <= 340 Then
                r6i34.Text = r6i34.Text + 1
            End If
        End If
        If TimeLeft.Text > 340 Then
            If TimeLeft.Text <= 350 Then
                r6i35.Text = r6i35.Text + 1
            End If
        End If
        If TimeLeft.Text > 350 Then
            If TimeLeft.Text <= 360 Then
                r6i36.Text = r6i36.Text + 1
            End If
        End If
        If TimeLeft.Text > 360 Then
            If TimeLeft.Text <= 370 Then
                r6i37.Text = r6i37.Text + 1
            End If
        End If
        If TimeLeft.Text > 370 Then
            If TimeLeft.Text <= 380 Then
                r6i38.Text = r6i38.Text + 1
            End If
        End If
        If TimeLeft.Text > 380 Then
            If TimeLeft.Text <= 390 Then
                r6i39.Text = r6i39.Text + 1
            End If
        End If
        If TimeLeft.Text > 390 Then
            If TimeLeft.Text <= 400 Then
                r6i40.Text = r6i40.Text + 1
            End If
        End If
        If TimeLeft.Text > 400 Then
            If TimeLeft.Text <= 410 Then
                r6i41.Text = r6i41.Text + 1
            End If
        End If
        If TimeLeft.Text > 410 Then
            If TimeLeft.Text <= 420 Then
                r6i42.Text = r6i42.Text + 1
            End If
        End If
        If TimeLeft.Text > 420 Then
            If TimeLeft.Text <= 430 Then
                r6i43.Text = r6i43.Text + 1
            End If
        End If
        If TimeLeft.Text > 430 Then
            If TimeLeft.Text <= 440 Then
                r6i44.Text = r6i44.Text + 1
            End If
        End If
        If TimeLeft.Text > 440 Then
            If TimeLeft.Text <= 450 Then
                r6i45.Text = r6i45.Text + 1
            End If
        End If
        If TimeLeft.Text > 450 Then
            If TimeLeft.Text <= 460 Then
                r6i46.Text = r6i46.Text + 1
            End If
        End If
        If TimeLeft.Text > 460 Then
            If TimeLeft.Text <= 470 Then
                r6i47.Text = r6i47.Text + 1
            End If
        End If
        If TimeLeft.Text > 470 Then
            If TimeLeft.Text <= 480 Then
                r6i48.Text = r6i48.Text + 1
            End If
        End If
        If TimeLeft.Text > 480 Then
            If TimeLeft.Text <= 490 Then
                r6i49.Text = r6i49.Text + 1
            End If
        End If
        If TimeLeft.Text > 490 Then
            If TimeLeft.Text <= 500 Then
                r6i50.Text = r6i50.Text + 1
            End If
        End If
        If TimeLeft.Text > 500 Then
            If TimeLeft.Text <= 510 Then
                r6i51.Text = r6i51.Text + 1
            End If
        End If
        If TimeLeft.Text > 510 Then
            If TimeLeft.Text <= 520 Then
                r6i52.Text = r6i52.Text + 1
            End If
        End If
        If TimeLeft.Text > 520 Then
            If TimeLeft.Text <= 530 Then
                r6i53.Text = r6i53.Text + 1
            End If
        End If
        If TimeLeft.Text > 530 Then
            If TimeLeft.Text <= 540 Then
                r6i54.Text = r6i54.Text + 1
            End If
        End If
        If TimeLeft.Text > 540 Then
            If TimeLeft.Text <= 550 Then
                r6i55.Text = r6i55.Text + 1
            End If
        End If
        If TimeLeft.Text > 550 Then
            If TimeLeft.Text <= 560 Then
                r6i56.Text = r6i56.Text + 1
            End If
        End If
        If TimeLeft.Text > 560 Then
            If TimeLeft.Text <= 570 Then
                r6i57.Text = r6i57.Text + 1
            End If
        End If
        If TimeLeft.Text > 570 Then
            If TimeLeft.Text <= 580 Then
                r6i58.Text = r6i58.Text + 1
            End If
        End If
        If TimeLeft.Text > 580 Then
            If TimeLeft.Text <= 590 Then
                r6i59.Text = r6i59.Text + 1
            End If
        End If
        If TimeLeft.Text > 590 Then
            If TimeLeft.Text <= 600 Then
                r6i60.Text = r6i60.Text + 1
            End If
        End If
        If TimeLeft.Text > 600 Then
            If TimeLeft.Text <= 610 Then
                r6i61.Text = r6i61.Text + 1
            End If
        End If
        If TimeLeft.Text > 610 Then
            If TimeLeft.Text <= 620 Then
                r6i62.Text = r6i62.Text + 1
            End If
        End If
        If TimeLeft.Text > 620 Then
            If TimeLeft.Text <= 630 Then
                r6i63.Text = r6i63.Text + 1
            End If
        End If
        If TimeLeft.Text > 630 Then
            If TimeLeft.Text <= 640 Then
                r6i64.Text = r6i64.Text + 1
            End If
        End If
        If TimeLeft.Text > 640 Then
            If TimeLeft.Text <= 650 Then
                r6i65.Text = r6i65.Text + 1
            End If
        End If
        If TimeLeft.Text > 650 Then
            If TimeLeft.Text <= 660 Then
                r6i66.Text = r6i66.Text + 1
            End If
        End If
        If TimeLeft.Text > 660 Then
            If TimeLeft.Text <= 670 Then
                r6i67.Text = r6i67.Text + 1
            End If
        End If
        If TimeLeft.Text > 670 Then
            If TimeLeft.Text <= 680 Then
                r6i68.Text = r6i68.Text + 1
            End If
        End If
        If TimeLeft.Text > 680 Then
            If TimeLeft.Text <= 690 Then
                r6i69.Text = r6i69.Text + 1
            End If
        End If
        If TimeLeft.Text > 690 Then
            If TimeLeft.Text <= 700 Then
                r6i70.Text = r6i70.Text + 1
            End If
        End If
        If TimeLeft.Text > 700 Then
            If TimeLeft.Text <= 710 Then
                r6i71.Text = r6i71.Text + 1
            End If
        End If
        If TimeLeft.Text > 710 Then
            If TimeLeft.Text <= 720 Then
                r6i72.Text = r6i72.Text + 1
            End If
        End If
        If TimeLeft.Text > 720 Then
            If TimeLeft.Text <= 730 Then
                r6i73.Text = r6i73.Text + 1
            End If
        End If
        If TimeLeft.Text > 730 Then
            If TimeLeft.Text <= 740 Then
                r6i74.Text = r6i74.Text + 1
            End If
        End If
        If TimeLeft.Text > 740 Then
            If TimeLeft.Text <= 750 Then
                r6i75.Text = r6i75.Text + 1
            End If
        End If
        If TimeLeft.Text > 750 Then
            If TimeLeft.Text <= 760 Then
                r6i76.Text = r6i76.Text + 1
            End If
        End If
        If TimeLeft.Text > 760 Then
            If TimeLeft.Text <= 770 Then
                r6i77.Text = r6i77.Text + 1
            End If
        End If
        If TimeLeft.Text > 770 Then
            If TimeLeft.Text <= 780 Then
                r6i78.Text = r6i78.Text + 1
            End If
        End If
        If TimeLeft.Text > 780 Then
            If TimeLeft.Text <= 790 Then
                r6i79.Text = r6i79.Text + 1
            End If
        End If
        If TimeLeft.Text > 790 Then
            If TimeLeft.Text <= 800 Then
                r6i80.Text = r6i80.Text + 1
            End If
        End If
        If TimeLeft.Text > 800 Then
            If TimeLeft.Text <= 810 Then
                r6i81.Text = r6i81.Text + 1
            End If
        End If
        If TimeLeft.Text > 810 Then
            If TimeLeft.Text <= 820 Then
                r6i82.Text = r6i82.Text + 1
            End If
        End If
        If TimeLeft.Text > 820 Then
            If TimeLeft.Text <= 830 Then
                r6i83.Text = r6i83.Text + 1
            End If
        End If
        If TimeLeft.Text > 830 Then
            If TimeLeft.Text <= 840 Then
                r6i84.Text = r6i84.Text + 1
            End If
        End If
        If TimeLeft.Text > 840 Then
            If TimeLeft.Text <= 850 Then
                r6i85.Text = r6i85.Text + 1
            End If
        End If
        If TimeLeft.Text > 850 Then
            If TimeLeft.Text <= 860 Then
                r6i86.Text = r6i86.Text + 1
            End If
        End If
        If TimeLeft.Text > 860 Then
            If TimeLeft.Text <= 870 Then
                r6i87.Text = r6i87.Text + 1
            End If
        End If
        If TimeLeft.Text > 870 Then
            If TimeLeft.Text <= 880 Then
                r6i88.Text = r6i88.Text + 1
            End If
        End If
        If TimeLeft.Text > 880 Then
            If TimeLeft.Text <= 890 Then
                r6i89.Text = r6i89.Text + 1
            End If
        End If
        If TimeLeft.Text > 890 Then
            If TimeLeft.Text <= 900 Then
                r6i90.Text = r6i90.Text + 1
            End If
        End If
        If TimeLeft.Text > 900 Then
            If TimeLeft.Text <= 910 Then
                r6i91.Text = r6i91.Text + 1
            End If
        End If
        If TimeLeft.Text > 910 Then
            If TimeLeft.Text <= 920 Then
                r6i92.Text = r6i92.Text + 1
            End If
        End If
        If TimeLeft.Text > 920 Then
            If TimeLeft.Text <= 930 Then
                r6i93.Text = r6i93.Text + 1
            End If
        End If
        If TimeLeft.Text > 930 Then
            If TimeLeft.Text <= 940 Then
                r6i94.Text = r6i94.Text + 1
            End If
        End If
        If TimeLeft.Text > 940 Then
            If TimeLeft.Text <= 950 Then
                r6i95.Text = r6i95.Text + 1
            End If
        End If
        If TimeLeft.Text > 950 Then
            If TimeLeft.Text <= 960 Then
                r6i96.Text = r6i96.Text + 1
            End If
        End If
        If TimeLeft.Text > 960 Then
            If TimeLeft.Text <= 970 Then
                r6i97.Text = r6i97.Text + 1
            End If
        End If
        If TimeLeft.Text > 970 Then
            If TimeLeft.Text <= 980 Then
                r6i98.Text = r6i98.Text + 1
            End If
        End If
        If TimeLeft.Text > 980 Then
            If TimeLeft.Text <= 990 Then
                r6i99.Text = r6i99.Text + 1
            End If
        End If
        If TimeLeft.Text > 990 Then
            If TimeLeft.Text <= 1000 Then
                r6i100.Text = r6i100.Text + 1
            End If
        End If
        If TimeLeft.Text > 1000 Then
            If TimeLeft.Text <= 1010 Then
                r6i101.Text = r6i101.Text + 1
            End If
        End If
        If TimeLeft.Text > 1010 Then
            If TimeLeft.Text <= 1020 Then
                r6i102.Text = r6i102.Text + 1
            End If
        End If
        If TimeLeft.Text > 1020 Then
            If TimeLeft.Text <= 1030 Then
                r6i103.Text = r6i103.Text + 1
            End If
        End If
        If TimeLeft.Text > 1030 Then
            If TimeLeft.Text <= 1040 Then
                r6i104.Text = r6i104.Text + 1
            End If
        End If
        If TimeLeft.Text > 1040 Then
            If TimeLeft.Text <= 1050 Then
                r6i105.Text = r6i105.Text + 1
            End If
        End If
        If TimeLeft.Text > 1050 Then
            If TimeLeft.Text <= 1060 Then
                r6i106.Text = r6i106.Text + 1
            End If
        End If
        If TimeLeft.Text > 1060 Then
            If TimeLeft.Text <= 1070 Then
                r6i107.Text = r6i107.Text + 1
            End If
        End If
        If TimeLeft.Text > 1070 Then
            If TimeLeft.Text <= 1080 Then
                r6i108.Text = r6i108.Text + 1
            End If
        End If
        If TimeLeft.Text > 1080 Then
            If TimeLeft.Text <= 1090 Then
                r6i109.Text = r6i109.Text + 1
            End If
        End If
        If TimeLeft.Text > 1090 Then
            If TimeLeft.Text <= 1100 Then
                r6i200.Text = r6i200.Text + 1
            End If
        End If
        If TimeLeft.Text > 1100 Then
            If TimeLeft.Text <= 1110 Then
                r6i111.Text = r6i111.Text + 1
            End If
        End If
        If TimeLeft.Text > 1110 Then
            If TimeLeft.Text <= 1120 Then
                r6i112.Text = r6i112.Text + 1
            End If
        End If
        If TimeLeft.Text > 1120 Then
            If TimeLeft.Text <= 1130 Then
                r6i113.Text = r6i113.Text + 1
            End If
        End If
        If TimeLeft.Text > 1130 Then
            If TimeLeft.Text <= 1140 Then
                r6i114.Text = r6i114.Text + 1
            End If
        End If
        If TimeLeft.Text > 1140 Then
            If TimeLeft.Text <= 1150 Then
                r6i115.Text = r6i115.Text + 1
            End If
        End If
        If TimeLeft.Text > 1150 Then
            If TimeLeft.Text <= 1160 Then
                r6i116.Text = r6i116.Text + 1
            End If
        End If
        If TimeLeft.Text > 1160 Then
            If TimeLeft.Text <= 1170 Then
                r6i117.Text = r6i117.Text + 1
            End If
        End If
        If TimeLeft.Text > 1170 Then
            If TimeLeft.Text <= 1180 Then
                r6i118.Text = r6i118.Text + 1
            End If
        End If
        If TimeLeft.Text > 1180 Then
            If TimeLeft.Text <= 1190 Then
                r6i119.Text = r6i119.Text + 1
            End If
        End If
        If TimeLeft.Text > 1190 Then
            If TimeLeft.Text <= 1200 Then
                r6i120.Text = r6i120.Text + 1
            End If
        End If
        If TimeLeft.Text > 1200 Then
            If TimeLeft.Text <= 1210 Then
                r6i121.Text = r6i121.Text + 1
            End If
        End If
        If TimeLeft.Text > 1210 Then
            If TimeLeft.Text <= 1220 Then
                r6i122.Text = r6i122.Text + 1
            End If
        End If
        If TimeLeft.Text > 1220 Then
            If TimeLeft.Text <= 1230 Then
                r6i123.Text = r6i123.Text + 1
            End If
        End If
        If TimeLeft.Text > 1230 Then
            If TimeLeft.Text <= 1240 Then
                r6i124.Text = r6i124.Text + 1
            End If
        End If
        If TimeLeft.Text > 1240 Then
            If TimeLeft.Text <= 1250 Then
                r6i125.Text = r6i125.Text + 1
            End If
        End If
        If TimeLeft.Text > 1250 Then
            If TimeLeft.Text <= 1260 Then
                r6i126.Text = r6i126.Text + 1
            End If
        End If
        If TimeLeft.Text > 1260 Then
            If TimeLeft.Text <= 1270 Then
                r6i127.Text = r6i127.Text + 1
            End If
        End If
        If TimeLeft.Text > 1270 Then
            If TimeLeft.Text <= 1280 Then
                r6i128.Text = r6i128.Text + 1
            End If
        End If
        If TimeLeft.Text > 1280 Then
            If TimeLeft.Text <= 1290 Then
                r6i129.Text = r6i129.Text + 1
            End If
        End If
        If TimeLeft.Text > 1290 Then
            If TimeLeft.Text <= 1300 Then
                r6i130.Text = r6i130.Text + 1
            End If
        End If
        If TimeLeft.Text > 1300 Then
            If TimeLeft.Text <= 1310 Then
                r6i131.Text = r6i131.Text + 1
            End If
        End If
        If TimeLeft.Text > 1310 Then
            If TimeLeft.Text <= 1320 Then
                r6i132.Text = r6i132.Text + 1
            End If
        End If
        If TimeLeft.Text > 1320 Then
            If TimeLeft.Text <= 1330 Then
                r6i133.Text = r6i133.Text + 1
            End If
        End If
        If TimeLeft.Text > 1330 Then
            If TimeLeft.Text <= 1340 Then
                r6i134.Text = r6i134.Text + 1
            End If
        End If
        If TimeLeft.Text > 1340 Then
            If TimeLeft.Text <= 1350 Then
                r6i135.Text = r6i135.Text + 1
            End If
        End If
        If TimeLeft.Text > 1350 Then
            If TimeLeft.Text <= 1360 Then
                r6i136.Text = r6i136.Text + 1
            End If
        End If
        If TimeLeft.Text > 1360 Then
            If TimeLeft.Text <= 1370 Then
                r6i137.Text = r6i137.Text + 1
            End If
        End If
        If TimeLeft.Text > 1370 Then
            If TimeLeft.Text <= 1380 Then
                r6i138.Text = r6i138.Text + 1
            End If
        End If
        If TimeLeft.Text > 1380 Then
            If TimeLeft.Text <= 1390 Then
                r6i139.Text = r6i139.Text + 1
            End If
        End If
        If TimeLeft.Text > 1390 Then
            If TimeLeft.Text <= 1400 Then
                r6i140.Text = r6i140.Text + 1
            End If
        End If
        If TimeLeft.Text > 1400 Then
            If TimeLeft.Text <= 1410 Then
                r6i141.Text = r6i141.Text + 1
            End If
        End If
        If TimeLeft.Text > 1410 Then
            If TimeLeft.Text <= 1420 Then
                r6i142.Text = r6i142.Text + 1
            End If
        End If
        If TimeLeft.Text > 1420 Then
            If TimeLeft.Text <= 1430 Then
                r6i143.Text = r6i143.Text + 1
            End If
        End If
        If TimeLeft.Text > 1430 Then
            If TimeLeft.Text <= 1440 Then
                r6i144.Text = r6i144.Text + 1
            End If
        End If
        If TimeLeft.Text > 1440 Then
            If TimeLeft.Text <= 1450 Then
                r6i145.Text = r6i145.Text + 1
            End If
        End If
        If TimeLeft.Text > 1450 Then
            If TimeLeft.Text <= 1460 Then
                r6i146.Text = r6i146.Text + 1
            End If
        End If
        If TimeLeft.Text > 1460 Then
            If TimeLeft.Text <= 1470 Then
                r6i147.Text = r6i147.Text + 1
            End If
        End If
        If TimeLeft.Text > 1470 Then
            If TimeLeft.Text <= 1480 Then
                r6i148.Text = r6i148.Text + 1
            End If
        End If
        If TimeLeft.Text > 1480 Then
            If TimeLeft.Text <= 1490 Then
                r6i149.Text = r6i149.Text + 1
            End If
        End If
        If TimeLeft.Text > 1490 Then
            If TimeLeft.Text <= 1500 Then
                r6i150.Text = r6i150.Text + 1
            End If
        End If
        If TimeLeft.Text > 1500 Then
            If TimeLeft.Text <= 1510 Then
                r6i151.Text = r6i151.Text + 1
            End If
        End If
        If TimeLeft.Text > 1510 Then
            If TimeLeft.Text <= 1520 Then
                r6i152.Text = r6i152.Text + 1
            End If
        End If
        If TimeLeft.Text > 1520 Then
            If TimeLeft.Text <= 1530 Then
                r6i153.Text = r6i153.Text + 1
            End If
        End If
        If TimeLeft.Text > 1530 Then
            If TimeLeft.Text <= 1540 Then
                r6i154.Text = r6i154.Text + 1
            End If
        End If
        If TimeLeft.Text > 1540 Then
            If TimeLeft.Text <= 1550 Then
                r6i155.Text = r6i155.Text + 1
            End If
        End If
        If TimeLeft.Text > 1550 Then
            If TimeLeft.Text <= 1560 Then
                r6i156.Text = r6i156.Text + 1
            End If
        End If
        If TimeLeft.Text > 1560 Then
            If TimeLeft.Text <= 1570 Then
                r6i157.Text = r6i157.Text + 1
            End If
        End If
        If TimeLeft.Text > 1570 Then
            If TimeLeft.Text <= 1580 Then
                r6i158.Text = r6i158.Text + 1
            End If
        End If
        If TimeLeft.Text > 1580 Then
            If TimeLeft.Text <= 1590 Then
                r6i159.Text = r6i159.Text + 1
            End If
        End If
        If TimeLeft.Text > 1590 Then
            If TimeLeft.Text <= 1600 Then
                r6i160.Text = r6i160.Text + 1
            End If
        End If
        If TimeLeft.Text > 1600 Then
            If TimeLeft.Text <= 1610 Then
                r6i161.Text = r6i161.Text + 1
            End If
        End If
        If TimeLeft.Text > 1610 Then
            If TimeLeft.Text <= 1620 Then
                r6i162.Text = r6i162.Text + 1
            End If
        End If
        If TimeLeft.Text > 1620 Then
            If TimeLeft.Text <= 1630 Then
                r6i163.Text = r6i163.Text + 1
            End If
        End If
        If TimeLeft.Text > 1630 Then
            If TimeLeft.Text <= 1640 Then
                r6i164.Text = r6i164.Text + 1
            End If
        End If
        If TimeLeft.Text > 1640 Then
            If TimeLeft.Text <= 1650 Then
                r6i165.Text = r6i165.Text + 1
            End If
        End If
        If TimeLeft.Text > 1650 Then
            If TimeLeft.Text <= 1660 Then
                r6i166.Text = r6i166.Text + 1
            End If
        End If
        If TimeLeft.Text > 1660 Then
            If TimeLeft.Text <= 1670 Then
                r6i167.Text = r6i167.Text + 1
            End If
        End If
        If TimeLeft.Text > 1670 Then
            If TimeLeft.Text <= 1680 Then
                r6i168.Text = r6i168.Text + 1
            End If
        End If
        If TimeLeft.Text > 1680 Then
            If TimeLeft.Text <= 1690 Then
                r6i169.Text = r6i169.Text + 1
            End If
        End If
        If TimeLeft.Text > 1690 Then
            If TimeLeft.Text <= 1700 Then
                r6i170.Text = r6i170.Text + 1
            End If
        End If
        If TimeLeft.Text > 1700 Then
            If TimeLeft.Text <= 1710 Then
                r6i171.Text = r6i171.Text + 1
            End If
        End If
        If TimeLeft.Text > 1710 Then
            If TimeLeft.Text <= 1720 Then
                r6i172.Text = r6i172.Text + 1
            End If
        End If
        If TimeLeft.Text > 1720 Then
            If TimeLeft.Text <= 1730 Then
                r6i173.Text = r6i173.Text + 1
            End If
        End If
        If TimeLeft.Text > 1730 Then
            If TimeLeft.Text <= 1740 Then
                r6i174.Text = r6i174.Text + 1
            End If
        End If
        If TimeLeft.Text > 1740 Then
            If TimeLeft.Text <= 1750 Then
                r6i175.Text = r6i175.Text + 1
            End If
        End If
        If TimeLeft.Text > 1750 Then
            If TimeLeft.Text <= 1760 Then
                r6i176.Text = r6i176.Text + 1
            End If
        End If
        If TimeLeft.Text > 1760 Then
            If TimeLeft.Text <= 1770 Then
                r6i177.Text = r6i177.Text + 1
            End If
        End If
        If TimeLeft.Text > 1770 Then
            If TimeLeft.Text <= 1780 Then
                r6i178.Text = r6i178.Text + 1
            End If
        End If
        If TimeLeft.Text > 1780 Then
            If TimeLeft.Text <= 1790 Then
                r6i179.Text = r6i179.Text + 1
            End If
        End If
        If TimeLeft.Text > 1790 Then
            If TimeLeft.Text <= 1800 Then
                r6i180.Text = r6i180.Text + 1
            End If
        End If
        If TimeLeft.Text > 1800 Then
            If TimeLeft.Text <= 1810 Then
                r6i181.Text = r6i181.Text + 1
            End If
        End If
        If TimeLeft.Text > 1810 Then
            If TimeLeft.Text <= 1820 Then
                r6i182.Text = r6i182.Text + 1
            End If
        End If
        If TimeLeft.Text > 1820 Then
            If TimeLeft.Text <= 1830 Then
                r6i183.Text = r6i183.Text + 1
            End If
        End If
        If TimeLeft.Text > 1830 Then
            If TimeLeft.Text <= 1840 Then
                r6i184.Text = r6i184.Text + 1
            End If
        End If
        If TimeLeft.Text > 1840 Then
            If TimeLeft.Text <= 1850 Then
                r6i185.Text = r6i185.Text + 1
            End If
        End If
        If TimeLeft.Text > 1850 Then
            If TimeLeft.Text <= 1860 Then
                r6i186.Text = r6i186.Text + 1
            End If
        End If
        If TimeLeft.Text > 1860 Then
            If TimeLeft.Text <= 1870 Then
                r6i187.Text = r6i187.Text + 1
            End If
        End If
        If TimeLeft.Text > 1870 Then
            If TimeLeft.Text <= 1880 Then
                r6i188.Text = r6i188.Text + 1
            End If
        End If
        If TimeLeft.Text > 1880 Then
            If TimeLeft.Text <= 1890 Then
                r6i189.Text = r6i189.Text + 1
            End If
        End If
        If TimeLeft.Text > 1890 Then
            If TimeLeft.Text <= 1900 Then
                r6i190.Text = r6i190.Text + 1
            End If
        End If
        If TimeLeft.Text > 1900 Then
            If TimeLeft.Text <= 1910 Then
                r6i191.Text = r6i191.Text + 1
            End If
        End If
        If TimeLeft.Text > 1910 Then
            If TimeLeft.Text <= 1920 Then
                r6i192.Text = r6i192.Text + 1
            End If
        End If
        If TimeLeft.Text > 1920 Then
            If TimeLeft.Text <= 1930 Then
                r6i193.Text = r6i193.Text + 1
            End If
        End If
        If TimeLeft.Text > 1930 Then
            If TimeLeft.Text <= 1940 Then
                r6i194.Text = r6i194.Text + 1
            End If
        End If
        If TimeLeft.Text > 1940 Then
            If TimeLeft.Text <= 1950 Then
                r6i195.Text = r6i195.Text + 1
            End If
        End If
        If TimeLeft.Text > 1950 Then
            If TimeLeft.Text <= 1960 Then
                r6i196.Text = r6i196.Text + 1
            End If
        End If
        If TimeLeft.Text > 1960 Then
            If TimeLeft.Text <= 1970 Then
                r6i197.Text = r6i197.Text + 1
            End If
        End If
        If TimeLeft.Text > 1970 Then
            If TimeLeft.Text <= 1980 Then
                r6i198.Text = r6i198.Text + 1
            End If
        End If
        If TimeLeft.Text > 1980 Then
            If TimeLeft.Text <= 1990 Then
                r6i199.Text = r6i199.Text + 1
            End If
        End If
        If TimeLeft.Text > 2000 Then
            If TimeLeft.Text <= 2010 Then
                r6i201.Text = r6i201.Text + 1
            End If
        End If
        If TimeLeft.Text > 2010 Then
            If TimeLeft.Text <= 2020 Then
                r6i202.Text = r6i202.Text + 1
            End If
        End If
        If TimeLeft.Text > 2020 Then
            If TimeLeft.Text <= 2030 Then
                r6i203.Text = r6i203.Text + 1
            End If
        End If
        If TimeLeft.Text > 2030 Then
            If TimeLeft.Text <= 2040 Then
                r6i204.Text = r6i204.Text + 1
            End If
        End If
        If TimeLeft.Text > 2040 Then
            If TimeLeft.Text <= 2050 Then
                r6i205.Text = r6i205.Text + 1
            End If
        End If
        If TimeLeft.Text > 2050 Then
            If TimeLeft.Text <= 2060 Then
                r6i206.Text = r6i206.Text + 1
            End If
        End If
        If TimeLeft.Text > 2060 Then
            If TimeLeft.Text <= 2070 Then
                r6i207.Text = r6i207.Text + 1
            End If
        End If
        If TimeLeft.Text > 2070 Then
            If TimeLeft.Text <= 2080 Then
                r6i208.Text = r6i208.Text + 1
            End If
        End If
        If TimeLeft.Text > 2080 Then
            If TimeLeft.Text <= 2090 Then
                r6i209.Text = r6i209.Text + 1
            End If
        End If
        If TimeLeft.Text > 2090 Then
            If TimeLeft.Text <= 2100 Then
                r6i210.Text = r6i210.Text + 1
            End If
        End If
        If TimeLeft.Text > 2100 Then
            If TimeLeft.Text <= 2110 Then
                r6i211.Text = r6i211.Text + 1
            End If
        End If
        If TimeLeft.Text > 2110 Then
            If TimeLeft.Text <= 2120 Then
                r6i212.Text = r6i212.Text + 1
            End If
        End If
        If TimeLeft.Text > 2120 Then
            If TimeLeft.Text <= 2130 Then
                r6i213.Text = r6i213.Text + 1
            End If
        End If
        If TimeLeft.Text > 2130 Then
            If TimeLeft.Text <= 2140 Then
                r6i214.Text = r6i214.Text + 1
            End If
        End If
        If TimeLeft.Text > 2140 Then
            If TimeLeft.Text <= 2150 Then
                r6i215.Text = r6i215.Text + 1
            End If
        End If
        If TimeLeft.Text > 2150 Then
            If TimeLeft.Text <= 2160 Then
                r6i216.Text = r6i216.Text + 1
            End If
        End If
        If TimeLeft.Text > 2160 Then
            If TimeLeft.Text <= 2170 Then
                r6i217.Text = r6i217.Text + 1
            End If
        End If
        If TimeLeft.Text > 2170 Then
            If TimeLeft.Text <= 2180 Then
                r6i218.Text = r6i218.Text + 1
            End If
        End If
        If TimeLeft.Text > 2180 Then
            If TimeLeft.Text <= 2190 Then
                r6i219.Text = r6i219.Text + 1
            End If
        End If
        If TimeLeft.Text > 2190 Then
            If TimeLeft.Text <= 2200 Then
                r6i220.Text = r6i220.Text + 1
            End If
        End If
        If TimeLeft.Text > 2200 Then
            If TimeLeft.Text <= 2210 Then
                r6i221.Text = r6i221.Text + 1
            End If
        End If
        If TimeLeft.Text > 2210 Then
            If TimeLeft.Text <= 2220 Then
                r6i222.Text = r6i222.Text + 1
            End If
        End If
        If TimeLeft.Text > 2220 Then
            If TimeLeft.Text <= 2230 Then
                r6i223.Text = r6i223.Text + 1
            End If
        End If
        If TimeLeft.Text > 2230 Then
            If TimeLeft.Text <= 2240 Then
                r6i224.Text = r6i224.Text + 1
            End If
        End If
        If TimeLeft.Text > 2240 Then
            If TimeLeft.Text <= 2250 Then
                r6i225.Text = r6i225.Text + 1
            End If
        End If
        If TimeLeft.Text > 2250 Then
            If TimeLeft.Text <= 2260 Then
                r6i226.Text = r6i226.Text + 1
            End If
        End If
        If TimeLeft.Text > 2260 Then
            If TimeLeft.Text <= 2270 Then
                r6i227.Text = r6i227.Text + 1
            End If
        End If
        If TimeLeft.Text > 2270 Then
            If TimeLeft.Text <= 2280 Then
                r6i228.Text = r6i228.Text + 1
            End If
        End If
        If TimeLeft.Text > 2280 Then
            If TimeLeft.Text <= 2290 Then
                r6i229.Text = r6i229.Text + 1
            End If
        End If
        If TimeLeft.Text > 2290 Then
            If TimeLeft.Text <= 2300 Then
                r6i230.Text = r6i230.Text + 1
            End If
        End If
        If TimeLeft.Text > 2300 Then
            If TimeLeft.Text <= 2310 Then
                r6i231.Text = r6i231.Text + 1
            End If
        End If
        If TimeLeft.Text > 2310 Then
            If TimeLeft.Text <= 2320 Then
                r6i232.Text = r6i232.Text + 1
            End If
        End If
        If TimeLeft.Text > 2320 Then
            If TimeLeft.Text <= 2330 Then
                r6i233.Text = r6i233.Text + 1
            End If
        End If
        If TimeLeft.Text > 2330 Then
            If TimeLeft.Text <= 2340 Then
                r6i234.Text = r6i234.Text + 1
            End If
        End If
        If TimeLeft.Text > 2340 Then
            If TimeLeft.Text <= 2350 Then
                r6i235.Text = r6i235.Text + 1
            End If
        End If
        If TimeLeft.Text > 2350 Then
            If TimeLeft.Text <= 2360 Then
                r6i236.Text = r6i236.Text + 1
            End If
        End If
        If TimeLeft.Text > 2360 Then
            If TimeLeft.Text <= 2370 Then
                r6i237.Text = r6i237.Text + 1
            End If
        End If
        If TimeLeft.Text > 2370 Then
            If TimeLeft.Text <= 2380 Then
                r6i238.Text = r6i238.Text + 1
            End If
        End If
        If TimeLeft.Text > 2380 Then
            If TimeLeft.Text <= 2390 Then
                r6i239.Text = r6i239.Text + 1
            End If
        End If
        If TimeLeft.Text > 2390 Then
            If TimeLeft.Text <= 2400 Then
                r6i240.Text = r6i240.Text + 1
            End If
        End If
        If TimeLeft.Text > 2400 Then
            If TimeLeft.Text <= 2410 Then
                r6i241.Text = r6i241.Text + 1
            End If
        End If
        If TimeLeft.Text > 2410 Then
            If TimeLeft.Text <= 2420 Then
                r6i242.Text = r6i242.Text + 1
            End If
        End If
        If TimeLeft.Text > 2420 Then
            If TimeLeft.Text <= 2430 Then
                r6i243.Text = r6i243.Text + 1
            End If
        End If
        If TimeLeft.Text > 2430 Then
            If TimeLeft.Text <= 2440 Then
                r6i244.Text = r6i244.Text + 1
            End If
        End If
        If TimeLeft.Text > 2440 Then
            If TimeLeft.Text <= 2450 Then
                r6i245.Text = r6i245.Text + 1
            End If
        End If
        If TimeLeft.Text > 2450 Then
            If TimeLeft.Text <= 2460 Then
                r6i246.Text = r6i246.Text + 1
            End If
        End If
        If TimeLeft.Text > 2460 Then
            If TimeLeft.Text <= 2470 Then
                r6i247.Text = r6i247.Text + 1
            End If
        End If
        If TimeLeft.Text > 2470 Then
            If TimeLeft.Text <= 2480 Then
                r6i248.Text = r6i248.Text + 1
            End If
        End If
        If TimeLeft.Text > 2480 Then
            If TimeLeft.Text <= 2490 Then
                r6i249.Text = r6i249.Text + 1
            End If
        End If
        If TimeLeft.Text > 2490 Then
            If TimeLeft.Text <= 2500 Then
                r6i250.Text = r6i250.Text + 1
            End If
        End If
        If TimeLeft.Text > 2500 Then
            If TimeLeft.Text <= 2510 Then
                r6i251.Text = r6i251.Text + 1
            End If
        End If
        If TimeLeft.Text > 2510 Then
            If TimeLeft.Text <= 2520 Then
                r6i252.Text = r6i252.Text + 1
            End If
        End If
        If TimeLeft.Text > 2520 Then
            If TimeLeft.Text <= 2530 Then
                r6i253.Text = r6i253.Text + 1
            End If
        End If
        If TimeLeft.Text > 2530 Then
            If TimeLeft.Text <= 2540 Then
                r6i254.Text = r6i254.Text + 1
            End If
        End If
        If TimeLeft.Text > 2540 Then
            If TimeLeft.Text <= 2550 Then
                r6i255.Text = r6i255.Text + 1
            End If
        End If
        If TimeLeft.Text > 2550 Then
            If TimeLeft.Text <= 2560 Then
                r6i256.Text = r6i256.Text + 1
            End If
        End If
        If TimeLeft.Text > 2560 Then
            If TimeLeft.Text <= 2570 Then
                r6i257.Text = r6i257.Text + 1
            End If
        End If
        If TimeLeft.Text > 2570 Then
            If TimeLeft.Text <= 2580 Then
                r6i258.Text = r6i258.Text + 1
            End If
        End If
        If TimeLeft.Text > 2580 Then
            If TimeLeft.Text <= 2590 Then
                r6i259.Text = r6i259.Text + 1
            End If
        End If
        If TimeLeft.Text > 2590 Then
            If TimeLeft.Text <= 2600 Then
                r6i260.Text = r6i260.Text + 1
            End If
        End If
        If TimeLeft.Text > 2600 Then
            If TimeLeft.Text <= 2610 Then
                r6i261.Text = r6i261.Text + 1
            End If
        End If
        If TimeLeft.Text > 2610 Then
            If TimeLeft.Text <= 2620 Then
                r6i262.Text = r6i262.Text + 1
            End If
        End If
        If TimeLeft.Text > 2620 Then
            If TimeLeft.Text <= 2630 Then
                r6i263.Text = r6i263.Text + 1
            End If
        End If
        If TimeLeft.Text > 2630 Then
            If TimeLeft.Text <= 2640 Then
                r6i264.Text = r6i264.Text + 1
            End If
        End If
        If TimeLeft.Text > 2640 Then
            If TimeLeft.Text <= 2650 Then
                r6i265.Text = r6i265.Text + 1
            End If
        End If
        If TimeLeft.Text > 2650 Then
            If TimeLeft.Text <= 2660 Then
                r6i266.Text = r6i266.Text + 1
            End If
        End If
        If TimeLeft.Text > 2660 Then
            If TimeLeft.Text <= 2670 Then
                r6i267.Text = r6i267.Text + 1
            End If
        End If
        If TimeLeft.Text > 2670 Then
            If TimeLeft.Text <= 2680 Then
                r6i268.Text = r6i268.Text + 1
            End If
        End If
        If TimeLeft.Text > 2680 Then
            If TimeLeft.Text <= 2690 Then
                r6i269.Text = r6i269.Text + 1
            End If
        End If
        If TimeLeft.Text > 2690 Then
            If TimeLeft.Text <= 2700 Then
                r6i270.Text = r6i270.Text + 1
            End If
        End If
        If TimeLeft.Text > 2700 Then
            If TimeLeft.Text <= 2710 Then
                r6i271.Text = r6i271.Text + 1
            End If
        End If
        If TimeLeft.Text > 2710 Then
            If TimeLeft.Text <= 2720 Then
                r6i272.Text = r6i272.Text + 1
            End If
        End If
        If TimeLeft.Text > 2720 Then
            If TimeLeft.Text <= 2730 Then
                r6i273.Text = r6i273.Text + 1
            End If
        End If
        If TimeLeft.Text > 2730 Then
            If TimeLeft.Text <= 2740 Then
                r6i274.Text = r6i274.Text + 1
            End If
        End If
        If TimeLeft.Text > 2740 Then
            If TimeLeft.Text <= 2750 Then
                r6i275.Text = r6i275.Text + 1
            End If
        End If
        If TimeLeft.Text > 2750 Then
            If TimeLeft.Text <= 2760 Then
                r6i276.Text = r6i276.Text + 1
            End If
        End If
        If TimeLeft.Text > 2760 Then
            If TimeLeft.Text <= 2770 Then
                r6i277.Text = r6i277.Text + 1
            End If
        End If
        If TimeLeft.Text > 2770 Then
            If TimeLeft.Text <= 2780 Then
                r6i278.Text = r6i278.Text + 1
            End If
        End If
        If TimeLeft.Text > 2780 Then
            If TimeLeft.Text <= 2790 Then
                r6i279.Text = r6i279.Text + 1
            End If
        End If
        If TimeLeft.Text > 2790 Then
            If TimeLeft.Text <= 2800 Then
                r6i281.Text = r6i280.Text + 1
            End If
        End If
        If TimeLeft.Text > 2800 Then
            If TimeLeft.Text <= 2810 Then
                r6i281.Text = r6i281.Text + 1
            End If
        End If
        If TimeLeft.Text > 2810 Then
            If TimeLeft.Text <= 2820 Then
                r6i282.Text = r6i282.Text + 1
            End If
        End If
        If TimeLeft.Text > 2820 Then
            If TimeLeft.Text <= 2830 Then
                r6i283.Text = r6i283.Text + 1
            End If
        End If
        If TimeLeft.Text > 2830 Then
            If TimeLeft.Text <= 2840 Then
                r6i284.Text = r6i284.Text + 1
            End If
        End If
        If TimeLeft.Text > 2840 Then
            If TimeLeft.Text <= 2850 Then
                r6i285.Text = r6i285.Text + 1
            End If
        End If
        If TimeLeft.Text > 2850 Then
            If TimeLeft.Text <= 2860 Then
                r6i286.Text = r6i286.Text + 1
            End If
        End If
        If TimeLeft.Text > 2860 Then
            If TimeLeft.Text <= 2870 Then
                r6i287.Text = r6i287.Text + 1
            End If
        End If
        If TimeLeft.Text > 2870 Then
            If TimeLeft.Text <= 2880 Then
                r6i288.Text = r6i288.Text + 1
            End If
        End If

    End Sub

    'Code for inactive control response. 
    Private Sub r0301_Click(sender As Object, e As EventArgs) Handles r0301.Click
        r0301.Visible = False
        r0302.Visible = True
        r0101.Visible = True
        r0102.Visible = False
        r0103.Visible = False
        r0104.Visible = False
        r0105.Visible = False
        r0106.Visible = False
        r0201.Visible = True
        r0202.Visible = False
        r0203.Visible = False
        r0204.Visible = False
        r0205.Visible = False
        r0206.Visible = False
        r0401.Visible = True
        r0402.Visible = False
        r0403.Visible = False
        r0404.Visible = False
        r0405.Visible = False
        r0406.Visible = False
        r0501.Visible = True
        r0502.Visible = False
        r0503.Visible = False
        r0504.Visible = False
        r0505.Visible = False
        r0506.Visible = False
        r0601.Visible = True
        r0602.Visible = False
        r0603.Visible = False
        r0604.Visible = False
        r0605.Visible = False
        r0606.Visible = False
    End Sub
    Private Sub r0302_Click(sender As Object, e As EventArgs) Handles r0302.Click
        r0302.Visible = False
        r0303.Visible = True
    End Sub
    Private Sub r0303_Click(sender As Object, e As EventArgs) Handles r0303.Click
        r0303.Visible = False
        r0304.Visible = True
    End Sub
    Private Sub r0304_Click(sender As Object, e As EventArgs) Handles r0304.Click
        r0304.Visible = False
        r0305.Visible = True
    End Sub
    Private Sub r0305_Click(sender As Object, e As EventArgs) Handles r0305.Click
        r0305.Visible = False
        r0306.Visible = True
    End Sub
    Private Sub r0306_Click(sender As Object, e As EventArgs) Handles r0306.Click
        r0306.Visible = False
        r0301.Visible = True
        'Code for changeover (CO) response. That is, the first response following switching cannot contact reinforcement. 
        r1CO.Text = 0
        r2CO.Text = 0
        r3CO.Text = Val(r3CO.Text) + 1
        r4CO.Text = 0
        r5CO.Text = 0
        r6CO.Text = 0
        'Code for count per 2-min session. 
        If TimeLeft.Text > 0 Then
            If TimeLeft.Text <= 120 Then
                r3sess1.Text = r3sess1.Text + 1
            End If
        End If
        If TimeLeft.Text > 120 Then
            If TimeLeft.Text <= 240 Then
                r3sess2.Text = r3sess2.Text + 1
            End If
        End If
        If TimeLeft.Text > 240 Then
            If TimeLeft.Text <= 360 Then
                r3sess3.Text = r3sess3.Text + 1
            End If
        End If
        If TimeLeft.Text > 360 Then
            If TimeLeft.Text <= 480 Then
                r3sess4.Text = r3sess4.Text + 1
            End If
        End If
        If TimeLeft.Text > 480 Then
            If TimeLeft.Text <= 600 Then
                r3sess5.Text = r3sess5.Text + 1
            End If
        End If
        If TimeLeft.Text > 600 Then
            If TimeLeft.Text <= 720 Then
                r3sess6.Text = r3sess6.Text + 1
            End If
        End If
        If TimeLeft.Text > 720 Then
            If TimeLeft.Text <= 840 Then
                r3sess7.Text = r3sess7.Text + 1
            End If
        End If
        If TimeLeft.Text > 840 Then
            If TimeLeft.Text <= 960 Then
                r3sess8.Text = r3sess8.Text + 1
            End If
        End If
        If TimeLeft.Text > 960 Then
            If TimeLeft.Text <= 1080 Then
                r3sess9.Text = r3sess9.Text + 1
            End If
        End If
        If TimeLeft.Text > 1080 Then
            If TimeLeft.Text <= 1200 Then
                r3sess10.Text = r3sess10.Text + 1
            End If
        End If
        If TimeLeft.Text > 1200 Then
            If TimeLeft.Text <= 1320 Then
                r3sess11.Text = r3sess11.Text + 1
            End If
        End If
        If TimeLeft.Text > 1320 Then
            If TimeLeft.Text <= 1440 Then
                r3sess12.Text = r3sess12.Text + 1
            End If
        End If
        If TimeLeft.Text > 1440 Then
            If TimeLeft.Text <= 1560 Then
                r3sess13.Text = r3sess13.Text + 1
            End If
        End If
        If TimeLeft.Text > 1560 Then
            If TimeLeft.Text <= 1680 Then
                r3sess14.Text = r3sess14.Text + 1
            End If
        End If
        If TimeLeft.Text > 1680 Then
            If TimeLeft.Text <= 1800 Then
                r3sess15.Text = r3sess15.Text + 1
            End If
        End If
        If TimeLeft.Text > 1800 Then
            If TimeLeft.Text <= 1920 Then
                r3sess16.Text = r3sess16.Text + 1
            End If
        End If
        If TimeLeft.Text > 1920 Then
            If TimeLeft.Text <= 2040 Then
                r3sess17.Text = r3sess17.Text + 1
            End If
        End If
        If TimeLeft.Text > 2040 Then
            If TimeLeft.Text <= 2160 Then
                r3sess18.Text = r3sess18.Text + 1
            End If
        End If
        If TimeLeft.Text > 2160 Then
            If TimeLeft.Text <= 2280 Then
                r3sess19.Text = r3sess19.Text + 1
            End If
        End If
        If TimeLeft.Text > 2280 Then
            If TimeLeft.Text <= 2400 Then
                r3sess20.Text = r3sess20.Text + 1
            End If
        End If
        If TimeLeft.Text > 2400 Then
            If TimeLeft.Text <= 2520 Then
                r3sess21.Text = r3sess21.Text + 1
            End If
        End If
        If TimeLeft.Text > 2520 Then
            If TimeLeft.Text <= 2640 Then
                r3sess22.Text = r3sess22.Text + 1
            End If
        End If
        If TimeLeft.Text > 2640 Then
            If TimeLeft.Text <= 2760 Then
                r3sess23.Text = r3sess23.Text + 1
            End If
        End If
        If TimeLeft.Text > 2760 Then
            If TimeLeft.Text <= 2880 Then
                r3sess24.Text = r3sess24.Text + 1
            End If
        End If

        'Code for count per 10-sec interval.
        If TimeLeft.Text > 0 Then
            If TimeLeft.Text <= 10 Then
                r3i01.Text = r3i01.Text + 1
            End If
        End If
        If TimeLeft.Text > 10 Then
            If TimeLeft.Text <= 20 Then
                r3i02.Text = r3i02.Text + 1
            End If
        End If
        If TimeLeft.Text > 20 Then
            If TimeLeft.Text <= 30 Then
                r3i03.Text = r3i03.Text + 1
            End If
        End If
        If TimeLeft.Text > 30 Then
            If TimeLeft.Text <= 40 Then
                r3i04.Text = r3i04.Text + 1
            End If
        End If
        If TimeLeft.Text > 40 Then
            If TimeLeft.Text <= 50 Then
                r3i05.Text = r3i05.Text + 1
            End If
        End If
        If TimeLeft.Text > 50 Then
            If TimeLeft.Text <= 60 Then
                r3i06.Text = r3i06.Text + 1
            End If
        End If
        If TimeLeft.Text > 60 Then
            If TimeLeft.Text <= 70 Then
                r3i07.Text = r3i07.Text + 1
            End If
        End If
        If TimeLeft.Text > 70 Then
            If TimeLeft.Text <= 80 Then
                r3i08.Text = r3i08.Text + 1
            End If
        End If
        If TimeLeft.Text > 80 Then
            If TimeLeft.Text <= 90 Then
                r3i09.Text = r3i09.Text + 1
            End If
        End If
        If TimeLeft.Text > 90 Then
            If TimeLeft.Text <= 100 Then
                r3i10.Text = r3i10.Text + 1
            End If
        End If
        If TimeLeft.Text > 100 Then
            If TimeLeft.Text <= 110 Then
                r3i11.Text = r3i11.Text + 1
            End If
        End If
        If TimeLeft.Text > 110 Then
            If TimeLeft.Text <= 120 Then
                r3i12.Text = r3i12.Text + 1
            End If
        End If
        If TimeLeft.Text > 120 Then
            If TimeLeft.Text <= 130 Then
                r3i13.Text = r3i13.Text + 1
            End If
        End If
        If TimeLeft.Text > 130 Then
            If TimeLeft.Text <= 140 Then
                r3i14.Text = r3i14.Text + 1
            End If
        End If
        If TimeLeft.Text > 140 Then
            If TimeLeft.Text <= 150 Then
                r3i15.Text = r3i15.Text + 1
            End If
        End If
        If TimeLeft.Text > 150 Then
            If TimeLeft.Text <= 160 Then
                r3i16.Text = r3i16.Text + 1
            End If
        End If
        If TimeLeft.Text > 160 Then
            If TimeLeft.Text <= 170 Then
                r3i17.Text = r3i17.Text + 1
            End If
        End If
        If TimeLeft.Text > 170 Then
            If TimeLeft.Text <= 180 Then
                r3i18.Text = r3i18.Text + 1
            End If
        End If
        If TimeLeft.Text > 180 Then
            If TimeLeft.Text <= 190 Then
                r3i19.Text = r3i19.Text + 1
            End If
        End If
        If TimeLeft.Text > 190 Then
            If TimeLeft.Text <= 200 Then
                r3i20.Text = r3i20.Text + 1
            End If
        End If
        If TimeLeft.Text > 200 Then
            If TimeLeft.Text <= 210 Then
                r3i21.Text = r3i21.Text + 1
            End If
        End If
        If TimeLeft.Text > 210 Then
            If TimeLeft.Text <= 220 Then
                r3i22.Text = r3i22.Text + 1
            End If
        End If
        If TimeLeft.Text > 220 Then
            If TimeLeft.Text <= 230 Then
                r3i23.Text = r3i23.Text + 1
            End If
        End If
        If TimeLeft.Text > 230 Then
            If TimeLeft.Text <= 240 Then
                r3i24.Text = r3i24.Text + 1
            End If
        End If
        If TimeLeft.Text > 240 Then
            If TimeLeft.Text <= 250 Then
                r3i25.Text = r3i25.Text + 1
            End If
        End If
        If TimeLeft.Text > 250 Then
            If TimeLeft.Text <= 260 Then
                r3i26.Text = r3i26.Text + 1
            End If
        End If
        If TimeLeft.Text > 260 Then
            If TimeLeft.Text <= 270 Then
                r3i27.Text = r3i27.Text + 1
            End If
        End If
        If TimeLeft.Text > 270 Then
            If TimeLeft.Text <= 280 Then
                r3i28.Text = r3i28.Text + 1
            End If
        End If
        If TimeLeft.Text > 280 Then
            If TimeLeft.Text <= 290 Then
                r3i29.Text = r3i29.Text + 1
            End If
        End If
        If TimeLeft.Text > 290 Then
            If TimeLeft.Text <= 300 Then
                r3i30.Text = r3i30.Text + 1
            End If
        End If
        If TimeLeft.Text > 300 Then
            If TimeLeft.Text <= 310 Then
                r3i31.Text = r3i31.Text + 1
            End If
        End If
        If TimeLeft.Text > 310 Then
            If TimeLeft.Text <= 320 Then
                r3i32.Text = r3i32.Text + 1
            End If
        End If
        If TimeLeft.Text > 320 Then
            If TimeLeft.Text <= 330 Then
                r3i33.Text = r3i33.Text + 1
            End If
        End If
        If TimeLeft.Text > 330 Then
            If TimeLeft.Text <= 340 Then
                r3i34.Text = r3i34.Text + 1
            End If
        End If
        If TimeLeft.Text > 340 Then
            If TimeLeft.Text <= 350 Then
                r3i35.Text = r3i35.Text + 1
            End If
        End If
        If TimeLeft.Text > 350 Then
            If TimeLeft.Text <= 360 Then
                r3i36.Text = r3i36.Text + 1
            End If
        End If
        If TimeLeft.Text > 360 Then
            If TimeLeft.Text <= 370 Then
                r3i37.Text = r3i37.Text + 1
            End If
        End If
        If TimeLeft.Text > 370 Then
            If TimeLeft.Text <= 380 Then
                r3i38.Text = r3i38.Text + 1
            End If
        End If
        If TimeLeft.Text > 380 Then
            If TimeLeft.Text <= 390 Then
                r3i39.Text = r3i39.Text + 1
            End If
        End If
        If TimeLeft.Text > 390 Then
            If TimeLeft.Text <= 400 Then
                r3i40.Text = r3i40.Text + 1
            End If
        End If
        If TimeLeft.Text > 400 Then
            If TimeLeft.Text <= 410 Then
                r3i41.Text = r3i41.Text + 1
            End If
        End If
        If TimeLeft.Text > 410 Then
            If TimeLeft.Text <= 420 Then
                r3i42.Text = r3i42.Text + 1
            End If
        End If
        If TimeLeft.Text > 420 Then
            If TimeLeft.Text <= 430 Then
                r3i43.Text = r3i43.Text + 1
            End If
        End If
        If TimeLeft.Text > 430 Then
            If TimeLeft.Text <= 440 Then
                r3i44.Text = r3i44.Text + 1
            End If
        End If
        If TimeLeft.Text > 440 Then
            If TimeLeft.Text <= 450 Then
                r3i45.Text = r3i45.Text + 1
            End If
        End If
        If TimeLeft.Text > 450 Then
            If TimeLeft.Text <= 460 Then
                r3i46.Text = r3i46.Text + 1
            End If
        End If
        If TimeLeft.Text > 460 Then
            If TimeLeft.Text <= 470 Then
                r3i47.Text = r3i47.Text + 1
            End If
        End If
        If TimeLeft.Text > 470 Then
            If TimeLeft.Text <= 480 Then
                r3i48.Text = r3i48.Text + 1
            End If
        End If
        If TimeLeft.Text > 480 Then
            If TimeLeft.Text <= 490 Then
                r3i49.Text = r3i49.Text + 1
            End If
        End If
        If TimeLeft.Text > 490 Then
            If TimeLeft.Text <= 500 Then
                r3i50.Text = r3i50.Text + 1
            End If
        End If
        If TimeLeft.Text > 500 Then
            If TimeLeft.Text <= 510 Then
                r3i51.Text = r3i51.Text + 1
            End If
        End If
        If TimeLeft.Text > 510 Then
            If TimeLeft.Text <= 520 Then
                r3i52.Text = r3i52.Text + 1
            End If
        End If
        If TimeLeft.Text > 520 Then
            If TimeLeft.Text <= 530 Then
                r3i53.Text = r3i53.Text + 1
            End If
        End If
        If TimeLeft.Text > 530 Then
            If TimeLeft.Text <= 540 Then
                r3i54.Text = r3i54.Text + 1
            End If
        End If
        If TimeLeft.Text > 540 Then
            If TimeLeft.Text <= 550 Then
                r3i55.Text = r3i55.Text + 1
            End If
        End If
        If TimeLeft.Text > 550 Then
            If TimeLeft.Text <= 560 Then
                r3i56.Text = r3i56.Text + 1
            End If
        End If
        If TimeLeft.Text > 560 Then
            If TimeLeft.Text <= 570 Then
                r3i57.Text = r3i57.Text + 1
            End If
        End If
        If TimeLeft.Text > 570 Then
            If TimeLeft.Text <= 580 Then
                r3i58.Text = r3i58.Text + 1
            End If
        End If
        If TimeLeft.Text > 580 Then
            If TimeLeft.Text <= 590 Then
                r3i59.Text = r3i59.Text + 1
            End If
        End If
        If TimeLeft.Text > 590 Then
            If TimeLeft.Text <= 600 Then
                r3i60.Text = r3i60.Text + 1
            End If
        End If
        If TimeLeft.Text > 600 Then
            If TimeLeft.Text <= 610 Then
                r3i61.Text = r3i61.Text + 1
            End If
        End If
        If TimeLeft.Text > 610 Then
            If TimeLeft.Text <= 620 Then
                r3i62.Text = r3i62.Text + 1
            End If
        End If
        If TimeLeft.Text > 620 Then
            If TimeLeft.Text <= 630 Then
                r3i63.Text = r3i63.Text + 1
            End If
        End If
        If TimeLeft.Text > 630 Then
            If TimeLeft.Text <= 640 Then
                r3i64.Text = r3i64.Text + 1
            End If
        End If
        If TimeLeft.Text > 640 Then
            If TimeLeft.Text <= 650 Then
                r3i65.Text = r3i65.Text + 1
            End If
        End If
        If TimeLeft.Text > 650 Then
            If TimeLeft.Text <= 660 Then
                r3i66.Text = r3i66.Text + 1
            End If
        End If
        If TimeLeft.Text > 660 Then
            If TimeLeft.Text <= 670 Then
                r3i67.Text = r3i67.Text + 1
            End If
        End If
        If TimeLeft.Text > 670 Then
            If TimeLeft.Text <= 680 Then
                r3i68.Text = r3i68.Text + 1
            End If
        End If
        If TimeLeft.Text > 680 Then
            If TimeLeft.Text <= 690 Then
                r3i69.Text = r3i69.Text + 1
            End If
        End If
        If TimeLeft.Text > 690 Then
            If TimeLeft.Text <= 700 Then
                r3i70.Text = r3i70.Text + 1
            End If
        End If
        If TimeLeft.Text > 700 Then
            If TimeLeft.Text <= 710 Then
                r3i71.Text = r3i71.Text + 1
            End If
        End If
        If TimeLeft.Text > 710 Then
            If TimeLeft.Text <= 720 Then
                r3i72.Text = r3i72.Text + 1
            End If
        End If
        If TimeLeft.Text > 720 Then
            If TimeLeft.Text <= 730 Then
                r3i73.Text = r3i73.Text + 1
            End If
        End If
        If TimeLeft.Text > 730 Then
            If TimeLeft.Text <= 740 Then
                r3i74.Text = r3i74.Text + 1
            End If
        End If
        If TimeLeft.Text > 740 Then
            If TimeLeft.Text <= 750 Then
                r3i75.Text = r3i75.Text + 1
            End If
        End If
        If TimeLeft.Text > 750 Then
            If TimeLeft.Text <= 760 Then
                r3i76.Text = r3i76.Text + 1
            End If
        End If
        If TimeLeft.Text > 760 Then
            If TimeLeft.Text <= 770 Then
                r3i77.Text = r3i77.Text + 1
            End If
        End If
        If TimeLeft.Text > 770 Then
            If TimeLeft.Text <= 780 Then
                r3i78.Text = r3i78.Text + 1
            End If
        End If
        If TimeLeft.Text > 780 Then
            If TimeLeft.Text <= 790 Then
                r3i79.Text = r3i79.Text + 1
            End If
        End If
        If TimeLeft.Text > 790 Then
            If TimeLeft.Text <= 800 Then
                r3i80.Text = r3i80.Text + 1
            End If
        End If
        If TimeLeft.Text > 800 Then
            If TimeLeft.Text <= 810 Then
                r3i81.Text = r3i81.Text + 1
            End If
        End If
        If TimeLeft.Text > 810 Then
            If TimeLeft.Text <= 820 Then
                r3i82.Text = r3i82.Text + 1
            End If
        End If
        If TimeLeft.Text > 820 Then
            If TimeLeft.Text <= 830 Then
                r3i83.Text = r3i83.Text + 1
            End If
        End If
        If TimeLeft.Text > 830 Then
            If TimeLeft.Text <= 840 Then
                r3i84.Text = r3i84.Text + 1
            End If
        End If
        If TimeLeft.Text > 840 Then
            If TimeLeft.Text <= 850 Then
                r3i85.Text = r3i85.Text + 1
            End If
        End If
        If TimeLeft.Text > 850 Then
            If TimeLeft.Text <= 860 Then
                r3i86.Text = r3i86.Text + 1
            End If
        End If
        If TimeLeft.Text > 860 Then
            If TimeLeft.Text <= 870 Then
                r3i87.Text = r3i87.Text + 1
            End If
        End If
        If TimeLeft.Text > 870 Then
            If TimeLeft.Text <= 880 Then
                r3i88.Text = r3i88.Text + 1
            End If
        End If
        If TimeLeft.Text > 880 Then
            If TimeLeft.Text <= 890 Then
                r3i89.Text = r3i89.Text + 1
            End If
        End If
        If TimeLeft.Text > 890 Then
            If TimeLeft.Text <= 900 Then
                r3i90.Text = r3i90.Text + 1
            End If
        End If
        If TimeLeft.Text > 900 Then
            If TimeLeft.Text <= 910 Then
                r3i91.Text = r3i91.Text + 1
            End If
        End If
        If TimeLeft.Text > 910 Then
            If TimeLeft.Text <= 920 Then
                r3i92.Text = r3i92.Text + 1
            End If
        End If
        If TimeLeft.Text > 920 Then
            If TimeLeft.Text <= 930 Then
                r3i93.Text = r3i93.Text + 1
            End If
        End If
        If TimeLeft.Text > 930 Then
            If TimeLeft.Text <= 940 Then
                r3i94.Text = r3i94.Text + 1
            End If
        End If
        If TimeLeft.Text > 940 Then
            If TimeLeft.Text <= 950 Then
                r3i95.Text = r3i95.Text + 1
            End If
        End If
        If TimeLeft.Text > 950 Then
            If TimeLeft.Text <= 960 Then
                r3i96.Text = r3i96.Text + 1
            End If
        End If
        If TimeLeft.Text > 960 Then
            If TimeLeft.Text <= 970 Then
                r3i97.Text = r3i97.Text + 1
            End If
        End If
        If TimeLeft.Text > 970 Then
            If TimeLeft.Text <= 980 Then
                r3i98.Text = r3i98.Text + 1
            End If
        End If
        If TimeLeft.Text > 980 Then
            If TimeLeft.Text <= 990 Then
                r3i99.Text = r3i99.Text + 1
            End If
        End If
        If TimeLeft.Text > 990 Then
            If TimeLeft.Text <= 1000 Then
                r3i100.Text = r3i100.Text + 1
            End If
        End If
        If TimeLeft.Text > 1000 Then
            If TimeLeft.Text <= 1010 Then
                r3i101.Text = r3i101.Text + 1
            End If
        End If
        If TimeLeft.Text > 1010 Then
            If TimeLeft.Text <= 1020 Then
                r3i102.Text = r3i102.Text + 1
            End If
        End If
        If TimeLeft.Text > 1020 Then
            If TimeLeft.Text <= 1030 Then
                r3i103.Text = r3i103.Text + 1
            End If
        End If
        If TimeLeft.Text > 1030 Then
            If TimeLeft.Text <= 1040 Then
                r3i104.Text = r3i104.Text + 1
            End If
        End If
        If TimeLeft.Text > 1040 Then
            If TimeLeft.Text <= 1050 Then
                r3i105.Text = r3i105.Text + 1
            End If
        End If
        If TimeLeft.Text > 1050 Then
            If TimeLeft.Text <= 1060 Then
                r3i106.Text = r3i106.Text + 1
            End If
        End If
        If TimeLeft.Text > 1060 Then
            If TimeLeft.Text <= 1070 Then
                r3i107.Text = r3i107.Text + 1
            End If
        End If
        If TimeLeft.Text > 1070 Then
            If TimeLeft.Text <= 1080 Then
                r3i108.Text = r3i108.Text + 1
            End If
        End If
        If TimeLeft.Text > 1080 Then
            If TimeLeft.Text <= 1090 Then
                r3i109.Text = r3i109.Text + 1
            End If
        End If
        If TimeLeft.Text > 1090 Then
            If TimeLeft.Text <= 1100 Then
                r3i200.Text = r3i200.Text + 1
            End If
        End If
        If TimeLeft.Text > 1100 Then
            If TimeLeft.Text <= 1110 Then
                r3i111.Text = r3i111.Text + 1
            End If
        End If
        If TimeLeft.Text > 1110 Then
            If TimeLeft.Text <= 1120 Then
                r3i112.Text = r3i112.Text + 1
            End If
        End If
        If TimeLeft.Text > 1120 Then
            If TimeLeft.Text <= 1130 Then
                r3i113.Text = r3i113.Text + 1
            End If
        End If
        If TimeLeft.Text > 1130 Then
            If TimeLeft.Text <= 1140 Then
                r3i114.Text = r3i114.Text + 1
            End If
        End If
        If TimeLeft.Text > 1140 Then
            If TimeLeft.Text <= 1150 Then
                r3i115.Text = r3i115.Text + 1
            End If
        End If
        If TimeLeft.Text > 1150 Then
            If TimeLeft.Text <= 1160 Then
                r3i116.Text = r3i116.Text + 1
            End If
        End If
        If TimeLeft.Text > 1160 Then
            If TimeLeft.Text <= 1170 Then
                r3i117.Text = r3i117.Text + 1
            End If
        End If
        If TimeLeft.Text > 1170 Then
            If TimeLeft.Text <= 1180 Then
                r3i118.Text = r3i118.Text + 1
            End If
        End If
        If TimeLeft.Text > 1180 Then
            If TimeLeft.Text <= 1190 Then
                r3i119.Text = r3i119.Text + 1
            End If
        End If
        If TimeLeft.Text > 1190 Then
            If TimeLeft.Text <= 1200 Then
                r3i120.Text = r3i120.Text + 1
            End If
        End If
        If TimeLeft.Text > 1200 Then
            If TimeLeft.Text <= 1210 Then
                r3i121.Text = r3i121.Text + 1
            End If
        End If
        If TimeLeft.Text > 1210 Then
            If TimeLeft.Text <= 1220 Then
                r3i122.Text = r3i122.Text + 1
            End If
        End If
        If TimeLeft.Text > 1220 Then
            If TimeLeft.Text <= 1230 Then
                r3i123.Text = r3i123.Text + 1
            End If
        End If
        If TimeLeft.Text > 1230 Then
            If TimeLeft.Text <= 1240 Then
                r3i124.Text = r3i124.Text + 1
            End If
        End If
        If TimeLeft.Text > 1240 Then
            If TimeLeft.Text <= 1250 Then
                r3i125.Text = r3i125.Text + 1
            End If
        End If
        If TimeLeft.Text > 1250 Then
            If TimeLeft.Text <= 1260 Then
                r3i126.Text = r3i126.Text + 1
            End If
        End If
        If TimeLeft.Text > 1260 Then
            If TimeLeft.Text <= 1270 Then
                r3i127.Text = r3i127.Text + 1
            End If
        End If
        If TimeLeft.Text > 1270 Then
            If TimeLeft.Text <= 1280 Then
                r3i128.Text = r3i128.Text + 1
            End If
        End If
        If TimeLeft.Text > 1280 Then
            If TimeLeft.Text <= 1290 Then
                r3i129.Text = r3i129.Text + 1
            End If
        End If
        If TimeLeft.Text > 1290 Then
            If TimeLeft.Text <= 1300 Then
                r3i130.Text = r3i130.Text + 1
            End If
        End If
        If TimeLeft.Text > 1300 Then
            If TimeLeft.Text <= 1310 Then
                r3i131.Text = r3i131.Text + 1
            End If
        End If
        If TimeLeft.Text > 1310 Then
            If TimeLeft.Text <= 1320 Then
                r3i132.Text = r3i132.Text + 1
            End If
        End If
        If TimeLeft.Text > 1320 Then
            If TimeLeft.Text <= 1330 Then
                r3i133.Text = r3i133.Text + 1
            End If
        End If
        If TimeLeft.Text > 1330 Then
            If TimeLeft.Text <= 1340 Then
                r3i134.Text = r3i134.Text + 1
            End If
        End If
        If TimeLeft.Text > 1340 Then
            If TimeLeft.Text <= 1350 Then
                r3i135.Text = r3i135.Text + 1
            End If
        End If
        If TimeLeft.Text > 1350 Then
            If TimeLeft.Text <= 1360 Then
                r3i136.Text = r3i136.Text + 1
            End If
        End If
        If TimeLeft.Text > 1360 Then
            If TimeLeft.Text <= 1370 Then
                r3i137.Text = r3i137.Text + 1
            End If
        End If
        If TimeLeft.Text > 1370 Then
            If TimeLeft.Text <= 1380 Then
                r3i138.Text = r3i138.Text + 1
            End If
        End If
        If TimeLeft.Text > 1380 Then
            If TimeLeft.Text <= 1390 Then
                r3i139.Text = r3i139.Text + 1
            End If
        End If
        If TimeLeft.Text > 1390 Then
            If TimeLeft.Text <= 1400 Then
                r3i140.Text = r3i140.Text + 1
            End If
        End If
        If TimeLeft.Text > 1400 Then
            If TimeLeft.Text <= 1410 Then
                r3i141.Text = r3i141.Text + 1
            End If
        End If
        If TimeLeft.Text > 1410 Then
            If TimeLeft.Text <= 1420 Then
                r3i142.Text = r3i142.Text + 1
            End If
        End If
        If TimeLeft.Text > 1420 Then
            If TimeLeft.Text <= 1430 Then
                r3i143.Text = r3i143.Text + 1
            End If
        End If
        If TimeLeft.Text > 1430 Then
            If TimeLeft.Text <= 1440 Then
                r3i144.Text = r3i144.Text + 1
            End If
        End If
        If TimeLeft.Text > 1440 Then
            If TimeLeft.Text <= 1450 Then
                r3i145.Text = r3i145.Text + 1
            End If
        End If
        If TimeLeft.Text > 1450 Then
            If TimeLeft.Text <= 1460 Then
                r3i146.Text = r3i146.Text + 1
            End If
        End If
        If TimeLeft.Text > 1460 Then
            If TimeLeft.Text <= 1470 Then
                r3i147.Text = r3i147.Text + 1
            End If
        End If
        If TimeLeft.Text > 1470 Then
            If TimeLeft.Text <= 1480 Then
                r3i148.Text = r3i148.Text + 1
            End If
        End If
        If TimeLeft.Text > 1480 Then
            If TimeLeft.Text <= 1490 Then
                r3i149.Text = r3i149.Text + 1
            End If
        End If
        If TimeLeft.Text > 1490 Then
            If TimeLeft.Text <= 1500 Then
                r3i150.Text = r3i150.Text + 1
            End If
        End If
        If TimeLeft.Text > 1500 Then
            If TimeLeft.Text <= 1510 Then
                r3i151.Text = r3i151.Text + 1
            End If
        End If
        If TimeLeft.Text > 1510 Then
            If TimeLeft.Text <= 1520 Then
                r3i152.Text = r3i152.Text + 1
            End If
        End If
        If TimeLeft.Text > 1520 Then
            If TimeLeft.Text <= 1530 Then
                r3i153.Text = r3i153.Text + 1
            End If
        End If
        If TimeLeft.Text > 1530 Then
            If TimeLeft.Text <= 1540 Then
                r3i154.Text = r3i154.Text + 1
            End If
        End If
        If TimeLeft.Text > 1540 Then
            If TimeLeft.Text <= 1550 Then
                r3i155.Text = r3i155.Text + 1
            End If
        End If
        If TimeLeft.Text > 1550 Then
            If TimeLeft.Text <= 1560 Then
                r3i156.Text = r3i156.Text + 1
            End If
        End If
        If TimeLeft.Text > 1560 Then
            If TimeLeft.Text <= 1570 Then
                r3i157.Text = r3i157.Text + 1
            End If
        End If
        If TimeLeft.Text > 1570 Then
            If TimeLeft.Text <= 1580 Then
                r3i158.Text = r3i158.Text + 1
            End If
        End If
        If TimeLeft.Text > 1580 Then
            If TimeLeft.Text <= 1590 Then
                r3i159.Text = r3i159.Text + 1
            End If
        End If
        If TimeLeft.Text > 1590 Then
            If TimeLeft.Text <= 1600 Then
                r3i160.Text = r3i160.Text + 1
            End If
        End If
        If TimeLeft.Text > 1600 Then
            If TimeLeft.Text <= 1610 Then
                r3i161.Text = r3i161.Text + 1
            End If
        End If
        If TimeLeft.Text > 1610 Then
            If TimeLeft.Text <= 1620 Then
                r3i162.Text = r3i162.Text + 1
            End If
        End If
        If TimeLeft.Text > 1620 Then
            If TimeLeft.Text <= 1630 Then
                r3i163.Text = r3i163.Text + 1
            End If
        End If
        If TimeLeft.Text > 1630 Then
            If TimeLeft.Text <= 1640 Then
                r3i164.Text = r3i164.Text + 1
            End If
        End If
        If TimeLeft.Text > 1640 Then
            If TimeLeft.Text <= 1650 Then
                r3i165.Text = r3i165.Text + 1
            End If
        End If
        If TimeLeft.Text > 1650 Then
            If TimeLeft.Text <= 1660 Then
                r3i166.Text = r3i166.Text + 1
            End If
        End If
        If TimeLeft.Text > 1660 Then
            If TimeLeft.Text <= 1670 Then
                r3i167.Text = r3i167.Text + 1
            End If
        End If
        If TimeLeft.Text > 1670 Then
            If TimeLeft.Text <= 1680 Then
                r3i168.Text = r3i168.Text + 1
            End If
        End If
        If TimeLeft.Text > 1680 Then
            If TimeLeft.Text <= 1690 Then
                r3i169.Text = r3i169.Text + 1
            End If
        End If
        If TimeLeft.Text > 1690 Then
            If TimeLeft.Text <= 1700 Then
                r3i170.Text = r3i170.Text + 1
            End If
        End If
        If TimeLeft.Text > 1700 Then
            If TimeLeft.Text <= 1710 Then
                r3i171.Text = r3i171.Text + 1
            End If
        End If
        If TimeLeft.Text > 1710 Then
            If TimeLeft.Text <= 1720 Then
                r3i172.Text = r3i172.Text + 1
            End If
        End If
        If TimeLeft.Text > 1720 Then
            If TimeLeft.Text <= 1730 Then
                r3i173.Text = r3i173.Text + 1
            End If
        End If
        If TimeLeft.Text > 1730 Then
            If TimeLeft.Text <= 1740 Then
                r3i174.Text = r3i174.Text + 1
            End If
        End If
        If TimeLeft.Text > 1740 Then
            If TimeLeft.Text <= 1750 Then
                r3i175.Text = r3i175.Text + 1
            End If
        End If
        If TimeLeft.Text > 1750 Then
            If TimeLeft.Text <= 1760 Then
                r3i176.Text = r3i176.Text + 1
            End If
        End If
        If TimeLeft.Text > 1760 Then
            If TimeLeft.Text <= 1770 Then
                r3i177.Text = r3i177.Text + 1
            End If
        End If
        If TimeLeft.Text > 1770 Then
            If TimeLeft.Text <= 1780 Then
                r3i178.Text = r3i178.Text + 1
            End If
        End If
        If TimeLeft.Text > 1780 Then
            If TimeLeft.Text <= 1790 Then
                r3i179.Text = r3i179.Text + 1
            End If
        End If
        If TimeLeft.Text > 1790 Then
            If TimeLeft.Text <= 1800 Then
                r3i180.Text = r3i180.Text + 1
            End If
        End If
        If TimeLeft.Text > 1800 Then
            If TimeLeft.Text <= 1810 Then
                r3i181.Text = r3i181.Text + 1
            End If
        End If
        If TimeLeft.Text > 1810 Then
            If TimeLeft.Text <= 1820 Then
                r3i182.Text = r3i182.Text + 1
            End If
        End If
        If TimeLeft.Text > 1820 Then
            If TimeLeft.Text <= 1830 Then
                r3i183.Text = r3i183.Text + 1
            End If
        End If
        If TimeLeft.Text > 1830 Then
            If TimeLeft.Text <= 1840 Then
                r3i184.Text = r3i184.Text + 1
            End If
        End If
        If TimeLeft.Text > 1840 Then
            If TimeLeft.Text <= 1850 Then
                r3i185.Text = r3i185.Text + 1
            End If
        End If
        If TimeLeft.Text > 1850 Then
            If TimeLeft.Text <= 1860 Then
                r3i186.Text = r3i186.Text + 1
            End If
        End If
        If TimeLeft.Text > 1860 Then
            If TimeLeft.Text <= 1870 Then
                r3i187.Text = r3i187.Text + 1
            End If
        End If
        If TimeLeft.Text > 1870 Then
            If TimeLeft.Text <= 1880 Then
                r3i188.Text = r3i188.Text + 1
            End If
        End If
        If TimeLeft.Text > 1880 Then
            If TimeLeft.Text <= 1890 Then
                r3i189.Text = r3i189.Text + 1
            End If
        End If
        If TimeLeft.Text > 1890 Then
            If TimeLeft.Text <= 1900 Then
                r3i190.Text = r3i190.Text + 1
            End If
        End If
        If TimeLeft.Text > 1900 Then
            If TimeLeft.Text <= 1910 Then
                r3i191.Text = r3i191.Text + 1
            End If
        End If
        If TimeLeft.Text > 1910 Then
            If TimeLeft.Text <= 1920 Then
                r3i192.Text = r3i192.Text + 1
            End If
        End If
        If TimeLeft.Text > 1920 Then
            If TimeLeft.Text <= 1930 Then
                r3i193.Text = r3i193.Text + 1
            End If
        End If
        If TimeLeft.Text > 1930 Then
            If TimeLeft.Text <= 1940 Then
                r3i194.Text = r3i194.Text + 1
            End If
        End If
        If TimeLeft.Text > 1940 Then
            If TimeLeft.Text <= 1950 Then
                r3i195.Text = r3i195.Text + 1
            End If
        End If
        If TimeLeft.Text > 1950 Then
            If TimeLeft.Text <= 1960 Then
                r3i196.Text = r3i196.Text + 1
            End If
        End If
        If TimeLeft.Text > 1960 Then
            If TimeLeft.Text <= 1970 Then
                r3i197.Text = r3i197.Text + 1
            End If
        End If
        If TimeLeft.Text > 1970 Then
            If TimeLeft.Text <= 1980 Then
                r3i198.Text = r3i198.Text + 1
            End If
        End If
        If TimeLeft.Text > 1980 Then
            If TimeLeft.Text <= 1990 Then
                r3i199.Text = r3i199.Text + 1
            End If
        End If
        If TimeLeft.Text > 2000 Then
            If TimeLeft.Text <= 2010 Then
                r3i201.Text = r3i201.Text + 1
            End If
        End If
        If TimeLeft.Text > 2010 Then
            If TimeLeft.Text <= 2020 Then
                r3i202.Text = r3i202.Text + 1
            End If
        End If
        If TimeLeft.Text > 2020 Then
            If TimeLeft.Text <= 2030 Then
                r3i203.Text = r3i203.Text + 1
            End If
        End If
        If TimeLeft.Text > 2030 Then
            If TimeLeft.Text <= 2040 Then
                r3i204.Text = r3i204.Text + 1
            End If
        End If
        If TimeLeft.Text > 2040 Then
            If TimeLeft.Text <= 2050 Then
                r3i205.Text = r3i205.Text + 1
            End If
        End If
        If TimeLeft.Text > 2050 Then
            If TimeLeft.Text <= 2060 Then
                r3i206.Text = r3i206.Text + 1
            End If
        End If
        If TimeLeft.Text > 2060 Then
            If TimeLeft.Text <= 2070 Then
                r3i207.Text = r3i207.Text + 1
            End If
        End If
        If TimeLeft.Text > 2070 Then
            If TimeLeft.Text <= 2080 Then
                r3i208.Text = r3i208.Text + 1
            End If
        End If
        If TimeLeft.Text > 2080 Then
            If TimeLeft.Text <= 2090 Then
                r3i209.Text = r3i209.Text + 1
            End If
        End If
        If TimeLeft.Text > 2090 Then
            If TimeLeft.Text <= 2100 Then
                r3i210.Text = r3i210.Text + 1
            End If
        End If
        If TimeLeft.Text > 2100 Then
            If TimeLeft.Text <= 2110 Then
                r3i211.Text = r3i211.Text + 1
            End If
        End If
        If TimeLeft.Text > 2110 Then
            If TimeLeft.Text <= 2120 Then
                r3i212.Text = r3i212.Text + 1
            End If
        End If
        If TimeLeft.Text > 2120 Then
            If TimeLeft.Text <= 2130 Then
                r3i213.Text = r3i213.Text + 1
            End If
        End If
        If TimeLeft.Text > 2130 Then
            If TimeLeft.Text <= 2140 Then
                r3i214.Text = r3i214.Text + 1
            End If
        End If
        If TimeLeft.Text > 2140 Then
            If TimeLeft.Text <= 2150 Then
                r3i215.Text = r3i215.Text + 1
            End If
        End If
        If TimeLeft.Text > 2150 Then
            If TimeLeft.Text <= 2160 Then
                r3i216.Text = r3i216.Text + 1
            End If
        End If
        If TimeLeft.Text > 2160 Then
            If TimeLeft.Text <= 2170 Then
                r3i217.Text = r3i217.Text + 1
            End If
        End If
        If TimeLeft.Text > 2170 Then
            If TimeLeft.Text <= 2180 Then
                r3i218.Text = r3i218.Text + 1
            End If
        End If
        If TimeLeft.Text > 2180 Then
            If TimeLeft.Text <= 2190 Then
                r3i219.Text = r3i219.Text + 1
            End If
        End If
        If TimeLeft.Text > 2190 Then
            If TimeLeft.Text <= 2200 Then
                r3i220.Text = r3i220.Text + 1
            End If
        End If
        If TimeLeft.Text > 2200 Then
            If TimeLeft.Text <= 2210 Then
                r3i221.Text = r3i221.Text + 1
            End If
        End If
        If TimeLeft.Text > 2210 Then
            If TimeLeft.Text <= 2220 Then
                r3i222.Text = r3i222.Text + 1
            End If
        End If
        If TimeLeft.Text > 2220 Then
            If TimeLeft.Text <= 2230 Then
                r3i223.Text = r3i223.Text + 1
            End If
        End If
        If TimeLeft.Text > 2230 Then
            If TimeLeft.Text <= 2240 Then
                r3i224.Text = r3i224.Text + 1
            End If
        End If
        If TimeLeft.Text > 2240 Then
            If TimeLeft.Text <= 2250 Then
                r3i225.Text = r3i225.Text + 1
            End If
        End If
        If TimeLeft.Text > 2250 Then
            If TimeLeft.Text <= 2260 Then
                r3i226.Text = r3i226.Text + 1
            End If
        End If
        If TimeLeft.Text > 2260 Then
            If TimeLeft.Text <= 2270 Then
                r3i227.Text = r3i227.Text + 1
            End If
        End If
        If TimeLeft.Text > 2270 Then
            If TimeLeft.Text <= 2280 Then
                r3i228.Text = r3i228.Text + 1
            End If
        End If
        If TimeLeft.Text > 2280 Then
            If TimeLeft.Text <= 2290 Then
                r3i229.Text = r3i229.Text + 1
            End If
        End If
        If TimeLeft.Text > 2290 Then
            If TimeLeft.Text <= 2300 Then
                r3i230.Text = r3i230.Text + 1
            End If
        End If
        If TimeLeft.Text > 2300 Then
            If TimeLeft.Text <= 2310 Then
                r3i231.Text = r3i231.Text + 1
            End If
        End If
        If TimeLeft.Text > 2310 Then
            If TimeLeft.Text <= 2320 Then
                r3i232.Text = r3i232.Text + 1
            End If
        End If
        If TimeLeft.Text > 2320 Then
            If TimeLeft.Text <= 2330 Then
                r3i233.Text = r3i233.Text + 1
            End If
        End If
        If TimeLeft.Text > 2330 Then
            If TimeLeft.Text <= 2340 Then
                r3i234.Text = r3i234.Text + 1
            End If
        End If
        If TimeLeft.Text > 2340 Then
            If TimeLeft.Text <= 2350 Then
                r3i235.Text = r3i235.Text + 1
            End If
        End If
        If TimeLeft.Text > 2350 Then
            If TimeLeft.Text <= 2360 Then
                r3i236.Text = r3i236.Text + 1
            End If
        End If
        If TimeLeft.Text > 2360 Then
            If TimeLeft.Text <= 2370 Then
                r3i237.Text = r3i237.Text + 1
            End If
        End If
        If TimeLeft.Text > 2370 Then
            If TimeLeft.Text <= 2380 Then
                r3i238.Text = r3i238.Text + 1
            End If
        End If
        If TimeLeft.Text > 2380 Then
            If TimeLeft.Text <= 2390 Then
                r3i239.Text = r3i239.Text + 1
            End If
        End If
        If TimeLeft.Text > 2390 Then
            If TimeLeft.Text <= 2400 Then
                r3i240.Text = r3i240.Text + 1
            End If
        End If
        If TimeLeft.Text > 2400 Then
            If TimeLeft.Text <= 2410 Then
                r3i241.Text = r3i241.Text + 1
            End If
        End If
        If TimeLeft.Text > 2410 Then
            If TimeLeft.Text <= 2420 Then
                r3i242.Text = r3i242.Text + 1
            End If
        End If
        If TimeLeft.Text > 2420 Then
            If TimeLeft.Text <= 2430 Then
                r3i243.Text = r3i243.Text + 1
            End If
        End If
        If TimeLeft.Text > 2430 Then
            If TimeLeft.Text <= 2440 Then
                r3i244.Text = r3i244.Text + 1
            End If
        End If
        If TimeLeft.Text > 2440 Then
            If TimeLeft.Text <= 2450 Then
                r3i245.Text = r3i245.Text + 1
            End If
        End If
        If TimeLeft.Text > 2450 Then
            If TimeLeft.Text <= 2460 Then
                r3i246.Text = r3i246.Text + 1
            End If
        End If
        If TimeLeft.Text > 2460 Then
            If TimeLeft.Text <= 2470 Then
                r3i247.Text = r3i247.Text + 1
            End If
        End If
        If TimeLeft.Text > 2470 Then
            If TimeLeft.Text <= 2480 Then
                r3i248.Text = r3i248.Text + 1
            End If
        End If
        If TimeLeft.Text > 2480 Then
            If TimeLeft.Text <= 2490 Then
                r3i249.Text = r3i249.Text + 1
            End If
        End If
        If TimeLeft.Text > 2490 Then
            If TimeLeft.Text <= 2500 Then
                r3i250.Text = r3i250.Text + 1
            End If
        End If
        If TimeLeft.Text > 2500 Then
            If TimeLeft.Text <= 2510 Then
                r3i251.Text = r3i251.Text + 1
            End If
        End If
        If TimeLeft.Text > 2510 Then
            If TimeLeft.Text <= 2520 Then
                r3i252.Text = r3i252.Text + 1
            End If
        End If
        If TimeLeft.Text > 2520 Then
            If TimeLeft.Text <= 2530 Then
                r3i253.Text = r3i253.Text + 1
            End If
        End If
        If TimeLeft.Text > 2530 Then
            If TimeLeft.Text <= 2540 Then
                r3i254.Text = r3i254.Text + 1
            End If
        End If
        If TimeLeft.Text > 2540 Then
            If TimeLeft.Text <= 2550 Then
                r3i255.Text = r3i255.Text + 1
            End If
        End If
        If TimeLeft.Text > 2550 Then
            If TimeLeft.Text <= 2560 Then
                r3i256.Text = r3i256.Text + 1
            End If
        End If
        If TimeLeft.Text > 2560 Then
            If TimeLeft.Text <= 2570 Then
                r3i257.Text = r3i257.Text + 1
            End If
        End If
        If TimeLeft.Text > 2570 Then
            If TimeLeft.Text <= 2580 Then
                r3i258.Text = r3i258.Text + 1
            End If
        End If
        If TimeLeft.Text > 2580 Then
            If TimeLeft.Text <= 2590 Then
                r3i259.Text = r3i259.Text + 1
            End If
        End If
        If TimeLeft.Text > 2590 Then
            If TimeLeft.Text <= 2600 Then
                r3i260.Text = r3i260.Text + 1
            End If
        End If
        If TimeLeft.Text > 2600 Then
            If TimeLeft.Text <= 2610 Then
                r3i261.Text = r3i261.Text + 1
            End If
        End If
        If TimeLeft.Text > 2610 Then
            If TimeLeft.Text <= 2620 Then
                r3i262.Text = r3i262.Text + 1
            End If
        End If
        If TimeLeft.Text > 2620 Then
            If TimeLeft.Text <= 2630 Then
                r3i263.Text = r3i263.Text + 1
            End If
        End If
        If TimeLeft.Text > 2630 Then
            If TimeLeft.Text <= 2640 Then
                r3i264.Text = r3i264.Text + 1
            End If
        End If
        If TimeLeft.Text > 2640 Then
            If TimeLeft.Text <= 2650 Then
                r3i265.Text = r3i265.Text + 1
            End If
        End If
        If TimeLeft.Text > 2650 Then
            If TimeLeft.Text <= 2660 Then
                r3i266.Text = r3i266.Text + 1
            End If
        End If
        If TimeLeft.Text > 2660 Then
            If TimeLeft.Text <= 2670 Then
                r3i267.Text = r3i267.Text + 1
            End If
        End If
        If TimeLeft.Text > 2670 Then
            If TimeLeft.Text <= 2680 Then
                r3i268.Text = r3i268.Text + 1
            End If
        End If
        If TimeLeft.Text > 2680 Then
            If TimeLeft.Text <= 2690 Then
                r3i269.Text = r3i269.Text + 1
            End If
        End If
        If TimeLeft.Text > 2690 Then
            If TimeLeft.Text <= 2700 Then
                r3i270.Text = r3i270.Text + 1
            End If
        End If
        If TimeLeft.Text > 2700 Then
            If TimeLeft.Text <= 2710 Then
                r3i271.Text = r3i271.Text + 1
            End If
        End If
        If TimeLeft.Text > 2710 Then
            If TimeLeft.Text <= 2720 Then
                r3i272.Text = r3i272.Text + 1
            End If
        End If
        If TimeLeft.Text > 2720 Then
            If TimeLeft.Text <= 2730 Then
                r3i273.Text = r3i273.Text + 1
            End If
        End If
        If TimeLeft.Text > 2730 Then
            If TimeLeft.Text <= 2740 Then
                r3i274.Text = r3i274.Text + 1
            End If
        End If
        If TimeLeft.Text > 2740 Then
            If TimeLeft.Text <= 2750 Then
                r3i275.Text = r3i275.Text + 1
            End If
        End If
        If TimeLeft.Text > 2750 Then
            If TimeLeft.Text <= 2760 Then
                r3i276.Text = r3i276.Text + 1
            End If
        End If
        If TimeLeft.Text > 2760 Then
            If TimeLeft.Text <= 2770 Then
                r3i277.Text = r3i277.Text + 1
            End If
        End If
        If TimeLeft.Text > 2770 Then
            If TimeLeft.Text <= 2780 Then
                r3i278.Text = r3i278.Text + 1
            End If
        End If
        If TimeLeft.Text > 2780 Then
            If TimeLeft.Text <= 2790 Then
                r3i279.Text = r3i279.Text + 1
            End If
        End If
        If TimeLeft.Text > 2790 Then
            If TimeLeft.Text <= 2800 Then
                r3i281.Text = r3i280.Text + 1
            End If
        End If
        If TimeLeft.Text > 2800 Then
            If TimeLeft.Text <= 2810 Then
                r3i281.Text = r3i281.Text + 1
            End If
        End If
        If TimeLeft.Text > 2810 Then
            If TimeLeft.Text <= 2820 Then
                r3i282.Text = r3i282.Text + 1
            End If
        End If
        If TimeLeft.Text > 2820 Then
            If TimeLeft.Text <= 2830 Then
                r3i283.Text = r3i283.Text + 1
            End If
        End If
        If TimeLeft.Text > 2830 Then
            If TimeLeft.Text <= 2840 Then
                r3i284.Text = r3i284.Text + 1
            End If
        End If
        If TimeLeft.Text > 2840 Then
            If TimeLeft.Text <= 2850 Then
                r3i285.Text = r3i285.Text + 1
            End If
        End If
        If TimeLeft.Text > 2850 Then
            If TimeLeft.Text <= 2860 Then
                r3i286.Text = r3i286.Text + 1
            End If
        End If
        If TimeLeft.Text > 2860 Then
            If TimeLeft.Text <= 2870 Then
                r3i287.Text = r3i287.Text + 1
            End If
        End If
        If TimeLeft.Text > 2870 Then
            If TimeLeft.Text <= 2880 Then
                r3i288.Text = r3i288.Text + 1
            End If
        End If

    End Sub

    'Code for timers running throughout sessions and phases. 
    Private Sub SessionTime_Tick(sender As Object, e As EventArgs) Handles SessionTime.Tick
        If TimeLeft.Text >= 0 Then
            TimeLeft.Text = Val(TimeLeft.Text) + 1
        End If
        If TimeLeft.Text = 2880 Then
            sessionEnd.Visible = True
            SessionTime.Enabled = False
            debriefLoad.Visible = True
        End If
        'Code for Phase 1. 
        If phaseNumber.Text = 1 Then
            phase1Time.Text = Val(phase1Time.Text) + 1
            'Code for stability criteria across all three levers taken at 2-min intervals beginning at 10-minutes. 
            If TimeLeft.Text = 600 Then
                If r1sess3.Text = 0 Then
                    r1sess3.Text = r1sess3.Text + 0.01
                End If
                If r1sess4.Text = 0 Then
                    r1sess4.Text = r1sess4.Text + 0.02
                End If
                If r1sess5.Text = 0 Then
                    r1sess5.Text = r1sess5.Text + 0.03
                End If
                If r2sess3.Text = 0 Then
                    r2sess3.Text = r2sess3.Text + 0.01
                End If
                If r2sess4.Text = 0 Then
                    r2sess4.Text = r2sess4.Text + 0.02
                End If
                If r2sess5.Text = 0 Then
                    r2sess5.Text = r2sess5.Text + 0.03
                End If
                If r3sess3.Text = 0 Then
                    r3sess3.Text = r3sess3.Text + 0.01
                End If
                If r3sess4.Text = 0 Then
                    r3sess4.Text = r3sess4.Text + 0.02
                End If
                If r3sess5.Text = 0 Then
                    r3sess5.Text = r3sess5.Text + 0.03
                End If
                If r4sess3.Text = 0 Then
                    r4sess3.Text = r4sess3.Text + 0.01
                End If
                If r4sess4.Text = 0 Then
                    r4sess4.Text = r4sess4.Text + 0.02
                End If
                If r4sess5.Text = 0 Then
                    r4sess5.Text = r4sess5.Text + 0.03
                End If
                If r5sess3.Text = 0 Then
                    r5sess3.Text = r5sess3.Text + 0.01
                End If
                If r5sess4.Text = 0 Then
                    r5sess4.Text = r5sess4.Text + 0.02
                End If
                If r5sess5.Text = 0 Then
                    r5sess5.Text = r5sess5.Text + 0.03
                End If
                If r6sess3.Text = 0 Then
                    r6sess3.Text = r6sess3.Text + 0.01
                End If
                If r6sess4.Text = 0 Then
                    r6sess4.Text = r6sess4.Text + 0.02
                End If
                If r6sess5.Text = 0 Then
                    r6sess5.Text = r6sess5.Text + 0.03
                End If
                'Target response
                r121.Text = Val(r1sess5.Text) - Val(r1sess4.Text)
                r132.Text = Val(r1sess4.Text) - Val(r1sess3.Text)
                Dim sloper1 As Integer
                sloper1 = (Val(r121.Text) + Val(r132.Text)) / 2
                r1321Tot.Text = Val(r1sess3.Text) + Val(r1sess4.Text) + Val(r1sess5.Text)
                r1321slope.Text = sloper1 / Val(r1321Tot.Text)
                'Alternative 1 response
                r221.Text = Val(r2sess5.Text) - Val(r2sess4.Text)
                r232.Text = Val(r2sess4.Text) - Val(r2sess3.Text)
                Dim sloper2 As Integer
                sloper2 = (Val(r221.Text) + Val(r232.Text)) / 2
                r2321Tot.Text = Val(r2sess3.Text) + Val(r2sess4.Text) + Val(r2sess5.Text)
                r2321slope.Text = sloper2 / Val(r2321Tot.Text)
                'Alternative 2 response
                r421.Text = Val(r4sess5.Text) - Val(r4sess4.Text)
                r432.Text = Val(r4sess4.Text) - Val(r4sess3.Text)
                Dim sloper4 As Integer
                sloper4 = (Val(r421.Text) + Val(r432.Text)) / 2
                r4321Tot.Text = Val(r4sess3.Text) + Val(r4sess4.Text) + Val(r4sess5.Text)
                r4321slope.Text = sloper4 / Val(r4321Tot.Text)
                'Alternative 3 response
                r521.Text = Val(r5sess5.Text) - Val(r5sess4.Text)
                r532.Text = Val(r5sess4.Text) - Val(r5sess3.Text)
                Dim sloper5 As Integer
                sloper5 = (Val(r521.Text) + Val(r532.Text)) / 2
                r5321Tot.Text = Val(r5sess3.Text) + Val(r5sess4.Text) + Val(r5sess5.Text)
                r5321slope.Text = sloper5 / Val(r5321Tot.Text)
                'Alternative 4 response
                r621.Text = Val(r6sess5.Text) - Val(r6sess4.Text)
                r632.Text = Val(r6sess4.Text) - Val(r6sess3.Text)
                Dim sloper6 As Integer
                sloper6 = (Val(r621.Text) + Val(r632.Text)) / 2
                r6321Tot.Text = Val(r6sess3.Text) + Val(r6sess4.Text) + Val(r6sess5.Text)
                r6321slope.Text = sloper6 / Val(r6321Tot.Text)
                'Inactive control
                r321.Text = Val(r3sess5.Text) - Val(r3sess4.Text)
                r332.Text = Val(r3sess4.Text) - Val(r3sess3.Text)
                Dim sloper3 As Integer
                sloper3 = (Val(r321.Text) + Val(r332.Text)) / 2
                r3321Tot.Text = Val(r3sess3.Text) + Val(r3sess4.Text) + Val(r3sess5.Text)
                r3321slope.Text = sloper3 / Val(r3321Tot.Text)
                'Code for stability determination. 
                If r121.Text <= 6 Then
                    If r121.Text >= -6 Then
                        If r132.Text <= 6 Then
                            If r132.Text >= -6 Then
                                If r221.Text <= 6 Then
                                    If r221.Text >= -6 Then
                                        If r232.Text <= 6 Then
                                            If r232.Text >= -6 Then
                                                If r321.Text <= 6 Then
                                                    If r321.Text >= -6 Then
                                                        If r332.Text <= 6 Then
                                                            If r332.Text >= -6 Then
                                                                If r421.Text <= 6 Then
                                                                    If r421.Text >= -6 Then
                                                                        If r432.Text <= 6 Then
                                                                            If r432.Text >= -6 Then
                                                                                If r521.Text <= 6 Then
                                                                                    If r521.Text >= -6 Then
                                                                                        If r532.Text <= 6 Then
                                                                                            If r532.Text >= -6 Then
                                                                                                If r621.Text <= 6 Then
                                                                                                    If r621.Text >= -6 Then
                                                                                                        If r632.Text <= 6 Then
                                                                                                            If r632.Text >= -6 Then
                                                                                                                If r1321slope.Text >= -0.1 Then
                                                                                                                    If r1321slope.Text <= 0.1 Then
                                                                                                                        If r2321slope.Text >= -0.1 Then
                                                                                                                            If r2321slope.Text <= 0.1 Then
                                                                                                                                If r3321slope.Text >= -0.1 Then
                                                                                                                                    If r3321slope.Text <= 0.1 Then
                                                                                                                                        If r4321slope.Text >= -0.1 Then
                                                                                                                                            If r4321slope.Text <= 0.1 Then
                                                                                                                                                If r5321slope.Text >= -0.1 Then
                                                                                                                                                    If r5321slope.Text <= 0.1 Then
                                                                                                                                                        If r6321slope.Text >= -0.1 Then
                                                                                                                                                            If r6321slope.Text <= 0.1 Then
                                                                                                                                                                If phaseNumber.Text = 1 Then
                                                                                                                                                                    interPhaseText.Visible = True
                                                                                                                                                                    interPhaseInterval.Enabled = True
                                                                                                                                                                    SessionTime.Enabled = False
                                                                                                                                                                    csvTextBox.Text = "Phase 1 ended at 600-sec" + ","
                                                                                                                                                                End If
                                                                                                                                                            End If
                                                                                                                                                        End If
                                                                                                                                                    End If
                                                                                                                                                End If
                                                                                                                                            End If
                                                                                                                                        End If
                                                                                                                                    End If
                                                                                                                                End If
                                                                                                                            End If
                                                                                                                        End If
                                                                                                                    End If
                                                                                                                End If
                                                                                                            End If
                                                                                                        End If
                                                                                                    End If
                                                                                                End If
                                                                                            End If
                                                                                        End If
                                                                                    End If
                                                                                End If
                                                                            End If
                                                                        End If
                                                                    End If
                                                                End If
                                                            End If
                                                        End If
                                                    End If
                                                End If
                                            End If
                                        End If
                                    End If
                                End If
                            End If
                        End If
                    End If
                End If
            End If
            If TimeLeft.Text = 720 Then
                If r1sess4.Text = 0 Then
                    r1sess4.Text = r1sess4.Text + 0.01
                End If
                If r1sess5.Text = 0 Then
                    r1sess5.Text = r1sess5.Text + 0.02
                End If
                If r1sess6.Text = 0 Then
                    r1sess6.Text = r1sess6.Text + 0.03
                End If
                If r2sess4.Text = 0 Then
                    r2sess4.Text = r2sess4.Text + 0.01
                End If
                If r2sess5.Text = 0 Then
                    r2sess5.Text = r2sess5.Text + 0.02
                End If
                If r2sess6.Text = 0 Then
                    r2sess6.Text = r2sess6.Text + 0.03
                End If
                If r3sess4.Text = 0 Then
                    r3sess4.Text = r3sess4.Text + 0.01
                End If
                If r3sess5.Text = 0 Then
                    r3sess5.Text = r3sess5.Text + 0.02
                End If
                If r3sess6.Text = 0 Then
                    r3sess6.Text = r3sess6.Text + 0.03
                End If
                If r4sess4.Text = 0 Then
                    r4sess4.Text = r4sess4.Text + 0.01
                End If
                If r4sess5.Text = 0 Then
                    r4sess5.Text = r4sess5.Text + 0.02
                End If
                If r4sess6.Text = 0 Then
                    r4sess6.Text = r4sess6.Text + 0.03
                End If
                If r5sess4.Text = 0 Then
                    r5sess4.Text = r5sess4.Text + 0.01
                End If
                If r5sess5.Text = 0 Then
                    r5sess5.Text = r5sess5.Text + 0.02
                End If
                If r5sess6.Text = 0 Then
                    r5sess6.Text = r5sess6.Text + 0.03
                End If
                If r6sess4.Text = 0 Then
                    r6sess4.Text = r6sess4.Text + 0.01
                End If
                If r6sess5.Text = 0 Then
                    r6sess5.Text = r6sess5.Text + 0.02
                End If
                If r6sess6.Text = 0 Then
                    r6sess6.Text = r6sess6.Text + 0.03
                End If
                'Target response
                r121.Text = Val(r1sess6.Text) - Val(r1sess5.Text)
                r132.Text = Val(r1sess5.Text) - Val(r1sess4.Text)
                Dim sloper1 As Integer
                sloper1 = (Val(r121.Text) + Val(r132.Text)) / 2
                r1321Tot.Text = Val(r1sess4.Text) + Val(r1sess5.Text) + Val(r1sess6.Text)
                r1321slope.Text = sloper1 / Val(r1321Tot.Text)
                'Alternative 1 response
                r221.Text = Val(r2sess6.Text) - Val(r2sess5.Text)
                r232.Text = Val(r2sess5.Text) - Val(r2sess4.Text)
                Dim sloper2 As Integer
                sloper2 = (Val(r221.Text) + Val(r232.Text)) / 2
                r2321Tot.Text = Val(r2sess4.Text) + Val(r2sess5.Text) + Val(r2sess6.Text)
                r2321slope.Text = sloper2 / Val(r2321Tot.Text)
                'Alternative 2 response
                r421.Text = Val(r4sess6.Text) - Val(r4sess5.Text)
                r432.Text = Val(r4sess5.Text) - Val(r4sess4.Text)
                Dim sloper4 As Integer
                sloper4 = (Val(r421.Text) + Val(r432.Text)) / 2
                r4321Tot.Text = Val(r4sess4.Text) + Val(r4sess5.Text) + Val(r4sess6.Text)
                r4321slope.Text = sloper4 / Val(r4321Tot.Text)
                'Alternative 3 response
                r521.Text = Val(r5sess6.Text) - Val(r5sess5.Text)
                r532.Text = Val(r5sess5.Text) - Val(r5sess4.Text)
                Dim sloper5 As Integer
                sloper5 = (Val(r521.Text) + Val(r532.Text)) / 2
                r5321Tot.Text = Val(r5sess4.Text) + Val(r5sess5.Text) + Val(r5sess6.Text)
                r5321slope.Text = sloper5 / Val(r5321Tot.Text)
                'Alternative 4 response
                r621.Text = Val(r6sess6.Text) - Val(r6sess5.Text)
                r632.Text = Val(r6sess5.Text) - Val(r6sess4.Text)
                Dim sloper6 As Integer
                sloper6 = (Val(r621.Text) + Val(r632.Text)) / 2
                r6321Tot.Text = Val(r6sess4.Text) + Val(r6sess5.Text) + Val(r6sess6.Text)
                r6321slope.Text = sloper6 / Val(r6321Tot.Text)
                'Inactive control
                r321.Text = Val(r3sess6.Text) - Val(r3sess5.Text)
                r332.Text = Val(r3sess5.Text) - Val(r3sess4.Text)
                Dim sloper3 As Integer
                sloper3 = (Val(r321.Text) + Val(r332.Text)) / 2
                r3321Tot.Text = Val(r3sess4.Text) + Val(r3sess5.Text) + Val(r3sess6.Text)
                r3321slope.Text = sloper3 / Val(r3321Tot.Text)
                'Code for stability determination. 
                If r121.Text <= 6 Then
                    If r121.Text >= -6 Then
                        If r132.Text <= 6 Then
                            If r132.Text >= -6 Then
                                If r221.Text <= 6 Then
                                    If r221.Text >= -6 Then
                                        If r232.Text <= 6 Then
                                            If r232.Text >= -6 Then
                                                If r321.Text <= 6 Then
                                                    If r321.Text >= -6 Then
                                                        If r332.Text <= 6 Then
                                                            If r332.Text >= -6 Then
                                                                If r421.Text <= 6 Then
                                                                    If r421.Text >= -6 Then
                                                                        If r432.Text <= 6 Then
                                                                            If r432.Text >= -6 Then
                                                                                If r521.Text <= 6 Then
                                                                                    If r521.Text >= -6 Then
                                                                                        If r532.Text <= 6 Then
                                                                                            If r532.Text >= -6 Then
                                                                                                If r621.Text <= 6 Then
                                                                                                    If r621.Text >= -6 Then
                                                                                                        If r632.Text <= 6 Then
                                                                                                            If r632.Text >= -6 Then
                                                                                                                If r1321slope.Text >= -0.1 Then
                                                                                                                    If r1321slope.Text <= 0.1 Then
                                                                                                                        If r2321slope.Text >= -0.1 Then
                                                                                                                            If r2321slope.Text <= 0.1 Then
                                                                                                                                If r3321slope.Text >= -0.1 Then
                                                                                                                                    If r3321slope.Text <= 0.1 Then
                                                                                                                                        If r4321slope.Text >= -0.1 Then
                                                                                                                                            If r4321slope.Text <= 0.1 Then
                                                                                                                                                If r5321slope.Text >= -0.1 Then
                                                                                                                                                    If r5321slope.Text <= 0.1 Then
                                                                                                                                                        If r6321slope.Text >= -0.1 Then
                                                                                                                                                            If r6321slope.Text <= 0.1 Then
                                                                                                                                                                If phaseNumber.Text = 1 Then
                                                                                                                                                                    interPhaseText.Visible = True
                                                                                                                                                                    interPhaseInterval.Enabled = True
                                                                                                                                                                    SessionTime.Enabled = False
                                                                                                                                                                    csvTextBox.Text = "Phase 1 ended at 720-sec" + ","
                                                                                                                                                                End If
                                                                                                                                                            End If
                                                                                                                                                        End If
                                                                                                                                                    End If
                                                                                                                                                End If
                                                                                                                                            End If
                                                                                                                                        End If
                                                                                                                                    End If
                                                                                                                                End If
                                                                                                                            End If
                                                                                                                        End If
                                                                                                                    End If
                                                                                                                End If
                                                                                                            End If
                                                                                                        End If
                                                                                                    End If
                                                                                                End If
                                                                                            End If
                                                                                        End If
                                                                                    End If
                                                                                End If
                                                                            End If
                                                                        End If
                                                                    End If
                                                                End If
                                                            End If
                                                        End If
                                                    End If
                                                End If
                                            End If
                                        End If
                                    End If
                                End If
                            End If
                        End If
                    End If
                End If
            End If
            If TimeLeft.Text = 840 Then
                If r1sess5.Text = 0 Then
                    r1sess5.Text = r1sess5.Text + 0.01
                End If
                If r1sess6.Text = 0 Then
                    r1sess6.Text = r1sess6.Text + 0.02
                End If
                If r1sess7.Text = 0 Then
                    r1sess7.Text = r1sess7.Text + 0.03
                End If
                If r2sess5.Text = 0 Then
                    r2sess5.Text = r2sess5.Text + 0.01
                End If
                If r2sess6.Text = 0 Then
                    r2sess6.Text = r2sess6.Text + 0.02
                End If
                If r2sess7.Text = 0 Then
                    r2sess7.Text = r2sess7.Text + 0.03
                End If
                If r3sess5.Text = 0 Then
                    r3sess5.Text = r3sess5.Text + 0.01
                End If
                If r3sess6.Text = 0 Then
                    r3sess6.Text = r3sess6.Text + 0.02
                End If
                If r3sess7.Text = 0 Then
                    r3sess7.Text = r3sess7.Text + 0.03
                End If
                If r4sess5.Text = 0 Then
                    r4sess5.Text = r4sess5.Text + 0.01
                End If
                If r4sess6.Text = 0 Then
                    r4sess6.Text = r4sess6.Text + 0.02
                End If
                If r4sess7.Text = 0 Then
                    r4sess7.Text = r4sess7.Text + 0.03
                End If
                If r5sess5.Text = 0 Then
                    r5sess5.Text = r5sess5.Text + 0.01
                End If
                If r5sess6.Text = 0 Then
                    r5sess6.Text = r5sess6.Text + 0.02
                End If
                If r5sess7.Text = 0 Then
                    r5sess7.Text = r5sess7.Text + 0.03
                End If
                If r6sess5.Text = 0 Then
                    r6sess5.Text = r6sess5.Text + 0.01
                End If
                If r6sess6.Text = 0 Then
                    r6sess6.Text = r6sess6.Text + 0.02
                End If
                If r6sess7.Text = 0 Then
                    r6sess7.Text = r6sess7.Text + 0.03
                End If
                'Target response
                r121.Text = Val(r1sess7.Text) - Val(r1sess6.Text)
                r132.Text = Val(r1sess6.Text) - Val(r1sess5.Text)
                Dim sloper1 As Integer
                sloper1 = (Val(r121.Text) + Val(r132.Text)) / 2
                r1321Tot.Text = Val(r1sess5.Text) + Val(r1sess6.Text) + Val(r1sess7.Text)
                r1321slope.Text = sloper1 / Val(r1321Tot.Text)
                'Alternative 1 response
                r221.Text = Val(r2sess7.Text) - Val(r2sess6.Text)
                r232.Text = Val(r2sess6.Text) - Val(r2sess5.Text)
                Dim sloper2 As Integer
                sloper2 = (Val(r221.Text) + Val(r232.Text)) / 2
                r2321Tot.Text = Val(r2sess5.Text) + Val(r2sess6.Text) + Val(r2sess7.Text)
                r2321slope.Text = sloper2 / Val(r2321Tot.Text)
                'Alternative 2 response
                r421.Text = Val(r4sess7.Text) - Val(r4sess6.Text)
                r432.Text = Val(r4sess6.Text) - Val(r4sess5.Text)
                Dim sloper4 As Integer
                sloper4 = (Val(r421.Text) + Val(r432.Text)) / 2
                r4321Tot.Text = Val(r4sess5.Text) + Val(r4sess6.Text) + Val(r4sess7.Text)
                r4321slope.Text = sloper4 / Val(r4321Tot.Text)
                'Alternative 3 response
                r521.Text = Val(r5sess7.Text) - Val(r5sess6.Text)
                r532.Text = Val(r5sess6.Text) - Val(r5sess5.Text)
                Dim sloper5 As Integer
                sloper5 = (Val(r521.Text) + Val(r532.Text)) / 2
                r5321Tot.Text = Val(r5sess5.Text) + Val(r5sess6.Text) + Val(r5sess7.Text)
                r5321slope.Text = sloper5 / Val(r5321Tot.Text)
                'Alternative 4 response
                r621.Text = Val(r6sess7.Text) - Val(r6sess6.Text)
                r632.Text = Val(r6sess6.Text) - Val(r6sess5.Text)
                Dim sloper6 As Integer
                sloper6 = (Val(r621.Text) + Val(r632.Text)) / 2
                r6321Tot.Text = Val(r6sess5.Text) + Val(r6sess6.Text) + Val(r6sess7.Text)
                r6321slope.Text = sloper6 / Val(r6321Tot.Text)
                'Inactive control
                r321.Text = Val(r3sess7.Text) - Val(r3sess6.Text)
                r332.Text = Val(r3sess6.Text) - Val(r3sess5.Text)
                Dim sloper3 As Integer
                sloper3 = (Val(r321.Text) + Val(r332.Text)) / 2
                r3321Tot.Text = Val(r3sess5.Text) + Val(r3sess6.Text) + Val(r3sess7.Text)
                r3321slope.Text = sloper3 / Val(r3321Tot.Text)
                'Code for stability determination. 
                If r121.Text <= 6 Then
                    If r121.Text >= -6 Then
                        If r132.Text <= 6 Then
                            If r132.Text >= -6 Then
                                If r221.Text <= 6 Then
                                    If r221.Text >= -6 Then
                                        If r232.Text <= 6 Then
                                            If r232.Text >= -6 Then
                                                If r321.Text <= 6 Then
                                                    If r321.Text >= -6 Then
                                                        If r332.Text <= 6 Then
                                                            If r332.Text >= -6 Then
                                                                If r421.Text <= 6 Then
                                                                    If r421.Text >= -6 Then
                                                                        If r432.Text <= 6 Then
                                                                            If r432.Text >= -6 Then
                                                                                If r521.Text <= 6 Then
                                                                                    If r521.Text >= -6 Then
                                                                                        If r532.Text <= 6 Then
                                                                                            If r532.Text >= -6 Then
                                                                                                If r621.Text <= 6 Then
                                                                                                    If r621.Text >= -6 Then
                                                                                                        If r632.Text <= 6 Then
                                                                                                            If r632.Text >= -6 Then
                                                                                                                If r1321slope.Text >= -0.1 Then
                                                                                                                    If r1321slope.Text <= 0.1 Then
                                                                                                                        If r2321slope.Text >= -0.1 Then
                                                                                                                            If r2321slope.Text <= 0.1 Then
                                                                                                                                If r3321slope.Text >= -0.1 Then
                                                                                                                                    If r3321slope.Text <= 0.1 Then
                                                                                                                                        If r4321slope.Text >= -0.1 Then
                                                                                                                                            If r4321slope.Text <= 0.1 Then
                                                                                                                                                If r5321slope.Text >= -0.1 Then
                                                                                                                                                    If r5321slope.Text <= 0.1 Then
                                                                                                                                                        If r6321slope.Text >= -0.1 Then
                                                                                                                                                            If r6321slope.Text <= 0.1 Then
                                                                                                                                                                If phaseNumber.Text = 1 Then
                                                                                                                                                                    interPhaseText.Visible = True
                                                                                                                                                                    interPhaseInterval.Enabled = True
                                                                                                                                                                    SessionTime.Enabled = False
                                                                                                                                                                    csvTextBox.Text = "Phase 1 ended at 800-sec" + ","
                                                                                                                                                                End If
                                                                                                                                                            End If
                                                                                                                                                        End If
                                                                                                                                                    End If
                                                                                                                                                End If
                                                                                                                                            End If
                                                                                                                                        End If
                                                                                                                                    End If
                                                                                                                                End If
                                                                                                                            End If
                                                                                                                        End If
                                                                                                                    End If
                                                                                                                End If
                                                                                                            End If
                                                                                                        End If
                                                                                                    End If
                                                                                                End If
                                                                                            End If
                                                                                        End If
                                                                                    End If
                                                                                End If
                                                                            End If
                                                                        End If
                                                                    End If
                                                                End If
                                                            End If
                                                        End If
                                                    End If
                                                End If
                                            End If
                                        End If
                                    End If
                                End If
                            End If
                        End If
                    End If
                End If
            End If
            If TimeLeft.Text = 960 Then
                SessionTime.Enabled = False
                interPhaseText.Visible = True
                interPhaseInterval.Enabled = True
                SessionTime.Enabled = False
                csvTextBox.Text = "Phase 1 ended at 960-sec" + ","
            End If
        End If
        '------------------------------------------------------------------------------------------------------------------------------------------------------------------
        'Code for Phase 2. 
        If phaseNumber.Text = 2 Then
            If phase1Time.Text > 0 Then
                phase1Time.Text = Val(phase1Time.Text) - 1
            End If
            If phase1Time.Text = 0 Then
                interPhaseText.Visible = True
                interPhaseInterval.Enabled = True
                SessionTime.Enabled = False
                csvTextBox.Text = csvTextBox.Text + "Ph 2 ended at same duration as Ph 1" + ","
            End If
            If phase2Time.Text > 0 Then
                phase2Time.Text = Val(phase2Time.Text) - 1
            End If
            If phase2Time.Text = 0 Then
                'Code for stability criteria across all three levers taken at 2-min intervals beginning at 6 minutes into Phase 2. 
                If phase2Time.Text = 0 Then
                    If TimeLeft.Text = 960 Then
                        If r1sess6.Text = 0 Then
                            r1sess6.Text = r1sess6.Text + 0.01
                        End If
                        If r1sess7.Text = 0 Then
                            r1sess7.Text = r1sess7.Text + 0.02
                        End If
                        If r1sess8.Text = 0 Then
                            r1sess8.Text = r1sess8.Text + 0.03
                        End If
                        If r2sess6.Text = 0 Then
                            r2sess6.Text = r2sess6.Text + 0.01
                        End If
                        If r2sess7.Text = 0 Then
                            r2sess7.Text = r2sess7.Text + 0.02
                        End If
                        If r2sess8.Text = 0 Then
                            r2sess8.Text = r2sess8.Text + 0.03
                        End If
                        If r3sess6.Text = 0 Then
                            r3sess6.Text = r3sess6.Text + 0.01
                        End If
                        If r3sess7.Text = 0 Then
                            r3sess7.Text = r3sess7.Text + 0.02
                        End If
                        If r3sess8.Text = 0 Then
                            r3sess8.Text = r3sess8.Text + 0.03
                        End If
                        If r4sess6.Text = 0 Then
                            r4sess6.Text = r4sess6.Text + 0.01
                        End If
                        If r4sess7.Text = 0 Then
                            r4sess7.Text = r4sess7.Text + 0.02
                        End If
                        If r4sess8.Text = 0 Then
                            r4sess8.Text = r4sess8.Text + 0.03
                        End If
                        If r5sess6.Text = 0 Then
                            r5sess6.Text = r5sess6.Text + 0.01
                        End If
                        If r5sess7.Text = 0 Then
                            r5sess7.Text = r5sess7.Text + 0.02
                        End If
                        If r5sess8.Text = 0 Then
                            r5sess8.Text = r5sess8.Text + 0.03
                        End If
                        If r6sess6.Text = 0 Then
                            r6sess6.Text = r6sess6.Text + 0.01
                        End If
                        If r6sess7.Text = 0 Then
                            r6sess7.Text = r6sess7.Text + 0.02
                        End If
                        If r6sess8.Text = 0 Then
                            r6sess8.Text = r6sess8.Text + 0.03
                        End If
                        'Target response
                        r121.Text = Val(r1sess8.Text) - Val(r1sess7.Text)
                        r132.Text = Val(r1sess7.Text) - Val(r1sess6.Text)
                        Dim sloper1 As Integer
                        sloper1 = (Val(r121.Text) + Val(r132.Text)) / 2
                        r1321Tot.Text = Val(r1sess6.Text) + Val(r1sess7.Text) + Val(r1sess8.Text)
                        r1321slope.Text = sloper1 / Val(r1321Tot.Text)
                        'Alternative 1 response
                        r221.Text = Val(r2sess8.Text) - Val(r2sess7.Text)
                        r232.Text = Val(r2sess7.Text) - Val(r2sess6.Text)
                        Dim sloper2 As Integer
                        sloper2 = (Val(r221.Text) + Val(r232.Text)) / 2
                        r2321Tot.Text = Val(r2sess6.Text) + Val(r2sess7.Text) + Val(r2sess8.Text)
                        r2321slope.Text = sloper2 / Val(r2321Tot.Text)
                        'Alternative 2 response
                        r421.Text = Val(r4sess8.Text) - Val(r4sess7.Text)
                        r432.Text = Val(r4sess7.Text) - Val(r4sess6.Text)
                        Dim sloper4 As Integer
                        sloper4 = (Val(r421.Text) + Val(r432.Text)) / 2
                        r4321Tot.Text = Val(r4sess6.Text) + Val(r4sess7.Text) + Val(r4sess8.Text)
                        r4321slope.Text = sloper4 / Val(r4321Tot.Text)
                        'Alternative 3 response
                        r521.Text = Val(r5sess8.Text) - Val(r5sess7.Text)
                        r532.Text = Val(r5sess7.Text) - Val(r5sess6.Text)
                        Dim sloper5 As Integer
                        sloper5 = (Val(r521.Text) + Val(r532.Text)) / 2
                        r5321Tot.Text = Val(r5sess6.Text) + Val(r5sess7.Text) + Val(r5sess8.Text)
                        r5321slope.Text = sloper5 / Val(r5321Tot.Text)
                        'Alternative 4 response
                        r621.Text = Val(r6sess8.Text) - Val(r6sess7.Text)
                        r632.Text = Val(r6sess7.Text) - Val(r6sess6.Text)
                        Dim sloper6 As Integer
                        sloper6 = (Val(r621.Text) + Val(r632.Text)) / 2
                        r6321Tot.Text = Val(r6sess6.Text) + Val(r6sess7.Text) + Val(r6sess8.Text)
                        r6321slope.Text = sloper6 / Val(r6321Tot.Text)
                        'Inactive control
                        r321.Text = Val(r3sess8.Text) - Val(r3sess7.Text)
                        r332.Text = Val(r3sess7.Text) - Val(r3sess6.Text)
                        Dim sloper3 As Integer
                        sloper3 = (Val(r321.Text) + Val(r332.Text)) / 2
                        r3321Tot.Text = Val(r3sess6.Text) + Val(r3sess7.Text) + Val(r3sess8.Text)
                        r3321slope.Text = sloper3 / Val(r3321Tot.Text)
                        'Code for stability determination. 
                        If r121.Text <= 6 Then
                            If r121.Text >= -6 Then
                                If r132.Text <= 6 Then
                                    If r132.Text >= -6 Then
                                        If r221.Text <= 6 Then
                                            If r221.Text >= -6 Then
                                                If r232.Text <= 6 Then
                                                    If r232.Text >= -6 Then
                                                        If r321.Text <= 6 Then
                                                            If r321.Text >= -6 Then
                                                                If r332.Text <= 6 Then
                                                                    If r332.Text >= -6 Then
                                                                        If r421.Text <= 6 Then
                                                                            If r421.Text >= -6 Then
                                                                                If r432.Text <= 6 Then
                                                                                    If r432.Text >= -6 Then
                                                                                        If r521.Text <= 6 Then
                                                                                            If r521.Text >= -6 Then
                                                                                                If r532.Text <= 6 Then
                                                                                                    If r532.Text >= -6 Then
                                                                                                        If r621.Text <= 6 Then
                                                                                                            If r621.Text >= -6 Then
                                                                                                                If r632.Text <= 6 Then
                                                                                                                    If r632.Text >= -6 Then
                                                                                                                        If r1321slope.Text >= -0.1 Then
                                                                                                                            If r1321slope.Text <= 0.1 Then
                                                                                                                                If r2321slope.Text >= -0.1 Then
                                                                                                                                    If r2321slope.Text <= 0.1 Then
                                                                                                                                        If r3321slope.Text >= -0.1 Then
                                                                                                                                            If r3321slope.Text <= 0.1 Then
                                                                                                                                                If r4321slope.Text >= -0.1 Then
                                                                                                                                                    If r4321slope.Text <= 0.1 Then
                                                                                                                                                        If r5321slope.Text >= -0.1 Then
                                                                                                                                                            If r5321slope.Text <= 0.1 Then
                                                                                                                                                                If r6321slope.Text >= -0.1 Then
                                                                                                                                                                    If r6321slope.Text <= 0.1 Then
                                                                                                                                                                        If phaseNumber.Text = 2 Then
                                                                                                                                                                            interPhaseText.Visible = True
                                                                                                                                                                            interPhaseInterval.Enabled = True
                                                                                                                                                                            SessionTime.Enabled = False
                                                                                                                                                                            csvTextBox.Text = csvTextBox.Text + "Phase 2 ended at 960-sec" + ","
                                                                                                                                                                        End If
                                                                                                                                                                    End If
                                                                                                                                                                End If
                                                                                                                                                            End If
                                                                                                                                                        End If
                                                                                                                                                    End If
                                                                                                                                                End If
                                                                                                                                            End If
                                                                                                                                        End If
                                                                                                                                    End If
                                                                                                                                End If
                                                                                                                            End If
                                                                                                                        End If
                                                                                                                    End If
                                                                                                                End If
                                                                                                            End If
                                                                                                        End If
                                                                                                    End If
                                                                                                End If
                                                                                            End If
                                                                                        End If
                                                                                    End If
                                                                                End If
                                                                            End If
                                                                        End If
                                                                    End If
                                                                End If
                                                            End If
                                                        End If
                                                    End If
                                                End If
                                            End If
                                        End If
                                    End If
                                End If
                            End If
                        End If
                    End If
                    If TimeLeft.Text = 1080 Then
                        If r1sess7.Text = 0 Then
                            r1sess7.Text = r1sess7.Text + 0.01
                        End If
                        If r1sess8.Text = 0 Then
                            r1sess8.Text = r1sess8.Text + 0.02
                        End If
                        If r1sess9.Text = 0 Then
                            r1sess9.Text = r1sess9.Text + 0.03
                        End If
                        If r2sess7.Text = 0 Then
                            r2sess7.Text = r2sess7.Text + 0.01
                        End If
                        If r2sess8.Text = 0 Then
                            r2sess8.Text = r2sess8.Text + 0.02
                        End If
                        If r2sess9.Text = 0 Then
                            r2sess9.Text = r2sess9.Text + 0.03
                        End If
                        If r3sess7.Text = 0 Then
                            r3sess7.Text = r3sess7.Text + 0.01
                        End If
                        If r3sess8.Text = 0 Then
                            r3sess8.Text = r3sess8.Text + 0.02
                        End If
                        If r3sess9.Text = 0 Then
                            r3sess9.Text = r3sess9.Text + 0.03
                        End If
                        If r4sess7.Text = 0 Then
                            r4sess7.Text = r4sess7.Text + 0.01
                        End If
                        If r4sess8.Text = 0 Then
                            r4sess8.Text = r4sess8.Text + 0.02
                        End If
                        If r4sess9.Text = 0 Then
                            r4sess9.Text = r4sess9.Text + 0.03
                        End If
                        If r5sess7.Text = 0 Then
                            r5sess7.Text = r5sess7.Text + 0.01
                        End If
                        If r5sess8.Text = 0 Then
                            r5sess8.Text = r5sess8.Text + 0.02
                        End If
                        If r5sess9.Text = 0 Then
                            r5sess9.Text = r5sess9.Text + 0.03
                        End If
                        If r6sess7.Text = 0 Then
                            r6sess7.Text = r6sess7.Text + 0.01
                        End If
                        If r6sess8.Text = 0 Then
                            r6sess8.Text = r6sess8.Text + 0.02
                        End If
                        If r6sess9.Text = 0 Then
                            r6sess9.Text = r6sess9.Text + 0.03
                        End If
                        'Target response
                        r121.Text = Val(r1sess9.Text) - Val(r1sess8.Text)
                        r132.Text = Val(r1sess8.Text) - Val(r1sess7.Text)
                        Dim sloper1 As Integer
                        sloper1 = (Val(r121.Text) + Val(r132.Text)) / 2
                        r1321Tot.Text = Val(r1sess7.Text) + Val(r1sess8.Text) + Val(r1sess9.Text)
                        r1321slope.Text = sloper1 / Val(r1321Tot.Text)
                        'Alternative 1 response
                        r221.Text = Val(r2sess9.Text) - Val(r2sess8.Text)
                        r232.Text = Val(r2sess8.Text) - Val(r2sess7.Text)
                        Dim sloper2 As Integer
                        sloper2 = (Val(r221.Text) + Val(r232.Text)) / 2
                        r2321Tot.Text = Val(r2sess7.Text) + Val(r2sess8.Text) + Val(r2sess9.Text)
                        r2321slope.Text = sloper2 / Val(r2321Tot.Text)
                        'Alternative 2 response
                        r421.Text = Val(r4sess9.Text) - Val(r4sess8.Text)
                        r432.Text = Val(r4sess8.Text) - Val(r4sess7.Text)
                        Dim sloper4 As Integer
                        sloper4 = (Val(r421.Text) + Val(r432.Text)) / 2
                        r4321Tot.Text = Val(r4sess7.Text) + Val(r4sess8.Text) + Val(r4sess9.Text)
                        r4321slope.Text = sloper4 / Val(r4321Tot.Text)
                        'Alternative 3 response
                        r521.Text = Val(r5sess9.Text) - Val(r5sess8.Text)
                        r532.Text = Val(r5sess8.Text) - Val(r5sess7.Text)
                        Dim sloper5 As Integer
                        sloper5 = (Val(r521.Text) + Val(r532.Text)) / 2
                        r5321Tot.Text = Val(r5sess7.Text) + Val(r5sess8.Text) + Val(r5sess9.Text)
                        r5321slope.Text = sloper5 / Val(r5321Tot.Text)
                        'Alternative 4 response
                        r621.Text = Val(r6sess9.Text) - Val(r6sess8.Text)
                        r632.Text = Val(r6sess8.Text) - Val(r6sess7.Text)
                        Dim sloper6 As Integer
                        sloper6 = (Val(r621.Text) + Val(r632.Text)) / 2
                        r6321Tot.Text = Val(r6sess7.Text) + Val(r6sess8.Text) + Val(r6sess9.Text)
                        r6321slope.Text = sloper6 / Val(r6321Tot.Text)
                        'Inactive control
                        r321.Text = Val(r3sess9.Text) - Val(r3sess8.Text)
                        r332.Text = Val(r3sess8.Text) - Val(r3sess7.Text)
                        Dim sloper3 As Integer
                        sloper3 = (Val(r321.Text) + Val(r332.Text)) / 2
                        r3321Tot.Text = Val(r3sess7.Text) + Val(r3sess8.Text) + Val(r3sess9.Text)
                        r3321slope.Text = sloper3 / Val(r3321Tot.Text)
                        'Code for stability determination. 
                        If r121.Text <= 6 Then
                            If r121.Text >= -6 Then
                                If r132.Text <= 6 Then
                                    If r132.Text >= -6 Then
                                        If r221.Text <= 6 Then
                                            If r221.Text >= -6 Then
                                                If r232.Text <= 6 Then
                                                    If r232.Text >= -6 Then
                                                        If r321.Text <= 6 Then
                                                            If r321.Text >= -6 Then
                                                                If r332.Text <= 6 Then
                                                                    If r332.Text >= -6 Then
                                                                        If r421.Text <= 6 Then
                                                                            If r421.Text >= -6 Then
                                                                                If r432.Text <= 6 Then
                                                                                    If r432.Text >= -6 Then
                                                                                        If r521.Text <= 6 Then
                                                                                            If r521.Text >= -6 Then
                                                                                                If r532.Text <= 6 Then
                                                                                                    If r532.Text >= -6 Then
                                                                                                        If r621.Text <= 6 Then
                                                                                                            If r621.Text >= -6 Then
                                                                                                                If r632.Text <= 6 Then
                                                                                                                    If r632.Text >= -6 Then
                                                                                                                        If r1321slope.Text >= -0.1 Then
                                                                                                                            If r1321slope.Text <= 0.1 Then
                                                                                                                                If r2321slope.Text >= -0.1 Then
                                                                                                                                    If r2321slope.Text <= 0.1 Then
                                                                                                                                        If r3321slope.Text >= -0.1 Then
                                                                                                                                            If r3321slope.Text <= 0.1 Then
                                                                                                                                                If r4321slope.Text >= -0.1 Then
                                                                                                                                                    If r4321slope.Text <= 0.1 Then
                                                                                                                                                        If r5321slope.Text >= -0.1 Then
                                                                                                                                                            If r5321slope.Text <= 0.1 Then
                                                                                                                                                                If r6321slope.Text >= -0.1 Then
                                                                                                                                                                    If r6321slope.Text <= 0.1 Then
                                                                                                                                                                        If phaseNumber.Text = 2 Then
                                                                                                                                                                            interPhaseText.Visible = True
                                                                                                                                                                            interPhaseInterval.Enabled = True
                                                                                                                                                                            SessionTime.Enabled = False
                                                                                                                                                                            csvTextBox.Text = csvTextBox.Text + "Phase 2 ended at 1080-sec" + ","
                                                                                                                                                                        End If
                                                                                                                                                                    End If
                                                                                                                                                                End If
                                                                                                                                                            End If
                                                                                                                                                        End If
                                                                                                                                                    End If
                                                                                                                                                End If
                                                                                                                                            End If
                                                                                                                                        End If
                                                                                                                                    End If
                                                                                                                                End If
                                                                                                                            End If
                                                                                                                        End If
                                                                                                                    End If
                                                                                                                End If
                                                                                                            End If
                                                                                                        End If
                                                                                                    End If
                                                                                                End If
                                                                                            End If
                                                                                        End If
                                                                                    End If
                                                                                End If
                                                                            End If
                                                                        End If
                                                                    End If
                                                                End If
                                                            End If
                                                        End If
                                                    End If
                                                End If
                                            End If
                                        End If
                                    End If
                                End If
                            End If
                        End If
                    End If
                    If TimeLeft.Text = 1200 Then
                        If r1sess8.Text = 0 Then
                            r1sess8.Text = r1sess8.Text + 0.01
                        End If
                        If r1sess9.Text = 0 Then
                            r1sess9.Text = r1sess9.Text + 0.02
                        End If
                        If r1sess10.Text = 0 Then
                            r1sess10.Text = r1sess10.Text + 0.03
                        End If
                        If r2sess8.Text = 0 Then
                            r2sess8.Text = r2sess8.Text + 0.01
                        End If
                        If r2sess9.Text = 0 Then
                            r2sess9.Text = r2sess9.Text + 0.02
                        End If
                        If r2sess10.Text = 0 Then
                            r2sess10.Text = r2sess10.Text + 0.03
                        End If
                        If r3sess8.Text = 0 Then
                            r3sess8.Text = r3sess8.Text + 0.01
                        End If
                        If r3sess9.Text = 0 Then
                            r3sess9.Text = r3sess9.Text + 0.02
                        End If
                        If r3sess10.Text = 0 Then
                            r3sess10.Text = r3sess10.Text + 0.03
                        End If
                        If r4sess8.Text = 0 Then
                            r4sess8.Text = r4sess8.Text + 0.01
                        End If
                        If r4sess9.Text = 0 Then
                            r4sess9.Text = r4sess9.Text + 0.02
                        End If
                        If r4sess10.Text = 0 Then
                            r4sess10.Text = r4sess10.Text + 0.03
                        End If
                        If r5sess8.Text = 0 Then
                            r5sess8.Text = r5sess8.Text + 0.01
                        End If
                        If r5sess9.Text = 0 Then
                            r5sess9.Text = r5sess9.Text + 0.02
                        End If
                        If r5sess10.Text = 0 Then
                            r5sess10.Text = r5sess10.Text + 0.03
                        End If
                        If r6sess8.Text = 0 Then
                            r6sess8.Text = r6sess8.Text + 0.01
                        End If
                        If r6sess9.Text = 0 Then
                            r6sess9.Text = r6sess9.Text + 0.02
                        End If
                        If r6sess10.Text = 0 Then
                            r6sess10.Text = r6sess10.Text + 0.03
                        End If
                        'Target response
                        r121.Text = Val(r1sess10.Text) - Val(r1sess9.Text)
                        r132.Text = Val(r1sess9.Text) - Val(r1sess8.Text)
                        Dim sloper1 As Integer
                        sloper1 = (Val(r121.Text) + Val(r132.Text)) / 2
                        r1321Tot.Text = Val(r1sess8.Text) + Val(r1sess9.Text) + Val(r1sess10.Text)
                        r1321slope.Text = sloper1 / Val(r1321Tot.Text)
                        'Alternative 1 response
                        r221.Text = Val(r2sess10.Text) - Val(r2sess9.Text)
                        r232.Text = Val(r2sess9.Text) - Val(r2sess8.Text)
                        Dim sloper2 As Integer
                        sloper2 = (Val(r221.Text) + Val(r232.Text)) / 2
                        r2321Tot.Text = Val(r2sess8.Text) + Val(r2sess9.Text) + Val(r2sess10.Text)
                        r2321slope.Text = sloper2 / Val(r2321Tot.Text)
                        'Alternative 2 response
                        r421.Text = Val(r4sess10.Text) - Val(r4sess9.Text)
                        r432.Text = Val(r4sess9.Text) - Val(r4sess8.Text)
                        Dim sloper4 As Integer
                        sloper4 = (Val(r421.Text) + Val(r432.Text)) / 2
                        r4321Tot.Text = Val(r4sess8.Text) + Val(r4sess9.Text) + Val(r4sess10.Text)
                        r4321slope.Text = sloper4 / Val(r4321Tot.Text)
                        'Alternative 3 response
                        r521.Text = Val(r5sess10.Text) - Val(r5sess9.Text)
                        r532.Text = Val(r5sess9.Text) - Val(r5sess8.Text)
                        Dim sloper5 As Integer
                        sloper5 = (Val(r521.Text) + Val(r532.Text)) / 2
                        r5321Tot.Text = Val(r5sess8.Text) + Val(r5sess9.Text) + Val(r5sess10.Text)
                        r5321slope.Text = sloper5 / Val(r5321Tot.Text)
                        'Alternative 4 response
                        r621.Text = Val(r6sess10.Text) - Val(r6sess9.Text)
                        r632.Text = Val(r6sess9.Text) - Val(r6sess8.Text)
                        Dim sloper6 As Integer
                        sloper6 = (Val(r621.Text) + Val(r632.Text)) / 2
                        r6321Tot.Text = Val(r6sess8.Text) + Val(r6sess9.Text) + Val(r6sess10.Text)
                        r6321slope.Text = sloper6 / Val(r6321Tot.Text)
                        'Inactive control
                        r321.Text = Val(r3sess10.Text) - Val(r3sess9.Text)
                        r332.Text = Val(r3sess9.Text) - Val(r3sess8.Text)
                        Dim sloper3 As Integer
                        sloper3 = (Val(r321.Text) + Val(r332.Text)) / 2
                        r3321Tot.Text = Val(r3sess8.Text) + Val(r3sess9.Text) + Val(r3sess10.Text)
                        r3321slope.Text = sloper3 / Val(r3321Tot.Text)
                        'Code for stability determination. 
                        If r121.Text <= 6 Then
                            If r121.Text >= -6 Then
                                If r132.Text <= 6 Then
                                    If r132.Text >= -6 Then
                                        If r221.Text <= 6 Then
                                            If r221.Text >= -6 Then
                                                If r232.Text <= 6 Then
                                                    If r232.Text >= -6 Then
                                                        If r321.Text <= 6 Then
                                                            If r321.Text >= -6 Then
                                                                If r332.Text <= 6 Then
                                                                    If r332.Text >= -6 Then
                                                                        If r421.Text <= 6 Then
                                                                            If r421.Text >= -6 Then
                                                                                If r432.Text <= 6 Then
                                                                                    If r432.Text >= -6 Then
                                                                                        If r521.Text <= 6 Then
                                                                                            If r521.Text >= -6 Then
                                                                                                If r532.Text <= 6 Then
                                                                                                    If r532.Text >= -6 Then
                                                                                                        If r621.Text <= 6 Then
                                                                                                            If r621.Text >= -6 Then
                                                                                                                If r632.Text <= 6 Then
                                                                                                                    If r632.Text >= -6 Then
                                                                                                                        If r1321slope.Text >= -0.1 Then
                                                                                                                            If r1321slope.Text <= 0.1 Then
                                                                                                                                If r2321slope.Text >= -0.1 Then
                                                                                                                                    If r2321slope.Text <= 0.1 Then
                                                                                                                                        If r3321slope.Text >= -0.1 Then
                                                                                                                                            If r3321slope.Text <= 0.1 Then
                                                                                                                                                If r4321slope.Text >= -0.1 Then
                                                                                                                                                    If r4321slope.Text <= 0.1 Then
                                                                                                                                                        If r5321slope.Text >= -0.1 Then
                                                                                                                                                            If r5321slope.Text <= 0.1 Then
                                                                                                                                                                If r6321slope.Text >= -0.1 Then
                                                                                                                                                                    If r6321slope.Text <= 0.1 Then
                                                                                                                                                                        If phaseNumber.Text = 2 Then
                                                                                                                                                                            interPhaseText.Visible = True
                                                                                                                                                                            interPhaseInterval.Enabled = True
                                                                                                                                                                            SessionTime.Enabled = False
                                                                                                                                                                            csvTextBox.Text = csvTextBox.Text + "Phase 2 ended at 1200-sec" + ","
                                                                                                                                                                        End If
                                                                                                                                                                    End If
                                                                                                                                                                End If
                                                                                                                                                            End If
                                                                                                                                                        End If
                                                                                                                                                    End If
                                                                                                                                                End If
                                                                                                                                            End If
                                                                                                                                        End If
                                                                                                                                    End If
                                                                                                                                End If
                                                                                                                            End If
                                                                                                                        End If
                                                                                                                    End If
                                                                                                                End If
                                                                                                            End If
                                                                                                        End If
                                                                                                    End If
                                                                                                End If
                                                                                            End If
                                                                                        End If
                                                                                    End If
                                                                                End If
                                                                            End If
                                                                        End If
                                                                    End If
                                                                End If
                                                            End If
                                                        End If
                                                    End If
                                                End If
                                            End If
                                        End If
                                    End If
                                End If
                            End If
                        End If
                    End If
                    If TimeLeft.Text = 1320 Then
                        If r1sess9.Text = 0 Then
                            r1sess9.Text = r1sess9.Text + 0.01
                        End If
                        If r1sess10.Text = 0 Then
                            r1sess10.Text = r1sess10.Text + 0.02
                        End If
                        If r1sess11.Text = 0 Then
                            r1sess11.Text = r1sess11.Text + 0.03
                        End If
                        If r2sess9.Text = 0 Then
                            r2sess9.Text = r2sess9.Text + 0.01
                        End If
                        If r2sess10.Text = 0 Then
                            r2sess10.Text = r2sess10.Text + 0.02
                        End If
                        If r2sess11.Text = 0 Then
                            r2sess11.Text = r2sess11.Text + 0.03
                        End If
                        If r3sess9.Text = 0 Then
                            r3sess9.Text = r3sess9.Text + 0.01
                        End If
                        If r3sess10.Text = 0 Then
                            r3sess10.Text = r3sess10.Text + 0.02
                        End If
                        If r3sess11.Text = 0 Then
                            r3sess11.Text = r3sess11.Text + 0.03
                        End If
                        If r4sess9.Text = 0 Then
                            r4sess9.Text = r4sess9.Text + 0.01
                        End If
                        If r4sess10.Text = 0 Then
                            r4sess10.Text = r4sess10.Text + 0.02
                        End If
                        If r4sess11.Text = 0 Then
                            r4sess11.Text = r4sess11.Text + 0.03
                        End If
                        If r5sess9.Text = 0 Then
                            r5sess9.Text = r5sess9.Text + 0.01
                        End If
                        If r5sess10.Text = 0 Then
                            r5sess10.Text = r5sess10.Text + 0.02
                        End If
                        If r5sess11.Text = 0 Then
                            r5sess11.Text = r5sess11.Text + 0.03
                        End If
                        If r6sess9.Text = 0 Then
                            r6sess9.Text = r6sess9.Text + 0.01
                        End If
                        If r6sess10.Text = 0 Then
                            r6sess10.Text = r6sess10.Text + 0.02
                        End If
                        If r6sess11.Text = 0 Then
                            r6sess11.Text = r6sess11.Text + 0.03
                        End If
                        'Target response
                        r121.Text = Val(r1sess11.Text) - Val(r1sess10.Text)
                        r132.Text = Val(r1sess10.Text) - Val(r1sess9.Text)
                        Dim sloper1 As Integer
                        sloper1 = (Val(r121.Text) + Val(r132.Text)) / 2
                        r1321Tot.Text = Val(r1sess9.Text) + Val(r1sess10.Text) + Val(r1sess11.Text)
                        r1321slope.Text = sloper1 / Val(r1321Tot.Text)
                        'Alternative 1 response
                        r221.Text = Val(r2sess11.Text) - Val(r2sess10.Text)
                        r232.Text = Val(r2sess10.Text) - Val(r2sess9.Text)
                        Dim sloper2 As Integer
                        sloper2 = (Val(r221.Text) + Val(r232.Text)) / 2
                        r2321Tot.Text = Val(r2sess9.Text) + Val(r2sess10.Text) + Val(r2sess11.Text)
                        r2321slope.Text = sloper2 / Val(r2321Tot.Text)
                        'Alternative 2 response
                        r421.Text = Val(r4sess11.Text) - Val(r4sess10.Text)
                        r432.Text = Val(r4sess10.Text) - Val(r4sess9.Text)
                        Dim sloper4 As Integer
                        sloper4 = (Val(r421.Text) + Val(r432.Text)) / 2
                        r4321Tot.Text = Val(r4sess9.Text) + Val(r4sess10.Text) + Val(r4sess11.Text)
                        r4321slope.Text = sloper4 / Val(r4321Tot.Text)
                        'Alternative 3 response
                        r521.Text = Val(r5sess11.Text) - Val(r5sess10.Text)
                        r532.Text = Val(r5sess10.Text) - Val(r5sess9.Text)
                        Dim sloper5 As Integer
                        sloper5 = (Val(r521.Text) + Val(r532.Text)) / 2
                        r5321Tot.Text = Val(r5sess9.Text) + Val(r5sess10.Text) + Val(r5sess11.Text)
                        r5321slope.Text = sloper5 / Val(r5321Tot.Text)
                        'Alternative 4 response
                        r621.Text = Val(r6sess11.Text) - Val(r6sess10.Text)
                        r632.Text = Val(r6sess10.Text) - Val(r6sess9.Text)
                        Dim sloper6 As Integer
                        sloper6 = (Val(r621.Text) + Val(r632.Text)) / 2
                        r6321Tot.Text = Val(r6sess9.Text) + Val(r6sess10.Text) + Val(r6sess11.Text)
                        r6321slope.Text = sloper6 / Val(r6321Tot.Text)
                        'Inactive control
                        r321.Text = Val(r3sess11.Text) - Val(r3sess10.Text)
                        r332.Text = Val(r3sess10.Text) - Val(r3sess9.Text)
                        Dim sloper3 As Integer
                        sloper3 = (Val(r321.Text) + Val(r332.Text)) / 2
                        r3321Tot.Text = Val(r3sess9.Text) + Val(r3sess10.Text) + Val(r3sess11.Text)
                        r3321slope.Text = sloper3 / Val(r3321Tot.Text)
                        'Code for stability determination. 
                        If r121.Text <= 6 Then
                            If r121.Text >= -6 Then
                                If r132.Text <= 6 Then
                                    If r132.Text >= -6 Then
                                        If r221.Text <= 6 Then
                                            If r221.Text >= -6 Then
                                                If r232.Text <= 6 Then
                                                    If r232.Text >= -6 Then
                                                        If r321.Text <= 6 Then
                                                            If r321.Text >= -6 Then
                                                                If r332.Text <= 6 Then
                                                                    If r332.Text >= -6 Then
                                                                        If r421.Text <= 6 Then
                                                                            If r421.Text >= -6 Then
                                                                                If r432.Text <= 6 Then
                                                                                    If r432.Text >= -6 Then
                                                                                        If r521.Text <= 6 Then
                                                                                            If r521.Text >= -6 Then
                                                                                                If r532.Text <= 6 Then
                                                                                                    If r532.Text >= -6 Then
                                                                                                        If r621.Text <= 6 Then
                                                                                                            If r621.Text >= -6 Then
                                                                                                                If r632.Text <= 6 Then
                                                                                                                    If r632.Text >= -6 Then
                                                                                                                        If r1321slope.Text >= -0.1 Then
                                                                                                                            If r1321slope.Text <= 0.1 Then
                                                                                                                                If r2321slope.Text >= -0.1 Then
                                                                                                                                    If r2321slope.Text <= 0.1 Then
                                                                                                                                        If r3321slope.Text >= -0.1 Then
                                                                                                                                            If r3321slope.Text <= 0.1 Then
                                                                                                                                                If r4321slope.Text >= -0.1 Then
                                                                                                                                                    If r4321slope.Text <= 0.1 Then
                                                                                                                                                        If r5321slope.Text >= -0.1 Then
                                                                                                                                                            If r5321slope.Text <= 0.1 Then
                                                                                                                                                                If r6321slope.Text >= -0.1 Then
                                                                                                                                                                    If r6321slope.Text <= 0.1 Then
                                                                                                                                                                        If phaseNumber.Text = 2 Then
                                                                                                                                                                            interPhaseText.Visible = True
                                                                                                                                                                            interPhaseInterval.Enabled = True
                                                                                                                                                                            SessionTime.Enabled = False
                                                                                                                                                                            csvTextBox.Text = csvTextBox.Text + "Phase 2 ended at 1320-sec" + ","
                                                                                                                                                                        End If
                                                                                                                                                                    End If
                                                                                                                                                                End If
                                                                                                                                                            End If
                                                                                                                                                        End If
                                                                                                                                                    End If
                                                                                                                                                End If
                                                                                                                                            End If
                                                                                                                                        End If
                                                                                                                                    End If
                                                                                                                                End If
                                                                                                                            End If
                                                                                                                        End If
                                                                                                                    End If
                                                                                                                End If
                                                                                                            End If
                                                                                                        End If
                                                                                                    End If
                                                                                                End If
                                                                                            End If
                                                                                        End If
                                                                                    End If
                                                                                End If
                                                                            End If
                                                                        End If
                                                                    End If
                                                                End If
                                                            End If
                                                        End If
                                                    End If
                                                End If
                                            End If
                                        End If
                                    End If
                                End If
                            End If
                        End If
                    End If
                    If TimeLeft.Text = 1440 Then
                        If r1sess10.Text = 0 Then
                            r1sess10.Text = r1sess10.Text + 0.01
                        End If
                        If r1sess11.Text = 0 Then
                            r1sess11.Text = r1sess11.Text + 0.02
                        End If
                        If r1sess12.Text = 0 Then
                            r1sess12.Text = r1sess12.Text + 0.03
                        End If
                        If r2sess10.Text = 0 Then
                            r2sess10.Text = r2sess10.Text + 0.01
                        End If
                        If r2sess11.Text = 0 Then
                            r2sess11.Text = r2sess11.Text + 0.02
                        End If
                        If r2sess12.Text = 0 Then
                            r2sess12.Text = r2sess12.Text + 0.03
                        End If
                        If r3sess10.Text = 0 Then
                            r3sess10.Text = r3sess10.Text + 0.01
                        End If
                        If r3sess11.Text = 0 Then
                            r3sess11.Text = r3sess11.Text + 0.02
                        End If
                        If r3sess12.Text = 0 Then
                            r3sess12.Text = r3sess12.Text + 0.03
                        End If
                        If r4sess10.Text = 0 Then
                            r4sess10.Text = r4sess10.Text + 0.01
                        End If
                        If r4sess11.Text = 0 Then
                            r4sess11.Text = r4sess11.Text + 0.02
                        End If
                        If r4sess12.Text = 0 Then
                            r4sess12.Text = r4sess12.Text + 0.03
                        End If
                        If r5sess10.Text = 0 Then
                            r5sess10.Text = r5sess10.Text + 0.01
                        End If
                        If r5sess11.Text = 0 Then
                            r5sess11.Text = r5sess11.Text + 0.02
                        End If
                        If r5sess12.Text = 0 Then
                            r5sess12.Text = r5sess12.Text + 0.03
                        End If
                        If r6sess10.Text = 0 Then
                            r6sess10.Text = r6sess10.Text + 0.01
                        End If
                        If r6sess11.Text = 0 Then
                            r6sess11.Text = r6sess11.Text + 0.02
                        End If
                        If r6sess12.Text = 0 Then
                            r6sess12.Text = r6sess12.Text + 0.03
                        End If
                        'Target response
                        r121.Text = Val(r1sess12.Text) - Val(r1sess11.Text)
                        r132.Text = Val(r1sess11.Text) - Val(r1sess10.Text)
                        Dim sloper1 As Integer
                        sloper1 = (Val(r121.Text) + Val(r132.Text)) / 2
                        r1321Tot.Text = Val(r1sess10.Text) + Val(r1sess11.Text) + Val(r1sess12.Text)
                        r1321slope.Text = sloper1 / Val(r1321Tot.Text)
                        'Alternative 1 response
                        r221.Text = Val(r2sess12.Text) - Val(r2sess11.Text)
                        r232.Text = Val(r2sess11.Text) - Val(r2sess10.Text)
                        Dim sloper2 As Integer
                        sloper2 = (Val(r221.Text) + Val(r232.Text)) / 2
                        r2321Tot.Text = Val(r2sess10.Text) + Val(r2sess11.Text) + Val(r2sess12.Text)
                        r2321slope.Text = sloper2 / Val(r2321Tot.Text)
                        'Alternative 2 response
                        r421.Text = Val(r4sess12.Text) - Val(r4sess11.Text)
                        r432.Text = Val(r4sess11.Text) - Val(r4sess10.Text)
                        Dim sloper4 As Integer
                        sloper4 = (Val(r421.Text) + Val(r432.Text)) / 2
                        r4321Tot.Text = Val(r4sess10.Text) + Val(r4sess11.Text) + Val(r4sess12.Text)
                        r4321slope.Text = sloper4 / Val(r4321Tot.Text)
                        'Alternative 3 response
                        r521.Text = Val(r5sess12.Text) - Val(r5sess11.Text)
                        r532.Text = Val(r5sess11.Text) - Val(r5sess10.Text)
                        Dim sloper5 As Integer
                        sloper5 = (Val(r521.Text) + Val(r532.Text)) / 2
                        r5321Tot.Text = Val(r5sess10.Text) + Val(r5sess11.Text) + Val(r5sess12.Text)
                        r5321slope.Text = sloper5 / Val(r5321Tot.Text)
                        'Alternative 4 response
                        r621.Text = Val(r6sess12.Text) - Val(r6sess11.Text)
                        r632.Text = Val(r6sess11.Text) - Val(r6sess10.Text)
                        Dim sloper6 As Integer
                        sloper6 = (Val(r621.Text) + Val(r632.Text)) / 2
                        r6321Tot.Text = Val(r6sess10.Text) + Val(r6sess11.Text) + Val(r6sess12.Text)
                        r6321slope.Text = sloper6 / Val(r6321Tot.Text)
                        'Inactive control
                        r321.Text = Val(r3sess12.Text) - Val(r3sess11.Text)
                        r332.Text = Val(r3sess11.Text) - Val(r3sess10.Text)
                        Dim sloper3 As Integer
                        sloper3 = (Val(r321.Text) + Val(r332.Text)) / 2
                        r3321Tot.Text = Val(r3sess10.Text) + Val(r3sess11.Text) + Val(r3sess12.Text)
                        r3321slope.Text = sloper3 / Val(r3321Tot.Text)
                        'Code for stability determination. 
                        If r121.Text <= 6 Then
                            If r121.Text >= -6 Then
                                If r132.Text <= 6 Then
                                    If r132.Text >= -6 Then
                                        If r221.Text <= 6 Then
                                            If r221.Text >= -6 Then
                                                If r232.Text <= 6 Then
                                                    If r232.Text >= -6 Then
                                                        If r321.Text <= 6 Then
                                                            If r321.Text >= -6 Then
                                                                If r332.Text <= 6 Then
                                                                    If r332.Text >= -6 Then
                                                                        If r421.Text <= 6 Then
                                                                            If r421.Text >= -6 Then
                                                                                If r432.Text <= 6 Then
                                                                                    If r432.Text >= -6 Then
                                                                                        If r521.Text <= 6 Then
                                                                                            If r521.Text >= -6 Then
                                                                                                If r532.Text <= 6 Then
                                                                                                    If r532.Text >= -6 Then
                                                                                                        If r621.Text <= 6 Then
                                                                                                            If r621.Text >= -6 Then
                                                                                                                If r632.Text <= 6 Then
                                                                                                                    If r632.Text >= -6 Then
                                                                                                                        If r1321slope.Text >= -0.1 Then
                                                                                                                            If r1321slope.Text <= 0.1 Then
                                                                                                                                If r2321slope.Text >= -0.1 Then
                                                                                                                                    If r2321slope.Text <= 0.1 Then
                                                                                                                                        If r3321slope.Text >= -0.1 Then
                                                                                                                                            If r3321slope.Text <= 0.1 Then
                                                                                                                                                If r4321slope.Text >= -0.1 Then
                                                                                                                                                    If r4321slope.Text <= 0.1 Then
                                                                                                                                                        If r5321slope.Text >= -0.1 Then
                                                                                                                                                            If r5321slope.Text <= 0.1 Then
                                                                                                                                                                If r6321slope.Text >= -0.1 Then
                                                                                                                                                                    If r6321slope.Text <= 0.1 Then
                                                                                                                                                                        If phaseNumber.Text = 2 Then
                                                                                                                                                                            interPhaseText.Visible = True
                                                                                                                                                                            interPhaseInterval.Enabled = True
                                                                                                                                                                            SessionTime.Enabled = False
                                                                                                                                                                            csvTextBox.Text = csvTextBox.Text + "Phase 2 ended at 1440-sec" + ","
                                                                                                                                                                        End If
                                                                                                                                                                    End If
                                                                                                                                                                End If
                                                                                                                                                            End If
                                                                                                                                                        End If
                                                                                                                                                    End If
                                                                                                                                                End If
                                                                                                                                            End If
                                                                                                                                        End If
                                                                                                                                    End If
                                                                                                                                End If
                                                                                                                            End If
                                                                                                                        End If
                                                                                                                    End If
                                                                                                                End If
                                                                                                            End If
                                                                                                        End If
                                                                                                    End If
                                                                                                End If
                                                                                            End If
                                                                                        End If
                                                                                    End If
                                                                                End If
                                                                            End If
                                                                        End If
                                                                    End If
                                                                End If
                                                            End If
                                                        End If
                                                    End If
                                                End If
                                            End If
                                        End If
                                    End If
                                End If
                            End If
                        End If
                    End If
                    If TimeLeft.Text = 1560 Then
                        If r1sess11.Text = 0 Then
                            r1sess11.Text = r1sess11.Text + 0.01
                        End If
                        If r1sess12.Text = 0 Then
                            r1sess12.Text = r1sess12.Text + 0.02
                        End If
                        If r1sess13.Text = 0 Then
                            r1sess13.Text = r1sess13.Text + 0.03
                        End If
                        If r2sess11.Text = 0 Then
                            r2sess11.Text = r2sess11.Text + 0.01
                        End If
                        If r2sess12.Text = 0 Then
                            r2sess12.Text = r2sess12.Text + 0.02
                        End If
                        If r2sess13.Text = 0 Then
                            r2sess13.Text = r2sess13.Text + 0.03
                        End If
                        If r3sess11.Text = 0 Then
                            r3sess11.Text = r3sess11.Text + 0.01
                        End If
                        If r3sess12.Text = 0 Then
                            r3sess12.Text = r3sess12.Text + 0.02
                        End If
                        If r3sess13.Text = 0 Then
                            r3sess13.Text = r3sess13.Text + 0.03
                        End If
                        If r4sess11.Text = 0 Then
                            r4sess11.Text = r4sess11.Text + 0.01
                        End If
                        If r4sess12.Text = 0 Then
                            r4sess12.Text = r4sess12.Text + 0.02
                        End If
                        If r4sess13.Text = 0 Then
                            r4sess13.Text = r4sess13.Text + 0.03
                        End If
                        If r5sess11.Text = 0 Then
                            r5sess11.Text = r5sess11.Text + 0.01
                        End If
                        If r5sess12.Text = 0 Then
                            r5sess12.Text = r5sess12.Text + 0.02
                        End If
                        If r5sess13.Text = 0 Then
                            r5sess13.Text = r5sess13.Text + 0.03
                        End If
                        If r6sess11.Text = 0 Then
                            r6sess11.Text = r6sess11.Text + 0.01
                        End If
                        If r6sess12.Text = 0 Then
                            r6sess12.Text = r6sess12.Text + 0.02
                        End If
                        If r6sess13.Text = 0 Then
                            r6sess13.Text = r6sess13.Text + 0.03
                        End If
                        'Target response
                        r121.Text = Val(r1sess13.Text) - Val(r1sess12.Text)
                        r132.Text = Val(r1sess12.Text) - Val(r1sess11.Text)
                        Dim sloper1 As Integer
                        sloper1 = (Val(r121.Text) + Val(r132.Text)) / 2
                        r1321Tot.Text = Val(r1sess11.Text) + Val(r1sess12.Text) + Val(r1sess13.Text)
                        r1321slope.Text = sloper1 / Val(r1321Tot.Text)
                        'Alternative 1 response
                        r221.Text = Val(r2sess13.Text) - Val(r2sess12.Text)
                        r232.Text = Val(r2sess12.Text) - Val(r2sess11.Text)
                        Dim sloper2 As Integer
                        sloper2 = (Val(r221.Text) + Val(r232.Text)) / 2
                        r2321Tot.Text = Val(r2sess11.Text) + Val(r2sess12.Text) + Val(r2sess13.Text)
                        r2321slope.Text = sloper2 / Val(r2321Tot.Text)
                        'Alternative 2 response
                        r421.Text = Val(r4sess13.Text) - Val(r4sess12.Text)
                        r432.Text = Val(r4sess12.Text) - Val(r4sess11.Text)
                        Dim sloper4 As Integer
                        sloper4 = (Val(r421.Text) + Val(r432.Text)) / 2
                        r4321Tot.Text = Val(r4sess11.Text) + Val(r4sess12.Text) + Val(r4sess13.Text)
                        r4321slope.Text = sloper4 / Val(r4321Tot.Text)
                        'Alternative 3 response
                        r521.Text = Val(r5sess13.Text) - Val(r5sess12.Text)
                        r532.Text = Val(r5sess12.Text) - Val(r5sess11.Text)
                        Dim sloper5 As Integer
                        sloper5 = (Val(r521.Text) + Val(r532.Text)) / 2
                        r5321Tot.Text = Val(r5sess11.Text) + Val(r5sess12.Text) + Val(r5sess13.Text)
                        r5321slope.Text = sloper5 / Val(r5321Tot.Text)
                        'Alternative 4 response
                        r621.Text = Val(r6sess13.Text) - Val(r6sess12.Text)
                        r632.Text = Val(r6sess12.Text) - Val(r6sess11.Text)
                        Dim sloper6 As Integer
                        sloper6 = (Val(r621.Text) + Val(r632.Text)) / 2
                        r6321Tot.Text = Val(r6sess11.Text) + Val(r6sess12.Text) + Val(r6sess13.Text)
                        r6321slope.Text = sloper6 / Val(r6321Tot.Text)
                        'Inactive control
                        r321.Text = Val(r3sess13.Text) - Val(r3sess12.Text)
                        r332.Text = Val(r3sess12.Text) - Val(r3sess11.Text)
                        Dim sloper3 As Integer
                        sloper3 = (Val(r321.Text) + Val(r332.Text)) / 2
                        r3321Tot.Text = Val(r3sess11.Text) + Val(r3sess12.Text) + Val(r3sess13.Text)
                        r3321slope.Text = sloper3 / Val(r3321Tot.Text)
                        'Code for stability determination. 
                        If r121.Text <= 6 Then
                            If r121.Text >= -6 Then
                                If r132.Text <= 6 Then
                                    If r132.Text >= -6 Then
                                        If r221.Text <= 6 Then
                                            If r221.Text >= -6 Then
                                                If r232.Text <= 6 Then
                                                    If r232.Text >= -6 Then
                                                        If r321.Text <= 6 Then
                                                            If r321.Text >= -6 Then
                                                                If r332.Text <= 6 Then
                                                                    If r332.Text >= -6 Then
                                                                        If r421.Text <= 6 Then
                                                                            If r421.Text >= -6 Then
                                                                                If r432.Text <= 6 Then
                                                                                    If r432.Text >= -6 Then
                                                                                        If r521.Text <= 6 Then
                                                                                            If r521.Text >= -6 Then
                                                                                                If r532.Text <= 6 Then
                                                                                                    If r532.Text >= -6 Then
                                                                                                        If r621.Text <= 6 Then
                                                                                                            If r621.Text >= -6 Then
                                                                                                                If r632.Text <= 6 Then
                                                                                                                    If r632.Text >= -6 Then
                                                                                                                        If r1321slope.Text >= -0.1 Then
                                                                                                                            If r1321slope.Text <= 0.1 Then
                                                                                                                                If r2321slope.Text >= -0.1 Then
                                                                                                                                    If r2321slope.Text <= 0.1 Then
                                                                                                                                        If r3321slope.Text >= -0.1 Then
                                                                                                                                            If r3321slope.Text <= 0.1 Then
                                                                                                                                                If r4321slope.Text >= -0.1 Then
                                                                                                                                                    If r4321slope.Text <= 0.1 Then
                                                                                                                                                        If r5321slope.Text >= -0.1 Then
                                                                                                                                                            If r5321slope.Text <= 0.1 Then
                                                                                                                                                                If r6321slope.Text >= -0.1 Then
                                                                                                                                                                    If r6321slope.Text <= 0.1 Then
                                                                                                                                                                        If phaseNumber.Text = 2 Then
                                                                                                                                                                            interPhaseText.Visible = True
                                                                                                                                                                            interPhaseInterval.Enabled = True
                                                                                                                                                                            SessionTime.Enabled = False
                                                                                                                                                                            csvTextBox.Text = csvTextBox.Text + "Phase 2 ended at 1560-sec" + ","
                                                                                                                                                                        End If
                                                                                                                                                                    End If
                                                                                                                                                                End If
                                                                                                                                                            End If
                                                                                                                                                        End If
                                                                                                                                                    End If
                                                                                                                                                End If
                                                                                                                                            End If
                                                                                                                                        End If
                                                                                                                                    End If
                                                                                                                                End If
                                                                                                                            End If
                                                                                                                        End If
                                                                                                                    End If
                                                                                                                End If
                                                                                                            End If
                                                                                                        End If
                                                                                                    End If
                                                                                                End If
                                                                                            End If
                                                                                        End If
                                                                                    End If
                                                                                End If
                                                                            End If
                                                                        End If
                                                                    End If
                                                                End If
                                                            End If
                                                        End If
                                                    End If
                                                End If
                                            End If
                                        End If
                                    End If
                                End If
                            End If
                        End If
                    End If
                    If TimeLeft.Text = 1680 Then
                        If r1sess12.Text = 0 Then
                            r1sess12.Text = r1sess12.Text + 0.01
                        End If
                        If r1sess13.Text = 0 Then
                            r1sess13.Text = r1sess13.Text + 0.02
                        End If
                        If r1sess14.Text = 0 Then
                            r1sess14.Text = r1sess14.Text + 0.03
                        End If
                        If r2sess12.Text = 0 Then
                            r2sess12.Text = r2sess12.Text + 0.01
                        End If
                        If r2sess13.Text = 0 Then
                            r2sess13.Text = r2sess13.Text + 0.02
                        End If
                        If r2sess14.Text = 0 Then
                            r2sess14.Text = r2sess14.Text + 0.03
                        End If
                        If r3sess12.Text = 0 Then
                            r3sess12.Text = r3sess12.Text + 0.01
                        End If
                        If r3sess13.Text = 0 Then
                            r3sess13.Text = r3sess13.Text + 0.02
                        End If
                        If r3sess14.Text = 0 Then
                            r3sess14.Text = r3sess14.Text + 0.03
                        End If
                        If r4sess12.Text = 0 Then
                            r4sess12.Text = r4sess12.Text + 0.01
                        End If
                        If r4sess13.Text = 0 Then
                            r4sess13.Text = r4sess13.Text + 0.02
                        End If
                        If r4sess14.Text = 0 Then
                            r4sess14.Text = r4sess14.Text + 0.03
                        End If
                        If r5sess12.Text = 0 Then
                            r5sess12.Text = r5sess12.Text + 0.01
                        End If
                        If r5sess13.Text = 0 Then
                            r5sess13.Text = r5sess13.Text + 0.02
                        End If
                        If r5sess14.Text = 0 Then
                            r5sess14.Text = r5sess14.Text + 0.03
                        End If
                        If r6sess12.Text = 0 Then
                            r6sess12.Text = r6sess12.Text + 0.01
                        End If
                        If r6sess13.Text = 0 Then
                            r6sess13.Text = r6sess13.Text + 0.02
                        End If
                        If r6sess14.Text = 0 Then
                            r6sess14.Text = r6sess14.Text + 0.03
                        End If
                        'Target response
                        r121.Text = Val(r1sess14.Text) - Val(r1sess13.Text)
                        r132.Text = Val(r1sess13.Text) - Val(r1sess12.Text)
                        Dim sloper1 As Integer
                        sloper1 = (Val(r121.Text) + Val(r132.Text)) / 2
                        r1321Tot.Text = Val(r1sess12.Text) + Val(r1sess13.Text) + Val(r1sess14.Text)
                        r1321slope.Text = sloper1 / Val(r1321Tot.Text)
                        'Alternative 1 response
                        r221.Text = Val(r2sess14.Text) - Val(r2sess13.Text)
                        r232.Text = Val(r2sess13.Text) - Val(r2sess12.Text)
                        Dim sloper2 As Integer
                        sloper2 = (Val(r221.Text) + Val(r232.Text)) / 2
                        r2321Tot.Text = Val(r2sess12.Text) + Val(r2sess13.Text) + Val(r2sess14.Text)
                        r2321slope.Text = sloper2 / Val(r2321Tot.Text)
                        'Alternative 2 response
                        r421.Text = Val(r4sess14.Text) - Val(r4sess13.Text)
                        r432.Text = Val(r4sess13.Text) - Val(r4sess12.Text)
                        Dim sloper4 As Integer
                        sloper4 = (Val(r421.Text) + Val(r432.Text)) / 2
                        r4321Tot.Text = Val(r4sess12.Text) + Val(r4sess13.Text) + Val(r4sess14.Text)
                        r4321slope.Text = sloper4 / Val(r4321Tot.Text)
                        'Alternative 3 response
                        r521.Text = Val(r5sess14.Text) - Val(r5sess13.Text)
                        r532.Text = Val(r5sess13.Text) - Val(r5sess12.Text)
                        Dim sloper5 As Integer
                        sloper5 = (Val(r521.Text) + Val(r532.Text)) / 2
                        r5321Tot.Text = Val(r5sess12.Text) + Val(r5sess13.Text) + Val(r5sess14.Text)
                        r5321slope.Text = sloper5 / Val(r5321Tot.Text)
                        'Alternative 4 response
                        r621.Text = Val(r6sess14.Text) - Val(r6sess13.Text)
                        r632.Text = Val(r6sess13.Text) - Val(r6sess12.Text)
                        Dim sloper6 As Integer
                        sloper6 = (Val(r621.Text) + Val(r632.Text)) / 2
                        r6321Tot.Text = Val(r6sess12.Text) + Val(r6sess13.Text) + Val(r6sess14.Text)
                        r6321slope.Text = sloper6 / Val(r6321Tot.Text)
                        'Inactive control
                        r321.Text = Val(r3sess14.Text) - Val(r3sess13.Text)
                        r332.Text = Val(r3sess13.Text) - Val(r3sess12.Text)
                        Dim sloper3 As Integer
                        sloper3 = (Val(r321.Text) + Val(r332.Text)) / 2
                        r3321Tot.Text = Val(r3sess12.Text) + Val(r3sess13.Text) + Val(r3sess14.Text)
                        r3321slope.Text = sloper3 / Val(r3321Tot.Text)
                        'Code for stability determination. 
                        If r121.Text <= 6 Then
                            If r121.Text >= -6 Then
                                If r132.Text <= 6 Then
                                    If r132.Text >= -6 Then
                                        If r221.Text <= 6 Then
                                            If r221.Text >= -6 Then
                                                If r232.Text <= 6 Then
                                                    If r232.Text >= -6 Then
                                                        If r321.Text <= 6 Then
                                                            If r321.Text >= -6 Then
                                                                If r332.Text <= 6 Then
                                                                    If r332.Text >= -6 Then
                                                                        If r421.Text <= 6 Then
                                                                            If r421.Text >= -6 Then
                                                                                If r432.Text <= 6 Then
                                                                                    If r432.Text >= -6 Then
                                                                                        If r521.Text <= 6 Then
                                                                                            If r521.Text >= -6 Then
                                                                                                If r532.Text <= 6 Then
                                                                                                    If r532.Text >= -6 Then
                                                                                                        If r621.Text <= 6 Then
                                                                                                            If r621.Text >= -6 Then
                                                                                                                If r632.Text <= 6 Then
                                                                                                                    If r632.Text >= -6 Then
                                                                                                                        If r1321slope.Text >= -0.1 Then
                                                                                                                            If r1321slope.Text <= 0.1 Then
                                                                                                                                If r2321slope.Text >= -0.1 Then
                                                                                                                                    If r2321slope.Text <= 0.1 Then
                                                                                                                                        If r3321slope.Text >= -0.1 Then
                                                                                                                                            If r3321slope.Text <= 0.1 Then
                                                                                                                                                If r4321slope.Text >= -0.1 Then
                                                                                                                                                    If r4321slope.Text <= 0.1 Then
                                                                                                                                                        If r5321slope.Text >= -0.1 Then
                                                                                                                                                            If r5321slope.Text <= 0.1 Then
                                                                                                                                                                If r6321slope.Text >= -0.1 Then
                                                                                                                                                                    If r6321slope.Text <= 0.1 Then
                                                                                                                                                                        If phaseNumber.Text = 2 Then
                                                                                                                                                                            interPhaseText.Visible = True
                                                                                                                                                                            interPhaseInterval.Enabled = True
                                                                                                                                                                            SessionTime.Enabled = False
                                                                                                                                                                            csvTextBox.Text = csvTextBox.Text + "Phase 2 ended at 1680-sec" + ","
                                                                                                                                                                        End If
                                                                                                                                                                    End If
                                                                                                                                                                End If
                                                                                                                                                            End If
                                                                                                                                                        End If
                                                                                                                                                    End If
                                                                                                                                                End If
                                                                                                                                            End If
                                                                                                                                        End If
                                                                                                                                    End If
                                                                                                                                End If
                                                                                                                            End If
                                                                                                                        End If
                                                                                                                    End If
                                                                                                                End If
                                                                                                            End If
                                                                                                        End If
                                                                                                    End If
                                                                                                End If
                                                                                            End If
                                                                                        End If
                                                                                    End If
                                                                                End If
                                                                            End If
                                                                        End If
                                                                    End If
                                                                End If
                                                            End If
                                                        End If
                                                    End If
                                                End If
                                            End If
                                        End If
                                    End If
                                End If
                            End If
                        End If
                    End If
                    If TimeLeft.Text = 1800 Then
                        If r1sess13.Text = 0 Then
                            r1sess13.Text = r1sess13.Text + 0.01
                        End If
                        If r1sess14.Text = 0 Then
                            r1sess14.Text = r1sess14.Text + 0.02
                        End If
                        If r1sess15.Text = 0 Then
                            r1sess15.Text = r1sess15.Text + 0.03
                        End If
                        If r2sess13.Text = 0 Then
                            r2sess13.Text = r2sess13.Text + 0.01
                        End If
                        If r2sess14.Text = 0 Then
                            r2sess14.Text = r2sess14.Text + 0.02
                        End If
                        If r2sess15.Text = 0 Then
                            r2sess15.Text = r2sess15.Text + 0.03
                        End If
                        If r3sess13.Text = 0 Then
                            r3sess13.Text = r3sess13.Text + 0.01
                        End If
                        If r3sess14.Text = 0 Then
                            r3sess14.Text = r3sess14.Text + 0.02
                        End If
                        If r3sess15.Text = 0 Then
                            r3sess15.Text = r3sess15.Text + 0.03
                        End If
                        If r4sess13.Text = 0 Then
                            r4sess13.Text = r4sess13.Text + 0.01
                        End If
                        If r4sess14.Text = 0 Then
                            r4sess14.Text = r4sess14.Text + 0.02
                        End If
                        If r4sess15.Text = 0 Then
                            r4sess15.Text = r4sess15.Text + 0.03
                        End If
                        If r5sess13.Text = 0 Then
                            r5sess13.Text = r5sess13.Text + 0.01
                        End If
                        If r5sess14.Text = 0 Then
                            r5sess14.Text = r5sess14.Text + 0.02
                        End If
                        If r5sess15.Text = 0 Then
                            r5sess15.Text = r5sess15.Text + 0.03
                        End If
                        If r6sess13.Text = 0 Then
                            r6sess13.Text = r6sess13.Text + 0.01
                        End If
                        If r6sess14.Text = 0 Then
                            r6sess14.Text = r6sess14.Text + 0.02
                        End If
                        If r6sess15.Text = 0 Then
                            r6sess15.Text = r6sess15.Text + 0.03
                        End If
                        'Target response
                        r121.Text = Val(r1sess15.Text) - Val(r1sess14.Text)
                        r132.Text = Val(r1sess14.Text) - Val(r1sess13.Text)
                        Dim sloper1 As Integer
                        sloper1 = (Val(r121.Text) + Val(r132.Text)) / 2
                        r1321Tot.Text = Val(r1sess13.Text) + Val(r1sess14.Text) + Val(r1sess15.Text)
                        r1321slope.Text = sloper1 / Val(r1321Tot.Text)
                        'Alternative 1 response
                        r221.Text = Val(r2sess15.Text) - Val(r2sess14.Text)
                        r232.Text = Val(r2sess14.Text) - Val(r2sess13.Text)
                        Dim sloper2 As Integer
                        sloper2 = (Val(r221.Text) + Val(r232.Text)) / 2
                        r2321Tot.Text = Val(r2sess13.Text) + Val(r2sess14.Text) + Val(r2sess15.Text)
                        r2321slope.Text = sloper2 / Val(r2321Tot.Text)
                        'Alternative 2 response
                        r421.Text = Val(r4sess15.Text) - Val(r4sess14.Text)
                        r432.Text = Val(r4sess14.Text) - Val(r4sess13.Text)
                        Dim sloper4 As Integer
                        sloper4 = (Val(r421.Text) + Val(r432.Text)) / 2
                        r4321Tot.Text = Val(r4sess13.Text) + Val(r4sess14.Text) + Val(r4sess15.Text)
                        r4321slope.Text = sloper4 / Val(r4321Tot.Text)
                        'Alternative 3 response
                        r521.Text = Val(r5sess15.Text) - Val(r5sess14.Text)
                        r532.Text = Val(r5sess14.Text) - Val(r5sess13.Text)
                        Dim sloper5 As Integer
                        sloper5 = (Val(r521.Text) + Val(r532.Text)) / 2
                        r5321Tot.Text = Val(r5sess13.Text) + Val(r5sess14.Text) + Val(r5sess15.Text)
                        r5321slope.Text = sloper5 / Val(r5321Tot.Text)
                        'Alternative 4 response
                        r621.Text = Val(r6sess15.Text) - Val(r6sess14.Text)
                        r632.Text = Val(r6sess14.Text) - Val(r6sess13.Text)
                        Dim sloper6 As Integer
                        sloper6 = (Val(r621.Text) + Val(r632.Text)) / 2
                        r6321Tot.Text = Val(r6sess13.Text) + Val(r6sess14.Text) + Val(r6sess15.Text)
                        r6321slope.Text = sloper6 / Val(r6321Tot.Text)
                        'Inactive control
                        r321.Text = Val(r3sess15.Text) - Val(r3sess14.Text)
                        r332.Text = Val(r3sess14.Text) - Val(r3sess13.Text)
                        Dim sloper3 As Integer
                        sloper3 = (Val(r321.Text) + Val(r332.Text)) / 2
                        r3321Tot.Text = Val(r3sess13.Text) + Val(r3sess14.Text) + Val(r3sess15.Text)
                        r3321slope.Text = sloper3 / Val(r3321Tot.Text)
                        'Code for stability determination. 
                        If r121.Text <= 6 Then
                            If r121.Text >= -6 Then
                                If r132.Text <= 6 Then
                                    If r132.Text >= -6 Then
                                        If r221.Text <= 6 Then
                                            If r221.Text >= -6 Then
                                                If r232.Text <= 6 Then
                                                    If r232.Text >= -6 Then
                                                        If r321.Text <= 6 Then
                                                            If r321.Text >= -6 Then
                                                                If r332.Text <= 6 Then
                                                                    If r332.Text >= -6 Then
                                                                        If r421.Text <= 6 Then
                                                                            If r421.Text >= -6 Then
                                                                                If r432.Text <= 6 Then
                                                                                    If r432.Text >= -6 Then
                                                                                        If r521.Text <= 6 Then
                                                                                            If r521.Text >= -6 Then
                                                                                                If r532.Text <= 6 Then
                                                                                                    If r532.Text >= -6 Then
                                                                                                        If r621.Text <= 6 Then
                                                                                                            If r621.Text >= -6 Then
                                                                                                                If r632.Text <= 6 Then
                                                                                                                    If r632.Text >= -6 Then
                                                                                                                        If r1321slope.Text >= -0.1 Then
                                                                                                                            If r1321slope.Text <= 0.1 Then
                                                                                                                                If r2321slope.Text >= -0.1 Then
                                                                                                                                    If r2321slope.Text <= 0.1 Then
                                                                                                                                        If r3321slope.Text >= -0.1 Then
                                                                                                                                            If r3321slope.Text <= 0.1 Then
                                                                                                                                                If r4321slope.Text >= -0.1 Then
                                                                                                                                                    If r4321slope.Text <= 0.1 Then
                                                                                                                                                        If r5321slope.Text >= -0.1 Then
                                                                                                                                                            If r5321slope.Text <= 0.1 Then
                                                                                                                                                                If r6321slope.Text >= -0.1 Then
                                                                                                                                                                    If r6321slope.Text <= 0.1 Then
                                                                                                                                                                        If phaseNumber.Text = 2 Then
                                                                                                                                                                            interPhaseText.Visible = True
                                                                                                                                                                            interPhaseInterval.Enabled = True
                                                                                                                                                                            SessionTime.Enabled = False
                                                                                                                                                                            csvTextBox.Text = csvTextBox.Text + "Phase 2 ended at 1800-sec" + ","
                                                                                                                                                                        End If
                                                                                                                                                                    End If
                                                                                                                                                                End If
                                                                                                                                                            End If
                                                                                                                                                        End If
                                                                                                                                                    End If
                                                                                                                                                End If
                                                                                                                                            End If
                                                                                                                                        End If
                                                                                                                                    End If
                                                                                                                                End If
                                                                                                                            End If
                                                                                                                        End If
                                                                                                                    End If
                                                                                                                End If
                                                                                                            End If
                                                                                                        End If
                                                                                                    End If
                                                                                                End If
                                                                                            End If
                                                                                        End If
                                                                                    End If
                                                                                End If
                                                                            End If
                                                                        End If
                                                                    End If
                                                                End If
                                                            End If
                                                        End If
                                                    End If
                                                End If
                                            End If
                                        End If
                                    End If
                                End If
                            End If
                        End If
                    End If
                    If TimeLeft.Text = 1920 Then
                        SessionTime.Enabled = False
                        interPhaseText.Visible = True
                        interPhaseInterval.Enabled = True
                        SessionTime.Enabled = False
                        csvTextBox.Text = "Phase 2 ended at 1920-sec" + ","
                    End If
                End If
            End If
        End If
        '-------------------------------------------------------------------------------------------------------------------------------------------------------------------------
        'Code for Phase 3
        If phaseNumber.Text = 3 Then
            If phase3Time.Text > 0 Then
                phase3Time.Text = Val(phase3Time.Text) - 1
            End If
            If phase3Time.Text = 0 Then
                'Code for stability criteria across all three levers taken at 2-min intervals beginning at 6-minutes. 
                If TimeLeft.Text = 1320 Then
                    If r1sess9.Text = 0 Then
                        r1sess9.Text = r1sess9.Text + 0.01
                    End If
                    If r1sess10.Text = 0 Then
                        r1sess10.Text = r1sess10.Text + 0.02
                    End If
                    If r1sess11.Text = 0 Then
                        r1sess11.Text = r1sess11.Text + 0.03
                    End If
                    If r2sess9.Text = 0 Then
                        r2sess9.Text = r2sess9.Text + 0.01
                    End If
                    If r2sess10.Text = 0 Then
                        r2sess10.Text = r2sess10.Text + 0.02
                    End If
                    If r2sess11.Text = 0 Then
                        r2sess11.Text = r2sess11.Text + 0.03
                    End If
                    If r3sess9.Text = 0 Then
                        r3sess9.Text = r3sess9.Text + 0.01
                    End If
                    If r3sess10.Text = 0 Then
                        r3sess10.Text = r3sess10.Text + 0.02
                    End If
                    If r3sess11.Text = 0 Then
                        r3sess11.Text = r3sess11.Text + 0.03
                    End If
                    If r4sess9.Text = 0 Then
                        r4sess9.Text = r4sess9.Text + 0.01
                    End If
                    If r4sess10.Text = 0 Then
                        r4sess10.Text = r4sess10.Text + 0.02
                    End If
                    If r4sess11.Text = 0 Then
                        r4sess11.Text = r4sess11.Text + 0.03
                    End If
                    If r5sess9.Text = 0 Then
                        r5sess9.Text = r5sess9.Text + 0.01
                    End If
                    If r5sess10.Text = 0 Then
                        r5sess10.Text = r5sess10.Text + 0.02
                    End If
                    If r5sess11.Text = 0 Then
                        r5sess11.Text = r5sess11.Text + 0.03
                    End If
                    If r6sess9.Text = 0 Then
                        r6sess9.Text = r6sess9.Text + 0.01
                    End If
                    If r6sess10.Text = 0 Then
                        r6sess10.Text = r6sess10.Text + 0.02
                    End If
                    If r6sess11.Text = 0 Then
                        r6sess11.Text = r6sess11.Text + 0.03
                    End If
                    'Target response
                    r121.Text = Val(r1sess11.Text) - Val(r1sess10.Text)
                    r132.Text = Val(r1sess10.Text) - Val(r1sess9.Text)
                    Dim sloper1 As Integer
                    sloper1 = (Val(r121.Text) + Val(r132.Text)) / 2
                    r1321Tot.Text = Val(r1sess9.Text) + Val(r1sess10.Text) + Val(r1sess11.Text)
                    r1321slope.Text = sloper1 / Val(r1321Tot.Text)
                    'Alternative 1 response
                    r221.Text = Val(r2sess11.Text) - Val(r2sess10.Text)
                    r232.Text = Val(r2sess10.Text) - Val(r2sess9.Text)
                    Dim sloper2 As Integer
                    sloper2 = (Val(r221.Text) + Val(r232.Text)) / 2
                    r2321Tot.Text = Val(r2sess9.Text) + Val(r2sess10.Text) + Val(r2sess11.Text)
                    r2321slope.Text = sloper2 / Val(r2321Tot.Text)
                    'Alternative 2 response
                    r421.Text = Val(r4sess11.Text) - Val(r4sess10.Text)
                    r432.Text = Val(r4sess10.Text) - Val(r4sess9.Text)
                    Dim sloper4 As Integer
                    sloper4 = (Val(r421.Text) + Val(r432.Text)) / 2
                    r4321Tot.Text = Val(r4sess9.Text) + Val(r4sess10.Text) + Val(r4sess11.Text)
                    r4321slope.Text = sloper4 / Val(r4321Tot.Text)
                    'Alternative 3 response
                    r521.Text = Val(r5sess11.Text) - Val(r5sess10.Text)
                    r532.Text = Val(r5sess10.Text) - Val(r5sess9.Text)
                    Dim sloper5 As Integer
                    sloper5 = (Val(r521.Text) + Val(r532.Text)) / 2
                    r5321Tot.Text = Val(r5sess9.Text) + Val(r5sess10.Text) + Val(r5sess11.Text)
                    r5321slope.Text = sloper5 / Val(r5321Tot.Text)
                    'Alternative 4 response
                    r621.Text = Val(r6sess11.Text) - Val(r6sess10.Text)
                    r632.Text = Val(r6sess10.Text) - Val(r6sess9.Text)
                    Dim sloper6 As Integer
                    sloper6 = (Val(r621.Text) + Val(r632.Text)) / 2
                    r6321Tot.Text = Val(r6sess9.Text) + Val(r6sess10.Text) + Val(r6sess11.Text)
                    r6321slope.Text = sloper6 / Val(r6321Tot.Text)
                    'Inactive control
                    r321.Text = Val(r3sess11.Text) - Val(r3sess10.Text)
                    r332.Text = Val(r3sess10.Text) - Val(r3sess9.Text)
                    Dim sloper3 As Integer
                    sloper3 = (Val(r321.Text) + Val(r332.Text)) / 2
                    r3321Tot.Text = Val(r3sess9.Text) + Val(r3sess10.Text) + Val(r3sess11.Text)
                    r3321slope.Text = sloper3 / Val(r3321Tot.Text)
                    'Code for stability determination. 
                    If r121.Text <= 6 Then
                        If r121.Text >= -6 Then
                            If r132.Text <= 6 Then
                                If r132.Text >= -6 Then
                                    If r221.Text <= 6 Then
                                        If r221.Text >= -6 Then
                                            If r232.Text <= 6 Then
                                                If r232.Text >= -6 Then
                                                    If r321.Text <= 6 Then
                                                        If r321.Text >= -6 Then
                                                            If r332.Text <= 6 Then
                                                                If r332.Text >= -6 Then
                                                                    If r421.Text <= 6 Then
                                                                        If r421.Text >= -6 Then
                                                                            If r432.Text <= 6 Then
                                                                                If r432.Text >= -6 Then
                                                                                    If r521.Text <= 6 Then
                                                                                        If r521.Text >= -6 Then
                                                                                            If r532.Text <= 6 Then
                                                                                                If r532.Text >= -6 Then
                                                                                                    If r621.Text <= 6 Then
                                                                                                        If r621.Text >= -6 Then
                                                                                                            If r632.Text <= 6 Then
                                                                                                                If r632.Text >= -6 Then
                                                                                                                    If r1321slope.Text >= -0.1 Then
                                                                                                                        If r1321slope.Text <= 0.1 Then
                                                                                                                            If r2321slope.Text >= -0.1 Then
                                                                                                                                If r2321slope.Text <= 0.1 Then
                                                                                                                                    If r3321slope.Text >= -0.1 Then
                                                                                                                                        If r3321slope.Text <= 0.1 Then
                                                                                                                                            If r4321slope.Text >= -0.1 Then
                                                                                                                                                If r4321slope.Text <= 0.1 Then
                                                                                                                                                    If r5321slope.Text >= -0.1 Then
                                                                                                                                                        If r5321slope.Text <= 0.1 Then
                                                                                                                                                            If r6321slope.Text >= -0.1 Then
                                                                                                                                                                If r6321slope.Text <= 0.1 Then
                                                                                                                                                                    If phaseNumber.Text = 3 Then
                                                                                                                                                                        SessionTime.Enabled = False
                                                                                                                                                                        sessionEnd.Visible = True
                                                                                                                                                                        debriefLoad.Visible = True
                                                                                                                                                                        csvTextBox.Text = csvTextBox.Text + "Phase 3 ended at 1320-sec" + ","
                                                                                                                                                                    End If
                                                                                                                                                                End If
                                                                                                                                                            End If
                                                                                                                                                        End If
                                                                                                                                                    End If
                                                                                                                                                End If
                                                                                                                                            End If
                                                                                                                                        End If
                                                                                                                                    End If
                                                                                                                                End If
                                                                                                                            End If
                                                                                                                        End If
                                                                                                                    End If
                                                                                                                End If
                                                                                                            End If
                                                                                                        End If
                                                                                                    End If
                                                                                                End If
                                                                                            End If
                                                                                        End If
                                                                                    End If
                                                                                End If
                                                                            End If
                                                                        End If
                                                                    End If
                                                                End If
                                                            End If
                                                        End If
                                                    End If
                                                End If
                                            End If
                                        End If
                                    End If
                                End If
                            End If
                        End If
                    End If
                End If
                If TimeLeft.Text = 1440 Then
                    If r1sess10.Text = 0 Then
                        r1sess10.Text = r1sess10.Text + 0.01
                    End If
                    If r1sess11.Text = 0 Then
                        r1sess11.Text = r1sess11.Text + 0.02
                    End If
                    If r1sess12.Text = 0 Then
                        r1sess12.Text = r1sess12.Text + 0.03
                    End If
                    If r2sess10.Text = 0 Then
                        r2sess10.Text = r2sess10.Text + 0.01
                    End If
                    If r2sess11.Text = 0 Then
                        r2sess11.Text = r2sess11.Text + 0.02
                    End If
                    If r2sess12.Text = 0 Then
                        r2sess12.Text = r2sess12.Text + 0.03
                    End If
                    If r3sess10.Text = 0 Then
                        r3sess10.Text = r3sess10.Text + 0.01
                    End If
                    If r3sess11.Text = 0 Then
                        r3sess11.Text = r3sess11.Text + 0.02
                    End If
                    If r3sess12.Text = 0 Then
                        r3sess12.Text = r3sess12.Text + 0.03
                    End If
                    If r4sess10.Text = 0 Then
                        r4sess10.Text = r4sess10.Text + 0.01
                    End If
                    If r4sess11.Text = 0 Then
                        r4sess11.Text = r4sess11.Text + 0.02
                    End If
                    If r4sess12.Text = 0 Then
                        r4sess12.Text = r4sess12.Text + 0.03
                    End If
                    If r5sess10.Text = 0 Then
                        r5sess10.Text = r5sess10.Text + 0.01
                    End If
                    If r5sess11.Text = 0 Then
                        r5sess11.Text = r5sess11.Text + 0.02
                    End If
                    If r5sess12.Text = 0 Then
                        r5sess12.Text = r5sess12.Text + 0.03
                    End If
                    If r6sess10.Text = 0 Then
                        r6sess10.Text = r6sess10.Text + 0.01
                    End If
                    If r6sess11.Text = 0 Then
                        r6sess11.Text = r6sess11.Text + 0.02
                    End If
                    If r6sess12.Text = 0 Then
                        r6sess12.Text = r6sess12.Text + 0.03
                    End If
                    'Target response
                    r121.Text = Val(r1sess12.Text) - Val(r1sess11.Text)
                    r132.Text = Val(r1sess11.Text) - Val(r1sess10.Text)
                    Dim sloper1 As Integer
                    sloper1 = (Val(r121.Text) + Val(r132.Text)) / 2
                    r1321Tot.Text = Val(r1sess10.Text) + Val(r1sess11.Text) + Val(r1sess12.Text)
                    r1321slope.Text = sloper1 / Val(r1321Tot.Text)
                    'Alternative 1 response
                    r221.Text = Val(r2sess12.Text) - Val(r2sess11.Text)
                    r232.Text = Val(r2sess11.Text) - Val(r2sess10.Text)
                    Dim sloper2 As Integer
                    sloper2 = (Val(r221.Text) + Val(r232.Text)) / 2
                    r2321Tot.Text = Val(r2sess10.Text) + Val(r2sess11.Text) + Val(r2sess12.Text)
                    r2321slope.Text = sloper2 / Val(r2321Tot.Text)
                    'Alternative 2 response
                    r421.Text = Val(r4sess12.Text) - Val(r4sess11.Text)
                    r432.Text = Val(r4sess11.Text) - Val(r4sess10.Text)
                    Dim sloper4 As Integer
                    sloper4 = (Val(r421.Text) + Val(r432.Text)) / 2
                    r4321Tot.Text = Val(r4sess10.Text) + Val(r4sess11.Text) + Val(r4sess12.Text)
                    r4321slope.Text = sloper4 / Val(r4321Tot.Text)
                    'Alternative 3 response
                    r521.Text = Val(r5sess12.Text) - Val(r5sess11.Text)
                    r532.Text = Val(r5sess11.Text) - Val(r5sess10.Text)
                    Dim sloper5 As Integer
                    sloper5 = (Val(r521.Text) + Val(r532.Text)) / 2
                    r5321Tot.Text = Val(r5sess10.Text) + Val(r5sess11.Text) + Val(r5sess12.Text)
                    r5321slope.Text = sloper5 / Val(r5321Tot.Text)
                    'Alternative 4 response
                    r621.Text = Val(r6sess12.Text) - Val(r6sess11.Text)
                    r632.Text = Val(r6sess11.Text) - Val(r6sess10.Text)
                    Dim sloper6 As Integer
                    sloper6 = (Val(r621.Text) + Val(r632.Text)) / 2
                    r6321Tot.Text = Val(r6sess10.Text) + Val(r6sess11.Text) + Val(r6sess12.Text)
                    r6321slope.Text = sloper6 / Val(r6321Tot.Text)
                    'Inactive control
                    r321.Text = Val(r3sess12.Text) - Val(r3sess11.Text)
                    r332.Text = Val(r3sess11.Text) - Val(r3sess10.Text)
                    Dim sloper3 As Integer
                    sloper3 = (Val(r321.Text) + Val(r332.Text)) / 2
                    r3321Tot.Text = Val(r3sess10.Text) + Val(r3sess11.Text) + Val(r3sess12.Text)
                    r3321slope.Text = sloper3 / Val(r3321Tot.Text)
                    'Code for stability determination. 
                    If r121.Text <= 6 Then
                        If r121.Text >= -6 Then
                            If r132.Text <= 6 Then
                                If r132.Text >= -6 Then
                                    If r221.Text <= 6 Then
                                        If r221.Text >= -6 Then
                                            If r232.Text <= 6 Then
                                                If r232.Text >= -6 Then
                                                    If r321.Text <= 6 Then
                                                        If r321.Text >= -6 Then
                                                            If r332.Text <= 6 Then
                                                                If r332.Text >= -6 Then
                                                                    If r421.Text <= 6 Then
                                                                        If r421.Text >= -6 Then
                                                                            If r432.Text <= 6 Then
                                                                                If r432.Text >= -6 Then
                                                                                    If r521.Text <= 6 Then
                                                                                        If r521.Text >= -6 Then
                                                                                            If r532.Text <= 6 Then
                                                                                                If r532.Text >= -6 Then
                                                                                                    If r621.Text <= 6 Then
                                                                                                        If r621.Text >= -6 Then
                                                                                                            If r632.Text <= 6 Then
                                                                                                                If r632.Text >= -6 Then
                                                                                                                    If r1321slope.Text >= -0.1 Then
                                                                                                                        If r1321slope.Text <= 0.1 Then
                                                                                                                            If r2321slope.Text >= -0.1 Then
                                                                                                                                If r2321slope.Text <= 0.1 Then
                                                                                                                                    If r3321slope.Text >= -0.1 Then
                                                                                                                                        If r3321slope.Text <= 0.1 Then
                                                                                                                                            If r4321slope.Text >= -0.1 Then
                                                                                                                                                If r4321slope.Text <= 0.1 Then
                                                                                                                                                    If r5321slope.Text >= -0.1 Then
                                                                                                                                                        If r5321slope.Text <= 0.1 Then
                                                                                                                                                            If r6321slope.Text >= -0.1 Then
                                                                                                                                                                If r6321slope.Text <= 0.1 Then
                                                                                                                                                                    If phaseNumber.Text = 3 Then
                                                                                                                                                                        SessionTime.Enabled = False
                                                                                                                                                                        sessionEnd.Visible = True
                                                                                                                                                                        debriefLoad.Visible = True
                                                                                                                                                                        csvTextBox.Text = csvTextBox.Text + "Phase 3 ended at 1440-sec" + ","
                                                                                                                                                                    End If
                                                                                                                                                                End If
                                                                                                                                                            End If
                                                                                                                                                        End If
                                                                                                                                                    End If
                                                                                                                                                End If
                                                                                                                                            End If
                                                                                                                                        End If
                                                                                                                                    End If
                                                                                                                                End If
                                                                                                                            End If
                                                                                                                        End If
                                                                                                                    End If
                                                                                                                End If
                                                                                                            End If
                                                                                                        End If
                                                                                                    End If
                                                                                                End If
                                                                                            End If
                                                                                        End If
                                                                                    End If
                                                                                End If
                                                                            End If
                                                                        End If
                                                                    End If
                                                                End If
                                                            End If
                                                        End If
                                                    End If
                                                End If
                                            End If
                                        End If
                                    End If
                                End If
                            End If
                        End If
                    End If
                End If
                If TimeLeft.Text = 1560 Then
                    If r1sess11.Text = 0 Then
                        r1sess11.Text = r1sess11.Text + 0.01
                    End If
                    If r1sess12.Text = 0 Then
                        r1sess12.Text = r1sess12.Text + 0.02
                    End If
                    If r1sess13.Text = 0 Then
                        r1sess13.Text = r1sess13.Text + 0.03
                    End If
                    If r2sess11.Text = 0 Then
                        r2sess11.Text = r2sess11.Text + 0.01
                    End If
                    If r2sess12.Text = 0 Then
                        r2sess12.Text = r2sess12.Text + 0.02
                    End If
                    If r2sess13.Text = 0 Then
                        r2sess13.Text = r2sess13.Text + 0.03
                    End If
                    If r3sess11.Text = 0 Then
                        r3sess11.Text = r3sess11.Text + 0.01
                    End If
                    If r3sess12.Text = 0 Then
                        r3sess12.Text = r3sess12.Text + 0.02
                    End If
                    If r3sess13.Text = 0 Then
                        r3sess13.Text = r3sess13.Text + 0.03
                    End If
                    If r4sess11.Text = 0 Then
                        r4sess11.Text = r4sess11.Text + 0.01
                    End If
                    If r4sess12.Text = 0 Then
                        r4sess12.Text = r4sess12.Text + 0.02
                    End If
                    If r4sess13.Text = 0 Then
                        r4sess13.Text = r4sess13.Text + 0.03
                    End If
                    If r5sess11.Text = 0 Then
                        r5sess11.Text = r5sess11.Text + 0.01
                    End If
                    If r5sess12.Text = 0 Then
                        r5sess12.Text = r5sess12.Text + 0.02
                    End If
                    If r5sess13.Text = 0 Then
                        r5sess13.Text = r5sess13.Text + 0.03
                    End If
                    If r6sess11.Text = 0 Then
                        r6sess11.Text = r6sess11.Text + 0.01
                    End If
                    If r6sess12.Text = 0 Then
                        r6sess12.Text = r6sess12.Text + 0.02
                    End If
                    If r6sess13.Text = 0 Then
                        r6sess13.Text = r6sess13.Text + 0.03
                    End If
                    'Target response
                    r121.Text = Val(r1sess13.Text) - Val(r1sess12.Text)
                    r132.Text = Val(r1sess12.Text) - Val(r1sess11.Text)
                    Dim sloper1 As Integer
                    sloper1 = (Val(r121.Text) + Val(r132.Text)) / 2
                    r1321Tot.Text = Val(r1sess11.Text) + Val(r1sess12.Text) + Val(r1sess13.Text)
                    r1321slope.Text = sloper1 / Val(r1321Tot.Text)
                    'Alternative 1 response
                    r221.Text = Val(r2sess13.Text) - Val(r2sess12.Text)
                    r232.Text = Val(r2sess12.Text) - Val(r2sess11.Text)
                    Dim sloper2 As Integer
                    sloper2 = (Val(r221.Text) + Val(r232.Text)) / 2
                    r2321Tot.Text = Val(r2sess11.Text) + Val(r2sess12.Text) + Val(r2sess13.Text)
                    r2321slope.Text = sloper2 / Val(r2321Tot.Text)
                    'Alternative 2 response
                    r421.Text = Val(r4sess13.Text) - Val(r4sess12.Text)
                    r432.Text = Val(r4sess12.Text) - Val(r4sess11.Text)
                    Dim sloper4 As Integer
                    sloper4 = (Val(r421.Text) + Val(r432.Text)) / 2
                    r4321Tot.Text = Val(r4sess11.Text) + Val(r4sess12.Text) + Val(r4sess13.Text)
                    r4321slope.Text = sloper4 / Val(r4321Tot.Text)
                    'Alternative 3 response
                    r521.Text = Val(r5sess13.Text) - Val(r5sess12.Text)
                    r532.Text = Val(r5sess12.Text) - Val(r5sess11.Text)
                    Dim sloper5 As Integer
                    sloper5 = (Val(r521.Text) + Val(r532.Text)) / 2
                    r5321Tot.Text = Val(r5sess11.Text) + Val(r5sess12.Text) + Val(r5sess13.Text)
                    r5321slope.Text = sloper5 / Val(r5321Tot.Text)
                    'Alternative 4 response
                    r621.Text = Val(r6sess13.Text) - Val(r6sess12.Text)
                    r632.Text = Val(r6sess12.Text) - Val(r6sess11.Text)
                    Dim sloper6 As Integer
                    sloper6 = (Val(r621.Text) + Val(r632.Text)) / 2
                    r6321Tot.Text = Val(r6sess11.Text) + Val(r6sess12.Text) + Val(r6sess13.Text)
                    r6321slope.Text = sloper6 / Val(r6321Tot.Text)
                    'Inactive control
                    r321.Text = Val(r3sess13.Text) - Val(r3sess12.Text)
                    r332.Text = Val(r3sess12.Text) - Val(r3sess11.Text)
                    Dim sloper3 As Integer
                    sloper3 = (Val(r321.Text) + Val(r332.Text)) / 2
                    r3321Tot.Text = Val(r3sess11.Text) + Val(r3sess12.Text) + Val(r3sess13.Text)
                    r3321slope.Text = sloper3 / Val(r3321Tot.Text)
                    'Code for stability determination. 
                    If r121.Text <= 6 Then
                        If r121.Text >= -6 Then
                            If r132.Text <= 6 Then
                                If r132.Text >= -6 Then
                                    If r221.Text <= 6 Then
                                        If r221.Text >= -6 Then
                                            If r232.Text <= 6 Then
                                                If r232.Text >= -6 Then
                                                    If r321.Text <= 6 Then
                                                        If r321.Text >= -6 Then
                                                            If r332.Text <= 6 Then
                                                                If r332.Text >= -6 Then
                                                                    If r421.Text <= 6 Then
                                                                        If r421.Text >= -6 Then
                                                                            If r432.Text <= 6 Then
                                                                                If r432.Text >= -6 Then
                                                                                    If r521.Text <= 6 Then
                                                                                        If r521.Text >= -6 Then
                                                                                            If r532.Text <= 6 Then
                                                                                                If r532.Text >= -6 Then
                                                                                                    If r621.Text <= 6 Then
                                                                                                        If r621.Text >= -6 Then
                                                                                                            If r632.Text <= 6 Then
                                                                                                                If r632.Text >= -6 Then
                                                                                                                    If r1321slope.Text >= -0.1 Then
                                                                                                                        If r1321slope.Text <= 0.1 Then
                                                                                                                            If r2321slope.Text >= -0.1 Then
                                                                                                                                If r2321slope.Text <= 0.1 Then
                                                                                                                                    If r3321slope.Text >= -0.1 Then
                                                                                                                                        If r3321slope.Text <= 0.1 Then
                                                                                                                                            If r4321slope.Text >= -0.1 Then
                                                                                                                                                If r4321slope.Text <= 0.1 Then
                                                                                                                                                    If r5321slope.Text >= -0.1 Then
                                                                                                                                                        If r5321slope.Text <= 0.1 Then
                                                                                                                                                            If r6321slope.Text >= -0.1 Then
                                                                                                                                                                If r6321slope.Text <= 0.1 Then
                                                                                                                                                                    If phaseNumber.Text = 3 Then
                                                                                                                                                                        SessionTime.Enabled = False
                                                                                                                                                                        sessionEnd.Visible = True
                                                                                                                                                                        debriefLoad.Visible = True
                                                                                                                                                                        csvTextBox.Text = csvTextBox.Text + "Phase 3 ended at 1560-sec" + ","
                                                                                                                                                                    End If
                                                                                                                                                                End If
                                                                                                                                                            End If
                                                                                                                                                        End If
                                                                                                                                                    End If
                                                                                                                                                End If
                                                                                                                                            End If
                                                                                                                                        End If
                                                                                                                                    End If
                                                                                                                                End If
                                                                                                                            End If
                                                                                                                        End If
                                                                                                                    End If
                                                                                                                End If
                                                                                                            End If
                                                                                                        End If
                                                                                                    End If
                                                                                                End If
                                                                                            End If
                                                                                        End If
                                                                                    End If
                                                                                End If
                                                                            End If
                                                                        End If
                                                                    End If
                                                                End If
                                                            End If
                                                        End If
                                                    End If
                                                End If
                                            End If
                                        End If
                                    End If
                                End If
                            End If
                        End If
                    End If
                End If
                If TimeLeft.Text = 1680 Then
                    If r1sess12.Text = 0 Then
                        r1sess12.Text = r1sess12.Text + 0.01
                    End If
                    If r1sess13.Text = 0 Then
                        r1sess13.Text = r1sess13.Text + 0.02
                    End If
                    If r1sess14.Text = 0 Then
                        r1sess14.Text = r1sess14.Text + 0.03
                    End If
                    If r2sess12.Text = 0 Then
                        r2sess12.Text = r2sess12.Text + 0.01
                    End If
                    If r2sess13.Text = 0 Then
                        r2sess13.Text = r2sess13.Text + 0.02
                    End If
                    If r2sess14.Text = 0 Then
                        r2sess14.Text = r2sess14.Text + 0.03
                    End If
                    If r3sess12.Text = 0 Then
                        r3sess12.Text = r3sess12.Text + 0.01
                    End If
                    If r3sess13.Text = 0 Then
                        r3sess13.Text = r3sess13.Text + 0.02
                    End If
                    If r3sess14.Text = 0 Then
                        r3sess14.Text = r3sess14.Text + 0.03
                    End If
                    If r4sess12.Text = 0 Then
                        r4sess12.Text = r4sess12.Text + 0.01
                    End If
                    If r4sess13.Text = 0 Then
                        r4sess13.Text = r4sess13.Text + 0.02
                    End If
                    If r4sess14.Text = 0 Then
                        r4sess14.Text = r4sess14.Text + 0.03
                    End If
                    If r5sess12.Text = 0 Then
                        r5sess12.Text = r5sess12.Text + 0.01
                    End If
                    If r5sess13.Text = 0 Then
                        r5sess13.Text = r5sess13.Text + 0.02
                    End If
                    If r5sess14.Text = 0 Then
                        r5sess14.Text = r5sess14.Text + 0.03
                    End If
                    If r6sess12.Text = 0 Then
                        r6sess12.Text = r6sess12.Text + 0.01
                    End If
                    If r6sess13.Text = 0 Then
                        r6sess13.Text = r6sess13.Text + 0.02
                    End If
                    If r6sess14.Text = 0 Then
                        r6sess14.Text = r6sess14.Text + 0.03
                    End If
                    'Target response
                    r121.Text = Val(r1sess14.Text) - Val(r1sess13.Text)
                    r132.Text = Val(r1sess13.Text) - Val(r1sess12.Text)
                    Dim sloper1 As Integer
                    sloper1 = (Val(r121.Text) + Val(r132.Text)) / 2
                    r1321Tot.Text = Val(r1sess12.Text) + Val(r1sess13.Text) + Val(r1sess14.Text)
                    r1321slope.Text = sloper1 / Val(r1321Tot.Text)
                    'Alternative 1 response
                    r221.Text = Val(r2sess14.Text) - Val(r2sess13.Text)
                    r232.Text = Val(r2sess13.Text) - Val(r2sess12.Text)
                    Dim sloper2 As Integer
                    sloper2 = (Val(r221.Text) + Val(r232.Text)) / 2
                    r2321Tot.Text = Val(r2sess12.Text) + Val(r2sess13.Text) + Val(r2sess14.Text)
                    r2321slope.Text = sloper2 / Val(r2321Tot.Text)
                    'Alternative 2 response
                    r421.Text = Val(r4sess14.Text) - Val(r4sess13.Text)
                    r432.Text = Val(r4sess13.Text) - Val(r4sess12.Text)
                    Dim sloper4 As Integer
                    sloper4 = (Val(r421.Text) + Val(r432.Text)) / 2
                    r4321Tot.Text = Val(r4sess12.Text) + Val(r4sess13.Text) + Val(r4sess14.Text)
                    r4321slope.Text = sloper4 / Val(r4321Tot.Text)
                    'Alternative 3 response
                    r521.Text = Val(r5sess14.Text) - Val(r5sess13.Text)
                    r532.Text = Val(r5sess13.Text) - Val(r5sess12.Text)
                    Dim sloper5 As Integer
                    sloper5 = (Val(r521.Text) + Val(r532.Text)) / 2
                    r5321Tot.Text = Val(r5sess12.Text) + Val(r5sess13.Text) + Val(r5sess14.Text)
                    r5321slope.Text = sloper5 / Val(r5321Tot.Text)
                    'Alternative 4 response
                    r621.Text = Val(r6sess14.Text) - Val(r6sess13.Text)
                    r632.Text = Val(r6sess13.Text) - Val(r6sess12.Text)
                    Dim sloper6 As Integer
                    sloper6 = (Val(r621.Text) + Val(r632.Text)) / 2
                    r6321Tot.Text = Val(r6sess12.Text) + Val(r6sess13.Text) + Val(r6sess14.Text)
                    r6321slope.Text = sloper6 / Val(r6321Tot.Text)
                    'Inactive control
                    r321.Text = Val(r3sess14.Text) - Val(r3sess13.Text)
                    r332.Text = Val(r3sess13.Text) - Val(r3sess12.Text)
                    Dim sloper3 As Integer
                    sloper3 = (Val(r321.Text) + Val(r332.Text)) / 2
                    r3321Tot.Text = Val(r3sess12.Text) + Val(r3sess13.Text) + Val(r3sess14.Text)
                    r3321slope.Text = sloper3 / Val(r3321Tot.Text)
                    'Code for stability determination. 
                    If r121.Text <= 6 Then
                        If r121.Text >= -6 Then
                            If r132.Text <= 6 Then
                                If r132.Text >= -6 Then
                                    If r221.Text <= 6 Then
                                        If r221.Text >= -6 Then
                                            If r232.Text <= 6 Then
                                                If r232.Text >= -6 Then
                                                    If r321.Text <= 6 Then
                                                        If r321.Text >= -6 Then
                                                            If r332.Text <= 6 Then
                                                                If r332.Text >= -6 Then
                                                                    If r421.Text <= 6 Then
                                                                        If r421.Text >= -6 Then
                                                                            If r432.Text <= 6 Then
                                                                                If r432.Text >= -6 Then
                                                                                    If r521.Text <= 6 Then
                                                                                        If r521.Text >= -6 Then
                                                                                            If r532.Text <= 6 Then
                                                                                                If r532.Text >= -6 Then
                                                                                                    If r621.Text <= 6 Then
                                                                                                        If r621.Text >= -6 Then
                                                                                                            If r632.Text <= 6 Then
                                                                                                                If r632.Text >= -6 Then
                                                                                                                    If r1321slope.Text >= -0.1 Then
                                                                                                                        If r1321slope.Text <= 0.1 Then
                                                                                                                            If r2321slope.Text >= -0.1 Then
                                                                                                                                If r2321slope.Text <= 0.1 Then
                                                                                                                                    If r3321slope.Text >= -0.1 Then
                                                                                                                                        If r3321slope.Text <= 0.1 Then
                                                                                                                                            If r4321slope.Text >= -0.1 Then
                                                                                                                                                If r4321slope.Text <= 0.1 Then
                                                                                                                                                    If r5321slope.Text >= -0.1 Then
                                                                                                                                                        If r5321slope.Text <= 0.1 Then
                                                                                                                                                            If r6321slope.Text >= -0.1 Then
                                                                                                                                                                If r6321slope.Text <= 0.1 Then
                                                                                                                                                                    If phaseNumber.Text = 3 Then
                                                                                                                                                                        SessionTime.Enabled = False
                                                                                                                                                                        sessionEnd.Visible = True
                                                                                                                                                                        debriefLoad.Visible = True
                                                                                                                                                                        csvTextBox.Text = csvTextBox.Text + "Phase 3 ended at 1680-sec" + ","
                                                                                                                                                                    End If
                                                                                                                                                                End If
                                                                                                                                                            End If
                                                                                                                                                        End If
                                                                                                                                                    End If
                                                                                                                                                End If
                                                                                                                                            End If
                                                                                                                                        End If
                                                                                                                                    End If
                                                                                                                                End If
                                                                                                                            End If
                                                                                                                        End If
                                                                                                                    End If
                                                                                                                End If
                                                                                                            End If
                                                                                                        End If
                                                                                                    End If
                                                                                                End If
                                                                                            End If
                                                                                        End If
                                                                                    End If
                                                                                End If
                                                                            End If
                                                                        End If
                                                                    End If
                                                                End If
                                                            End If
                                                        End If
                                                    End If
                                                End If
                                            End If
                                        End If
                                    End If
                                End If
                            End If
                        End If
                    End If
                End If
                If TimeLeft.Text = 1800 Then
                    If r1sess13.Text = 0 Then
                        r1sess13.Text = r1sess13.Text + 0.01
                    End If
                    If r1sess14.Text = 0 Then
                        r1sess14.Text = r1sess14.Text + 0.02
                    End If
                    If r1sess15.Text = 0 Then
                        r1sess15.Text = r1sess15.Text + 0.03
                    End If
                    If r2sess13.Text = 0 Then
                        r2sess13.Text = r2sess13.Text + 0.01
                    End If
                    If r2sess14.Text = 0 Then
                        r2sess14.Text = r2sess14.Text + 0.02
                    End If
                    If r2sess15.Text = 0 Then
                        r2sess15.Text = r2sess15.Text + 0.03
                    End If
                    If r3sess13.Text = 0 Then
                        r3sess13.Text = r3sess13.Text + 0.01
                    End If
                    If r3sess14.Text = 0 Then
                        r3sess14.Text = r3sess14.Text + 0.02
                    End If
                    If r3sess15.Text = 0 Then
                        r3sess15.Text = r3sess15.Text + 0.03
                    End If
                    If r4sess13.Text = 0 Then
                        r4sess13.Text = r4sess13.Text + 0.01
                    End If
                    If r4sess14.Text = 0 Then
                        r4sess14.Text = r4sess14.Text + 0.02
                    End If
                    If r4sess15.Text = 0 Then
                        r4sess15.Text = r4sess15.Text + 0.03
                    End If
                    If r5sess13.Text = 0 Then
                        r5sess13.Text = r5sess13.Text + 0.01
                    End If
                    If r5sess14.Text = 0 Then
                        r5sess14.Text = r5sess14.Text + 0.02
                    End If
                    If r5sess15.Text = 0 Then
                        r5sess15.Text = r5sess15.Text + 0.03
                    End If
                    If r6sess13.Text = 0 Then
                        r6sess13.Text = r6sess13.Text + 0.01
                    End If
                    If r6sess14.Text = 0 Then
                        r6sess14.Text = r6sess14.Text + 0.02
                    End If
                    If r6sess15.Text = 0 Then
                        r6sess15.Text = r6sess15.Text + 0.03
                    End If
                    'Target response
                    r121.Text = Val(r1sess15.Text) - Val(r1sess14.Text)
                    r132.Text = Val(r1sess14.Text) - Val(r1sess13.Text)
                    Dim sloper1 As Integer
                    sloper1 = (Val(r121.Text) + Val(r132.Text)) / 2
                    r1321Tot.Text = Val(r1sess13.Text) + Val(r1sess14.Text) + Val(r1sess15.Text)
                    r1321slope.Text = sloper1 / Val(r1321Tot.Text)
                    'Alternative 1 response
                    r221.Text = Val(r2sess15.Text) - Val(r2sess14.Text)
                    r232.Text = Val(r2sess14.Text) - Val(r2sess13.Text)
                    Dim sloper2 As Integer
                    sloper2 = (Val(r221.Text) + Val(r232.Text)) / 2
                    r2321Tot.Text = Val(r2sess13.Text) + Val(r2sess14.Text) + Val(r2sess15.Text)
                    r2321slope.Text = sloper2 / Val(r2321Tot.Text)
                    'Alternative 2 response
                    r421.Text = Val(r4sess15.Text) - Val(r4sess14.Text)
                    r432.Text = Val(r4sess14.Text) - Val(r4sess13.Text)
                    Dim sloper4 As Integer
                    sloper4 = (Val(r421.Text) + Val(r432.Text)) / 2
                    r4321Tot.Text = Val(r4sess13.Text) + Val(r4sess14.Text) + Val(r4sess15.Text)
                    r4321slope.Text = sloper4 / Val(r4321Tot.Text)
                    'Alternative 3 response
                    r521.Text = Val(r5sess15.Text) - Val(r5sess14.Text)
                    r532.Text = Val(r5sess14.Text) - Val(r5sess13.Text)
                    Dim sloper5 As Integer
                    sloper5 = (Val(r521.Text) + Val(r532.Text)) / 2
                    r5321Tot.Text = Val(r5sess13.Text) + Val(r5sess14.Text) + Val(r5sess15.Text)
                    r5321slope.Text = sloper5 / Val(r5321Tot.Text)
                    'Alternative 4 response
                    r621.Text = Val(r6sess15.Text) - Val(r6sess14.Text)
                    r632.Text = Val(r6sess14.Text) - Val(r6sess13.Text)
                    Dim sloper6 As Integer
                    sloper6 = (Val(r621.Text) + Val(r632.Text)) / 2
                    r6321Tot.Text = Val(r6sess13.Text) + Val(r6sess14.Text) + Val(r6sess15.Text)
                    r6321slope.Text = sloper6 / Val(r6321Tot.Text)
                    'Inactive control
                    r321.Text = Val(r3sess15.Text) - Val(r3sess14.Text)
                    r332.Text = Val(r3sess14.Text) - Val(r3sess13.Text)
                    Dim sloper3 As Integer
                    sloper3 = (Val(r321.Text) + Val(r332.Text)) / 2
                    r3321Tot.Text = Val(r3sess13.Text) + Val(r3sess14.Text) + Val(r3sess15.Text)
                    r3321slope.Text = sloper3 / Val(r3321Tot.Text)
                    'Code for stability determination. 
                    If r121.Text <= 6 Then
                        If r121.Text >= -6 Then
                            If r132.Text <= 6 Then
                                If r132.Text >= -6 Then
                                    If r221.Text <= 6 Then
                                        If r221.Text >= -6 Then
                                            If r232.Text <= 6 Then
                                                If r232.Text >= -6 Then
                                                    If r321.Text <= 6 Then
                                                        If r321.Text >= -6 Then
                                                            If r332.Text <= 6 Then
                                                                If r332.Text >= -6 Then
                                                                    If r421.Text <= 6 Then
                                                                        If r421.Text >= -6 Then
                                                                            If r432.Text <= 6 Then
                                                                                If r432.Text >= -6 Then
                                                                                    If r521.Text <= 6 Then
                                                                                        If r521.Text >= -6 Then
                                                                                            If r532.Text <= 6 Then
                                                                                                If r532.Text >= -6 Then
                                                                                                    If r621.Text <= 6 Then
                                                                                                        If r621.Text >= -6 Then
                                                                                                            If r632.Text <= 6 Then
                                                                                                                If r632.Text >= -6 Then
                                                                                                                    If r1321slope.Text >= -0.1 Then
                                                                                                                        If r1321slope.Text <= 0.1 Then
                                                                                                                            If r2321slope.Text >= -0.1 Then
                                                                                                                                If r2321slope.Text <= 0.1 Then
                                                                                                                                    If r3321slope.Text >= -0.1 Then
                                                                                                                                        If r3321slope.Text <= 0.1 Then
                                                                                                                                            If r4321slope.Text >= -0.1 Then
                                                                                                                                                If r4321slope.Text <= 0.1 Then
                                                                                                                                                    If r5321slope.Text >= -0.1 Then
                                                                                                                                                        If r5321slope.Text <= 0.1 Then
                                                                                                                                                            If r6321slope.Text >= -0.1 Then
                                                                                                                                                                If r6321slope.Text <= 0.1 Then
                                                                                                                                                                    If phaseNumber.Text = 3 Then
                                                                                                                                                                        SessionTime.Enabled = False
                                                                                                                                                                        sessionEnd.Visible = True
                                                                                                                                                                        debriefLoad.Visible = True
                                                                                                                                                                        csvTextBox.Text = csvTextBox.Text + "Phase 3 ended at 1800-sec" + ","
                                                                                                                                                                    End If
                                                                                                                                                                End If
                                                                                                                                                            End If
                                                                                                                                                        End If
                                                                                                                                                    End If
                                                                                                                                                End If
                                                                                                                                            End If
                                                                                                                                        End If
                                                                                                                                    End If
                                                                                                                                End If
                                                                                                                            End If
                                                                                                                        End If
                                                                                                                    End If
                                                                                                                End If
                                                                                                            End If
                                                                                                        End If
                                                                                                    End If
                                                                                                End If
                                                                                            End If
                                                                                        End If
                                                                                    End If
                                                                                End If
                                                                            End If
                                                                        End If
                                                                    End If
                                                                End If
                                                            End If
                                                        End If
                                                    End If
                                                End If
                                            End If
                                        End If
                                    End If
                                End If
                            End If
                        End If
                    End If
                End If
                If TimeLeft.Text = 1920 Then
                    If r1sess14.Text = 0 Then
                        r1sess14.Text = r1sess14.Text + 0.01
                    End If
                    If r1sess15.Text = 0 Then
                        r1sess15.Text = r1sess15.Text + 0.02
                    End If
                    If r1sess16.Text = 0 Then
                        r1sess16.Text = r1sess16.Text + 0.03
                    End If
                    If r2sess14.Text = 0 Then
                        r2sess14.Text = r2sess14.Text + 0.01
                    End If
                    If r2sess15.Text = 0 Then
                        r2sess15.Text = r2sess15.Text + 0.02
                    End If
                    If r2sess16.Text = 0 Then
                        r2sess16.Text = r2sess16.Text + 0.03
                    End If
                    If r3sess14.Text = 0 Then
                        r3sess14.Text = r3sess14.Text + 0.01
                    End If
                    If r3sess15.Text = 0 Then
                        r3sess15.Text = r3sess15.Text + 0.02
                    End If
                    If r3sess16.Text = 0 Then
                        r3sess16.Text = r3sess16.Text + 0.03
                    End If
                    If r4sess14.Text = 0 Then
                        r4sess14.Text = r4sess14.Text + 0.01
                    End If
                    If r4sess15.Text = 0 Then
                        r4sess15.Text = r4sess15.Text + 0.02
                    End If
                    If r4sess16.Text = 0 Then
                        r4sess16.Text = r4sess16.Text + 0.03
                    End If
                    If r5sess14.Text = 0 Then
                        r5sess14.Text = r5sess14.Text + 0.01
                    End If
                    If r5sess15.Text = 0 Then
                        r5sess15.Text = r5sess15.Text + 0.02
                    End If
                    If r5sess16.Text = 0 Then
                        r5sess16.Text = r5sess16.Text + 0.03
                    End If
                    If r6sess14.Text = 0 Then
                        r6sess14.Text = r6sess14.Text + 0.01
                    End If
                    If r6sess15.Text = 0 Then
                        r6sess15.Text = r6sess15.Text + 0.02
                    End If
                    If r6sess16.Text = 0 Then
                        r6sess16.Text = r6sess16.Text + 0.03
                    End If
                    'Target response
                    r121.Text = Val(r1sess16.Text) - Val(r1sess15.Text)
                    r132.Text = Val(r1sess15.Text) - Val(r1sess14.Text)
                    Dim sloper1 As Integer
                    sloper1 = (Val(r121.Text) + Val(r132.Text)) / 2
                    r1321Tot.Text = Val(r1sess14.Text) + Val(r1sess15.Text) + Val(r1sess16.Text)
                    r1321slope.Text = sloper1 / Val(r1321Tot.Text)
                    'Alternative 1 response
                    r221.Text = Val(r2sess16.Text) - Val(r2sess15.Text)
                    r232.Text = Val(r2sess15.Text) - Val(r2sess14.Text)
                    Dim sloper2 As Integer
                    sloper2 = (Val(r221.Text) + Val(r232.Text)) / 2
                    r2321Tot.Text = Val(r2sess14.Text) + Val(r2sess15.Text) + Val(r2sess16.Text)
                    r2321slope.Text = sloper2 / Val(r2321Tot.Text)
                    'Alternative 2 response
                    r421.Text = Val(r4sess16.Text) - Val(r4sess15.Text)
                    r432.Text = Val(r4sess15.Text) - Val(r4sess14.Text)
                    Dim sloper4 As Integer
                    sloper4 = (Val(r421.Text) + Val(r432.Text)) / 2
                    r4321Tot.Text = Val(r4sess14.Text) + Val(r4sess15.Text) + Val(r4sess16.Text)
                    r4321slope.Text = sloper4 / Val(r4321Tot.Text)
                    'Alternative 3 response
                    r521.Text = Val(r5sess16.Text) - Val(r5sess15.Text)
                    r532.Text = Val(r5sess15.Text) - Val(r5sess14.Text)
                    Dim sloper5 As Integer
                    sloper5 = (Val(r521.Text) + Val(r532.Text)) / 2
                    r5321Tot.Text = Val(r5sess14.Text) + Val(r5sess15.Text) + Val(r5sess16.Text)
                    r5321slope.Text = sloper5 / Val(r5321Tot.Text)
                    'Alternative 4 response
                    r621.Text = Val(r6sess16.Text) - Val(r6sess15.Text)
                    r632.Text = Val(r6sess15.Text) - Val(r6sess14.Text)
                    Dim sloper6 As Integer
                    sloper6 = (Val(r621.Text) + Val(r632.Text)) / 2
                    r6321Tot.Text = Val(r6sess14.Text) + Val(r6sess15.Text) + Val(r6sess16.Text)
                    r6321slope.Text = sloper6 / Val(r6321Tot.Text)
                    'Inactive control
                    r321.Text = Val(r3sess16.Text) - Val(r3sess15.Text)
                    r332.Text = Val(r3sess15.Text) - Val(r3sess14.Text)
                    Dim sloper3 As Integer
                    sloper3 = (Val(r321.Text) + Val(r332.Text)) / 2
                    r3321Tot.Text = Val(r3sess14.Text) + Val(r3sess15.Text) + Val(r3sess16.Text)
                    r3321slope.Text = sloper3 / Val(r3321Tot.Text)
                    'Code for stability determination. 
                    If r121.Text <= 6 Then
                        If r121.Text >= -6 Then
                            If r132.Text <= 6 Then
                                If r132.Text >= -6 Then
                                    If r221.Text <= 6 Then
                                        If r221.Text >= -6 Then
                                            If r232.Text <= 6 Then
                                                If r232.Text >= -6 Then
                                                    If r321.Text <= 6 Then
                                                        If r321.Text >= -6 Then
                                                            If r332.Text <= 6 Then
                                                                If r332.Text >= -6 Then
                                                                    If r421.Text <= 6 Then
                                                                        If r421.Text >= -6 Then
                                                                            If r432.Text <= 6 Then
                                                                                If r432.Text >= -6 Then
                                                                                    If r521.Text <= 6 Then
                                                                                        If r521.Text >= -6 Then
                                                                                            If r532.Text <= 6 Then
                                                                                                If r532.Text >= -6 Then
                                                                                                    If r621.Text <= 6 Then
                                                                                                        If r621.Text >= -6 Then
                                                                                                            If r632.Text <= 6 Then
                                                                                                                If r632.Text >= -6 Then
                                                                                                                    If r1321slope.Text >= -0.1 Then
                                                                                                                        If r1321slope.Text <= 0.1 Then
                                                                                                                            If r2321slope.Text >= -0.1 Then
                                                                                                                                If r2321slope.Text <= 0.1 Then
                                                                                                                                    If r3321slope.Text >= -0.1 Then
                                                                                                                                        If r3321slope.Text <= 0.1 Then
                                                                                                                                            If r4321slope.Text >= -0.1 Then
                                                                                                                                                If r4321slope.Text <= 0.1 Then
                                                                                                                                                    If r5321slope.Text >= -0.1 Then
                                                                                                                                                        If r5321slope.Text <= 0.1 Then
                                                                                                                                                            If r6321slope.Text >= -0.1 Then
                                                                                                                                                                If r6321slope.Text <= 0.1 Then
                                                                                                                                                                    If phaseNumber.Text = 3 Then
                                                                                                                                                                        SessionTime.Enabled = False
                                                                                                                                                                        sessionEnd.Visible = True
                                                                                                                                                                        debriefLoad.Visible = True
                                                                                                                                                                        csvTextBox.Text = csvTextBox.Text + "Phase 3 ended at 1920-sec" + ","
                                                                                                                                                                    End If
                                                                                                                                                                End If
                                                                                                                                                            End If
                                                                                                                                                        End If
                                                                                                                                                    End If
                                                                                                                                                End If
                                                                                                                                            End If
                                                                                                                                        End If
                                                                                                                                    End If
                                                                                                                                End If
                                                                                                                            End If
                                                                                                                        End If
                                                                                                                    End If
                                                                                                                End If
                                                                                                            End If
                                                                                                        End If
                                                                                                    End If
                                                                                                End If
                                                                                            End If
                                                                                        End If
                                                                                    End If
                                                                                End If
                                                                            End If
                                                                        End If
                                                                    End If
                                                                End If
                                                            End If
                                                        End If
                                                    End If
                                                End If
                                            End If
                                        End If
                                    End If
                                End If
                            End If
                        End If
                    End If
                End If
                If TimeLeft.Text = 2040 Then
                    If r1sess15.Text = 0 Then
                        r1sess15.Text = r1sess15.Text + 0.01
                    End If
                    If r1sess16.Text = 0 Then
                        r1sess16.Text = r1sess16.Text + 0.02
                    End If
                    If r1sess17.Text = 0 Then
                        r1sess17.Text = r1sess17.Text + 0.03
                    End If
                    If r2sess15.Text = 0 Then
                        r2sess15.Text = r2sess15.Text + 0.01
                    End If
                    If r2sess16.Text = 0 Then
                        r2sess16.Text = r2sess16.Text + 0.02
                    End If
                    If r2sess17.Text = 0 Then
                        r2sess17.Text = r2sess17.Text + 0.03
                    End If
                    If r3sess15.Text = 0 Then
                        r3sess15.Text = r3sess15.Text + 0.01
                    End If
                    If r3sess16.Text = 0 Then
                        r3sess16.Text = r3sess16.Text + 0.02
                    End If
                    If r3sess17.Text = 0 Then
                        r3sess17.Text = r3sess17.Text + 0.03
                    End If
                    If r4sess15.Text = 0 Then
                        r4sess15.Text = r4sess15.Text + 0.01
                    End If
                    If r4sess16.Text = 0 Then
                        r4sess16.Text = r4sess16.Text + 0.02
                    End If
                    If r4sess17.Text = 0 Then
                        r4sess17.Text = r4sess17.Text + 0.03
                    End If
                    If r5sess15.Text = 0 Then
                        r5sess15.Text = r5sess15.Text + 0.01
                    End If
                    If r5sess16.Text = 0 Then
                        r5sess16.Text = r5sess16.Text + 0.02
                    End If
                    If r5sess17.Text = 0 Then
                        r5sess17.Text = r5sess17.Text + 0.03
                    End If
                    If r6sess15.Text = 0 Then
                        r6sess15.Text = r6sess15.Text + 0.01
                    End If
                    If r6sess16.Text = 0 Then
                        r6sess16.Text = r6sess16.Text + 0.02
                    End If
                    If r6sess17.Text = 0 Then
                        r6sess17.Text = r6sess17.Text + 0.03
                    End If
                    'Target response
                    r121.Text = Val(r1sess17.Text) - Val(r1sess16.Text)
                    r132.Text = Val(r1sess16.Text) - Val(r1sess15.Text)
                    Dim sloper1 As Integer
                    sloper1 = (Val(r121.Text) + Val(r132.Text)) / 2
                    r1321Tot.Text = Val(r1sess15.Text) + Val(r1sess16.Text) + Val(r1sess17.Text)
                    r1321slope.Text = sloper1 / Val(r1321Tot.Text)
                    'Alternative 1 response
                    r221.Text = Val(r2sess17.Text) - Val(r2sess16.Text)
                    r232.Text = Val(r2sess16.Text) - Val(r2sess15.Text)
                    Dim sloper2 As Integer
                    sloper2 = (Val(r221.Text) + Val(r232.Text)) / 2
                    r2321Tot.Text = Val(r2sess15.Text) + Val(r2sess16.Text) + Val(r2sess17.Text)
                    r2321slope.Text = sloper2 / Val(r2321Tot.Text)
                    'Alternative 2 response
                    r421.Text = Val(r4sess17.Text) - Val(r4sess16.Text)
                    r432.Text = Val(r4sess16.Text) - Val(r4sess15.Text)
                    Dim sloper4 As Integer
                    sloper4 = (Val(r421.Text) + Val(r432.Text)) / 2
                    r4321Tot.Text = Val(r4sess15.Text) + Val(r4sess16.Text) + Val(r4sess17.Text)
                    r4321slope.Text = sloper4 / Val(r4321Tot.Text)
                    'Alternative 3 response
                    r521.Text = Val(r5sess17.Text) - Val(r5sess16.Text)
                    r532.Text = Val(r5sess16.Text) - Val(r5sess15.Text)
                    Dim sloper5 As Integer
                    sloper5 = (Val(r521.Text) + Val(r532.Text)) / 2
                    r5321Tot.Text = Val(r5sess15.Text) + Val(r5sess16.Text) + Val(r5sess17.Text)
                    r5321slope.Text = sloper5 / Val(r5321Tot.Text)
                    'Alternative 4 response
                    r621.Text = Val(r6sess17.Text) - Val(r6sess16.Text)
                    r632.Text = Val(r6sess16.Text) - Val(r6sess15.Text)
                    Dim sloper6 As Integer
                    sloper6 = (Val(r621.Text) + Val(r632.Text)) / 2
                    r6321Tot.Text = Val(r6sess15.Text) + Val(r6sess16.Text) + Val(r6sess17.Text)
                    r6321slope.Text = sloper6 / Val(r6321Tot.Text)
                    'Inactive control
                    r321.Text = Val(r3sess17.Text) - Val(r3sess16.Text)
                    r332.Text = Val(r3sess16.Text) - Val(r3sess15.Text)
                    Dim sloper3 As Integer
                    sloper3 = (Val(r321.Text) + Val(r332.Text)) / 2
                    r3321Tot.Text = Val(r3sess15.Text) + Val(r3sess16.Text) + Val(r3sess17.Text)
                    r3321slope.Text = sloper3 / Val(r3321Tot.Text)
                    'Code for stability determination. 
                    If r121.Text <= 6 Then
                        If r121.Text >= -6 Then
                            If r132.Text <= 6 Then
                                If r132.Text >= -6 Then
                                    If r221.Text <= 6 Then
                                        If r221.Text >= -6 Then
                                            If r232.Text <= 6 Then
                                                If r232.Text >= -6 Then
                                                    If r321.Text <= 6 Then
                                                        If r321.Text >= -6 Then
                                                            If r332.Text <= 6 Then
                                                                If r332.Text >= -6 Then
                                                                    If r421.Text <= 6 Then
                                                                        If r421.Text >= -6 Then
                                                                            If r432.Text <= 6 Then
                                                                                If r432.Text >= -6 Then
                                                                                    If r521.Text <= 6 Then
                                                                                        If r521.Text >= -6 Then
                                                                                            If r532.Text <= 6 Then
                                                                                                If r532.Text >= -6 Then
                                                                                                    If r621.Text <= 6 Then
                                                                                                        If r621.Text >= -6 Then
                                                                                                            If r632.Text <= 6 Then
                                                                                                                If r632.Text >= -6 Then
                                                                                                                    If r1321slope.Text >= -0.1 Then
                                                                                                                        If r1321slope.Text <= 0.1 Then
                                                                                                                            If r2321slope.Text >= -0.1 Then
                                                                                                                                If r2321slope.Text <= 0.1 Then
                                                                                                                                    If r3321slope.Text >= -0.1 Then
                                                                                                                                        If r3321slope.Text <= 0.1 Then
                                                                                                                                            If r4321slope.Text >= -0.1 Then
                                                                                                                                                If r4321slope.Text <= 0.1 Then
                                                                                                                                                    If r5321slope.Text >= -0.1 Then
                                                                                                                                                        If r5321slope.Text <= 0.1 Then
                                                                                                                                                            If r6321slope.Text >= -0.1 Then
                                                                                                                                                                If r6321slope.Text <= 0.1 Then
                                                                                                                                                                    If phaseNumber.Text = 3 Then
                                                                                                                                                                        SessionTime.Enabled = False
                                                                                                                                                                        sessionEnd.Visible = True
                                                                                                                                                                        debriefLoad.Visible = True
                                                                                                                                                                        csvTextBox.Text = csvTextBox.Text + "Phase 3 ended at 2040-sec" + ","
                                                                                                                                                                    End If
                                                                                                                                                                End If
                                                                                                                                                            End If
                                                                                                                                                        End If
                                                                                                                                                    End If
                                                                                                                                                End If
                                                                                                                                            End If
                                                                                                                                        End If
                                                                                                                                    End If
                                                                                                                                End If
                                                                                                                            End If
                                                                                                                        End If
                                                                                                                    End If
                                                                                                                End If
                                                                                                            End If
                                                                                                        End If
                                                                                                    End If
                                                                                                End If
                                                                                            End If
                                                                                        End If
                                                                                    End If
                                                                                End If
                                                                            End If
                                                                        End If
                                                                    End If
                                                                End If
                                                            End If
                                                        End If
                                                    End If
                                                End If
                                            End If
                                        End If
                                    End If
                                End If
                            End If
                        End If
                    End If
                End If
                If TimeLeft.Text = 2160 Then
                    If r1sess16.Text = 0 Then
                        r1sess16.Text = r1sess16.Text + 0.01
                    End If
                    If r1sess17.Text = 0 Then
                        r1sess17.Text = r1sess17.Text + 0.02
                    End If
                    If r1sess18.Text = 0 Then
                        r1sess18.Text = r1sess18.Text + 0.03
                    End If
                    If r2sess16.Text = 0 Then
                        r2sess16.Text = r2sess16.Text + 0.01
                    End If
                    If r2sess17.Text = 0 Then
                        r2sess17.Text = r2sess17.Text + 0.02
                    End If
                    If r2sess18.Text = 0 Then
                        r2sess18.Text = r2sess18.Text + 0.03
                    End If
                    If r3sess16.Text = 0 Then
                        r3sess16.Text = r3sess16.Text + 0.01
                    End If
                    If r3sess17.Text = 0 Then
                        r3sess17.Text = r3sess17.Text + 0.02
                    End If
                    If r3sess18.Text = 0 Then
                        r3sess18.Text = r3sess18.Text + 0.03
                    End If
                    If r4sess16.Text = 0 Then
                        r4sess16.Text = r4sess16.Text + 0.01
                    End If
                    If r4sess17.Text = 0 Then
                        r4sess17.Text = r4sess17.Text + 0.02
                    End If
                    If r4sess18.Text = 0 Then
                        r4sess18.Text = r4sess18.Text + 0.03
                    End If
                    If r5sess16.Text = 0 Then
                        r5sess16.Text = r5sess16.Text + 0.01
                    End If
                    If r5sess17.Text = 0 Then
                        r5sess17.Text = r5sess17.Text + 0.02
                    End If
                    If r5sess18.Text = 0 Then
                        r5sess18.Text = r5sess18.Text + 0.03
                    End If
                    If r6sess16.Text = 0 Then
                        r6sess16.Text = r6sess16.Text + 0.01
                    End If
                    If r6sess17.Text = 0 Then
                        r6sess17.Text = r6sess17.Text + 0.02
                    End If
                    If r6sess18.Text = 0 Then
                        r6sess18.Text = r6sess18.Text + 0.03
                    End If
                    'Target response
                    r121.Text = Val(r1sess18.Text) - Val(r1sess17.Text)
                    r132.Text = Val(r1sess17.Text) - Val(r1sess16.Text)
                    Dim sloper1 As Integer
                    sloper1 = (Val(r121.Text) + Val(r132.Text)) / 2
                    r1321Tot.Text = Val(r1sess16.Text) + Val(r1sess17.Text) + Val(r1sess18.Text)
                    r1321slope.Text = sloper1 / Val(r1321Tot.Text)
                    'Alternative 1 response
                    r221.Text = Val(r2sess18.Text) - Val(r2sess17.Text)
                    r232.Text = Val(r2sess17.Text) - Val(r2sess16.Text)
                    Dim sloper2 As Integer
                    sloper2 = (Val(r221.Text) + Val(r232.Text)) / 2
                    r2321Tot.Text = Val(r2sess16.Text) + Val(r2sess17.Text) + Val(r2sess18.Text)
                    r2321slope.Text = sloper2 / Val(r2321Tot.Text)
                    'Alternative 2 response
                    r421.Text = Val(r4sess18.Text) - Val(r4sess17.Text)
                    r432.Text = Val(r4sess17.Text) - Val(r4sess16.Text)
                    Dim sloper4 As Integer
                    sloper4 = (Val(r421.Text) + Val(r432.Text)) / 2
                    r4321Tot.Text = Val(r4sess16.Text) + Val(r4sess17.Text) + Val(r4sess18.Text)
                    r4321slope.Text = sloper4 / Val(r4321Tot.Text)
                    'Alternative 3 response
                    r521.Text = Val(r5sess18.Text) - Val(r5sess17.Text)
                    r532.Text = Val(r5sess17.Text) - Val(r5sess16.Text)
                    Dim sloper5 As Integer
                    sloper5 = (Val(r521.Text) + Val(r532.Text)) / 2
                    r5321Tot.Text = Val(r5sess16.Text) + Val(r5sess17.Text) + Val(r5sess18.Text)
                    r5321slope.Text = sloper5 / Val(r5321Tot.Text)
                    'Alternative 4 response
                    r621.Text = Val(r6sess18.Text) - Val(r6sess17.Text)
                    r632.Text = Val(r6sess17.Text) - Val(r6sess16.Text)
                    Dim sloper6 As Integer
                    sloper6 = (Val(r621.Text) + Val(r632.Text)) / 2
                    r6321Tot.Text = Val(r6sess16.Text) + Val(r6sess17.Text) + Val(r6sess18.Text)
                    r6321slope.Text = sloper6 / Val(r6321Tot.Text)
                    'Inactive control
                    r321.Text = Val(r3sess18.Text) - Val(r3sess17.Text)
                    r332.Text = Val(r3sess17.Text) - Val(r3sess16.Text)
                    Dim sloper3 As Integer
                    sloper3 = (Val(r321.Text) + Val(r332.Text)) / 2
                    r3321Tot.Text = Val(r3sess16.Text) + Val(r3sess17.Text) + Val(r3sess18.Text)
                    r3321slope.Text = sloper3 / Val(r3321Tot.Text)
                    'Code for stability determination. 
                    If r121.Text <= 6 Then
                        If r121.Text >= -6 Then
                            If r132.Text <= 6 Then
                                If r132.Text >= -6 Then
                                    If r221.Text <= 6 Then
                                        If r221.Text >= -6 Then
                                            If r232.Text <= 6 Then
                                                If r232.Text >= -6 Then
                                                    If r321.Text <= 6 Then
                                                        If r321.Text >= -6 Then
                                                            If r332.Text <= 6 Then
                                                                If r332.Text >= -6 Then
                                                                    If r421.Text <= 6 Then
                                                                        If r421.Text >= -6 Then
                                                                            If r432.Text <= 6 Then
                                                                                If r432.Text >= -6 Then
                                                                                    If r521.Text <= 6 Then
                                                                                        If r521.Text >= -6 Then
                                                                                            If r532.Text <= 6 Then
                                                                                                If r532.Text >= -6 Then
                                                                                                    If r621.Text <= 6 Then
                                                                                                        If r621.Text >= -6 Then
                                                                                                            If r632.Text <= 6 Then
                                                                                                                If r632.Text >= -6 Then
                                                                                                                    If r1321slope.Text >= -0.1 Then
                                                                                                                        If r1321slope.Text <= 0.1 Then
                                                                                                                            If r2321slope.Text >= -0.1 Then
                                                                                                                                If r2321slope.Text <= 0.1 Then
                                                                                                                                    If r3321slope.Text >= -0.1 Then
                                                                                                                                        If r3321slope.Text <= 0.1 Then
                                                                                                                                            If r4321slope.Text >= -0.1 Then
                                                                                                                                                If r4321slope.Text <= 0.1 Then
                                                                                                                                                    If r5321slope.Text >= -0.1 Then
                                                                                                                                                        If r5321slope.Text <= 0.1 Then
                                                                                                                                                            If r6321slope.Text >= -0.1 Then
                                                                                                                                                                If r6321slope.Text <= 0.1 Then
                                                                                                                                                                    If phaseNumber.Text = 3 Then
                                                                                                                                                                        SessionTime.Enabled = False
                                                                                                                                                                        sessionEnd.Visible = True
                                                                                                                                                                        debriefLoad.Visible = True
                                                                                                                                                                        csvTextBox.Text = csvTextBox.Text + "Phase 3 ended at 2160-sec" + ","
                                                                                                                                                                    End If
                                                                                                                                                                End If
                                                                                                                                                            End If
                                                                                                                                                        End If
                                                                                                                                                    End If
                                                                                                                                                End If
                                                                                                                                            End If
                                                                                                                                        End If
                                                                                                                                    End If
                                                                                                                                End If
                                                                                                                            End If
                                                                                                                        End If
                                                                                                                    End If
                                                                                                                End If
                                                                                                            End If
                                                                                                        End If
                                                                                                    End If
                                                                                                End If
                                                                                            End If
                                                                                        End If
                                                                                    End If
                                                                                End If
                                                                            End If
                                                                        End If
                                                                    End If
                                                                End If
                                                            End If
                                                        End If
                                                    End If
                                                End If
                                            End If
                                        End If
                                    End If
                                End If
                            End If
                        End If
                    End If
                End If
                If TimeLeft.Text = 2280 Then
                    If r1sess17.Text = 0 Then
                        r1sess17.Text = r1sess17.Text + 0.01
                    End If
                    If r1sess18.Text = 0 Then
                        r1sess18.Text = r1sess18.Text + 0.02
                    End If
                    If r1sess19.Text = 0 Then
                        r1sess19.Text = r1sess19.Text + 0.03
                    End If
                    If r2sess17.Text = 0 Then
                        r2sess17.Text = r2sess17.Text + 0.01
                    End If
                    If r2sess18.Text = 0 Then
                        r2sess18.Text = r2sess18.Text + 0.02
                    End If
                    If r2sess19.Text = 0 Then
                        r2sess19.Text = r2sess19.Text + 0.03
                    End If
                    If r3sess17.Text = 0 Then
                        r3sess17.Text = r3sess17.Text + 0.01
                    End If
                    If r3sess18.Text = 0 Then
                        r3sess18.Text = r3sess18.Text + 0.02
                    End If
                    If r3sess19.Text = 0 Then
                        r3sess19.Text = r3sess19.Text + 0.03
                    End If
                    If r4sess17.Text = 0 Then
                        r4sess17.Text = r4sess17.Text + 0.01
                    End If
                    If r4sess18.Text = 0 Then
                        r4sess18.Text = r4sess18.Text + 0.02
                    End If
                    If r4sess19.Text = 0 Then
                        r4sess19.Text = r4sess19.Text + 0.03
                    End If
                    If r5sess17.Text = 0 Then
                        r5sess17.Text = r5sess17.Text + 0.01
                    End If
                    If r5sess18.Text = 0 Then
                        r5sess18.Text = r5sess18.Text + 0.02
                    End If
                    If r5sess19.Text = 0 Then
                        r5sess19.Text = r5sess19.Text + 0.03
                    End If
                    If r6sess17.Text = 0 Then
                        r6sess17.Text = r6sess17.Text + 0.01
                    End If
                    If r6sess18.Text = 0 Then
                        r6sess18.Text = r6sess18.Text + 0.02
                    End If
                    If r6sess19.Text = 0 Then
                        r6sess19.Text = r6sess19.Text + 0.03
                    End If
                    'Target response
                    r121.Text = Val(r1sess19.Text) - Val(r1sess18.Text)
                    r132.Text = Val(r1sess18.Text) - Val(r1sess17.Text)
                    Dim sloper1 As Integer
                    sloper1 = (Val(r121.Text) + Val(r132.Text)) / 2
                    r1321Tot.Text = Val(r1sess17.Text) + Val(r1sess18.Text) + Val(r1sess19.Text)
                    r1321slope.Text = sloper1 / Val(r1321Tot.Text)
                    'Alternative 1 response
                    r221.Text = Val(r2sess19.Text) - Val(r2sess18.Text)
                    r232.Text = Val(r2sess18.Text) - Val(r2sess17.Text)
                    Dim sloper2 As Integer
                    sloper2 = (Val(r221.Text) + Val(r232.Text)) / 2
                    r2321Tot.Text = Val(r2sess17.Text) + Val(r2sess18.Text) + Val(r2sess19.Text)
                    r2321slope.Text = sloper2 / Val(r2321Tot.Text)
                    'Alternative 2 response
                    r421.Text = Val(r4sess19.Text) - Val(r4sess18.Text)
                    r432.Text = Val(r4sess18.Text) - Val(r4sess17.Text)
                    Dim sloper4 As Integer
                    sloper4 = (Val(r421.Text) + Val(r432.Text)) / 2
                    r4321Tot.Text = Val(r4sess17.Text) + Val(r4sess18.Text) + Val(r4sess19.Text)
                    r4321slope.Text = sloper4 / Val(r4321Tot.Text)
                    'Alternative 3 response
                    r521.Text = Val(r5sess19.Text) - Val(r5sess18.Text)
                    r532.Text = Val(r5sess18.Text) - Val(r5sess17.Text)
                    Dim sloper5 As Integer
                    sloper5 = (Val(r521.Text) + Val(r532.Text)) / 2
                    r5321Tot.Text = Val(r5sess17.Text) + Val(r5sess18.Text) + Val(r5sess19.Text)
                    r5321slope.Text = sloper5 / Val(r5321Tot.Text)
                    'Alternative 4 response
                    r621.Text = Val(r6sess19.Text) - Val(r6sess18.Text)
                    r632.Text = Val(r6sess18.Text) - Val(r6sess17.Text)
                    Dim sloper6 As Integer
                    sloper6 = (Val(r621.Text) + Val(r632.Text)) / 2
                    r6321Tot.Text = Val(r6sess17.Text) + Val(r6sess18.Text) + Val(r6sess19.Text)
                    r6321slope.Text = sloper6 / Val(r6321Tot.Text)
                    'Inactive control
                    r321.Text = Val(r3sess19.Text) - Val(r3sess18.Text)
                    r332.Text = Val(r3sess18.Text) - Val(r3sess17.Text)
                    Dim sloper3 As Integer
                    sloper3 = (Val(r321.Text) + Val(r332.Text)) / 2
                    r3321Tot.Text = Val(r3sess17.Text) + Val(r3sess18.Text) + Val(r3sess19.Text)
                    r3321slope.Text = sloper3 / Val(r3321Tot.Text)
                    'Code for stability determination. 
                    If r121.Text <= 6 Then
                        If r121.Text >= -6 Then
                            If r132.Text <= 6 Then
                                If r132.Text >= -6 Then
                                    If r221.Text <= 6 Then
                                        If r221.Text >= -6 Then
                                            If r232.Text <= 6 Then
                                                If r232.Text >= -6 Then
                                                    If r321.Text <= 6 Then
                                                        If r321.Text >= -6 Then
                                                            If r332.Text <= 6 Then
                                                                If r332.Text >= -6 Then
                                                                    If r421.Text <= 6 Then
                                                                        If r421.Text >= -6 Then
                                                                            If r432.Text <= 6 Then
                                                                                If r432.Text >= -6 Then
                                                                                    If r521.Text <= 6 Then
                                                                                        If r521.Text >= -6 Then
                                                                                            If r532.Text <= 6 Then
                                                                                                If r532.Text >= -6 Then
                                                                                                    If r621.Text <= 6 Then
                                                                                                        If r621.Text >= -6 Then
                                                                                                            If r632.Text <= 6 Then
                                                                                                                If r632.Text >= -6 Then
                                                                                                                    If r1321slope.Text >= -0.1 Then
                                                                                                                        If r1321slope.Text <= 0.1 Then
                                                                                                                            If r2321slope.Text >= -0.1 Then
                                                                                                                                If r2321slope.Text <= 0.1 Then
                                                                                                                                    If r3321slope.Text >= -0.1 Then
                                                                                                                                        If r3321slope.Text <= 0.1 Then
                                                                                                                                            If r4321slope.Text >= -0.1 Then
                                                                                                                                                If r4321slope.Text <= 0.1 Then
                                                                                                                                                    If r5321slope.Text >= -0.1 Then
                                                                                                                                                        If r5321slope.Text <= 0.1 Then
                                                                                                                                                            If r6321slope.Text >= -0.1 Then
                                                                                                                                                                If r6321slope.Text <= 0.1 Then
                                                                                                                                                                    If phaseNumber.Text = 3 Then
                                                                                                                                                                        SessionTime.Enabled = False
                                                                                                                                                                        sessionEnd.Visible = True
                                                                                                                                                                        debriefLoad.Visible = True
                                                                                                                                                                        csvTextBox.Text = csvTextBox.Text + "Phase 3 ended at 2280-sec" + ","
                                                                                                                                                                    End If
                                                                                                                                                                End If
                                                                                                                                                            End If
                                                                                                                                                        End If
                                                                                                                                                    End If
                                                                                                                                                End If
                                                                                                                                            End If
                                                                                                                                        End If
                                                                                                                                    End If
                                                                                                                                End If
                                                                                                                            End If
                                                                                                                        End If
                                                                                                                    End If
                                                                                                                End If
                                                                                                            End If
                                                                                                        End If
                                                                                                    End If
                                                                                                End If
                                                                                            End If
                                                                                        End If
                                                                                    End If
                                                                                End If
                                                                            End If
                                                                        End If
                                                                    End If
                                                                End If
                                                            End If
                                                        End If
                                                    End If
                                                End If
                                            End If
                                        End If
                                    End If
                                End If
                            End If
                        End If
                    End If
                End If
                If TimeLeft.Text = 2400 Then
                    If r1sess18.Text = 0 Then
                        r1sess18.Text = r1sess18.Text + 0.01
                    End If
                    If r1sess19.Text = 0 Then
                        r1sess19.Text = r1sess19.Text + 0.02
                    End If
                    If r1sess20.Text = 0 Then
                        r1sess20.Text = r1sess20.Text + 0.03
                    End If
                    If r2sess18.Text = 0 Then
                        r2sess18.Text = r2sess18.Text + 0.01
                    End If
                    If r2sess19.Text = 0 Then
                        r2sess19.Text = r2sess19.Text + 0.02
                    End If
                    If r2sess20.Text = 0 Then
                        r2sess20.Text = r2sess20.Text + 0.03
                    End If
                    If r3sess18.Text = 0 Then
                        r3sess18.Text = r3sess18.Text + 0.01
                    End If
                    If r3sess19.Text = 0 Then
                        r3sess19.Text = r3sess19.Text + 0.02
                    End If
                    If r3sess20.Text = 0 Then
                        r3sess20.Text = r3sess20.Text + 0.03
                    End If
                    If r4sess18.Text = 0 Then
                        r4sess18.Text = r4sess18.Text + 0.01
                    End If
                    If r4sess19.Text = 0 Then
                        r4sess19.Text = r4sess19.Text + 0.02
                    End If
                    If r4sess20.Text = 0 Then
                        r4sess20.Text = r4sess20.Text + 0.03
                    End If
                    If r5sess18.Text = 0 Then
                        r5sess18.Text = r5sess18.Text + 0.01
                    End If
                    If r5sess19.Text = 0 Then
                        r5sess19.Text = r5sess19.Text + 0.02
                    End If
                    If r5sess20.Text = 0 Then
                        r5sess20.Text = r5sess20.Text + 0.03
                    End If
                    If r6sess18.Text = 0 Then
                        r6sess18.Text = r6sess18.Text + 0.01
                    End If
                    If r6sess19.Text = 0 Then
                        r6sess19.Text = r6sess19.Text + 0.02
                    End If
                    If r6sess20.Text = 0 Then
                        r6sess20.Text = r6sess20.Text + 0.03
                    End If
                    'Target response
                    r121.Text = Val(r1sess20.Text) - Val(r1sess19.Text)
                    r132.Text = Val(r1sess19.Text) - Val(r1sess18.Text)
                    Dim sloper1 As Integer
                    sloper1 = (Val(r121.Text) + Val(r132.Text)) / 2
                    r1321Tot.Text = Val(r1sess18.Text) + Val(r1sess19.Text) + Val(r1sess20.Text)
                    r1321slope.Text = sloper1 / Val(r1321Tot.Text)
                    'Alternative 1 response
                    r221.Text = Val(r2sess20.Text) - Val(r2sess19.Text)
                    r232.Text = Val(r2sess19.Text) - Val(r2sess18.Text)
                    Dim sloper2 As Integer
                    sloper2 = (Val(r221.Text) + Val(r232.Text)) / 2
                    r2321Tot.Text = Val(r2sess18.Text) + Val(r2sess19.Text) + Val(r2sess20.Text)
                    r2321slope.Text = sloper2 / Val(r2321Tot.Text)
                    'Alternative 2 response
                    r421.Text = Val(r4sess20.Text) - Val(r4sess19.Text)
                    r432.Text = Val(r4sess19.Text) - Val(r4sess18.Text)
                    Dim sloper4 As Integer
                    sloper4 = (Val(r421.Text) + Val(r432.Text)) / 2
                    r4321Tot.Text = Val(r4sess18.Text) + Val(r4sess19.Text) + Val(r4sess20.Text)
                    r4321slope.Text = sloper4 / Val(r4321Tot.Text)
                    'Alternative 3 response
                    r521.Text = Val(r5sess20.Text) - Val(r5sess19.Text)
                    r532.Text = Val(r5sess19.Text) - Val(r5sess18.Text)
                    Dim sloper5 As Integer
                    sloper5 = (Val(r521.Text) + Val(r532.Text)) / 2
                    r5321Tot.Text = Val(r5sess18.Text) + Val(r5sess19.Text) + Val(r5sess20.Text)
                    r5321slope.Text = sloper5 / Val(r5321Tot.Text)
                    'Alternative 4 response
                    r621.Text = Val(r6sess20.Text) - Val(r6sess19.Text)
                    r632.Text = Val(r6sess19.Text) - Val(r6sess18.Text)
                    Dim sloper6 As Integer
                    sloper6 = (Val(r621.Text) + Val(r632.Text)) / 2
                    r6321Tot.Text = Val(r6sess18.Text) + Val(r6sess19.Text) + Val(r6sess20.Text)
                    r6321slope.Text = sloper6 / Val(r6321Tot.Text)
                    'Inactive control
                    r321.Text = Val(r3sess20.Text) - Val(r3sess19.Text)
                    r332.Text = Val(r3sess19.Text) - Val(r3sess18.Text)
                    Dim sloper3 As Integer
                    sloper3 = (Val(r321.Text) + Val(r332.Text)) / 2
                    r3321Tot.Text = Val(r3sess18.Text) + Val(r3sess19.Text) + Val(r3sess20.Text)
                    r3321slope.Text = sloper3 / Val(r3321Tot.Text)
                    'Code for stability determination. 
                    If r121.Text <= 6 Then
                        If r121.Text >= -6 Then
                            If r132.Text <= 6 Then
                                If r132.Text >= -6 Then
                                    If r221.Text <= 6 Then
                                        If r221.Text >= -6 Then
                                            If r232.Text <= 6 Then
                                                If r232.Text >= -6 Then
                                                    If r321.Text <= 6 Then
                                                        If r321.Text >= -6 Then
                                                            If r332.Text <= 6 Then
                                                                If r332.Text >= -6 Then
                                                                    If r421.Text <= 6 Then
                                                                        If r421.Text >= -6 Then
                                                                            If r432.Text <= 6 Then
                                                                                If r432.Text >= -6 Then
                                                                                    If r521.Text <= 6 Then
                                                                                        If r521.Text >= -6 Then
                                                                                            If r532.Text <= 6 Then
                                                                                                If r532.Text >= -6 Then
                                                                                                    If r621.Text <= 6 Then
                                                                                                        If r621.Text >= -6 Then
                                                                                                            If r632.Text <= 6 Then
                                                                                                                If r632.Text >= -6 Then
                                                                                                                    If r1321slope.Text >= -0.1 Then
                                                                                                                        If r1321slope.Text <= 0.1 Then
                                                                                                                            If r2321slope.Text >= -0.1 Then
                                                                                                                                If r2321slope.Text <= 0.1 Then
                                                                                                                                    If r3321slope.Text >= -0.1 Then
                                                                                                                                        If r3321slope.Text <= 0.1 Then
                                                                                                                                            If r4321slope.Text >= -0.1 Then
                                                                                                                                                If r4321slope.Text <= 0.1 Then
                                                                                                                                                    If r5321slope.Text >= -0.1 Then
                                                                                                                                                        If r5321slope.Text <= 0.1 Then
                                                                                                                                                            If r6321slope.Text >= -0.1 Then
                                                                                                                                                                If r6321slope.Text <= 0.1 Then
                                                                                                                                                                    If phaseNumber.Text = 3 Then
                                                                                                                                                                        SessionTime.Enabled = False
                                                                                                                                                                        sessionEnd.Visible = True
                                                                                                                                                                        debriefLoad.Visible = True
                                                                                                                                                                        csvTextBox.Text = csvTextBox.Text + "Phase 3 ended at 2400-sec" + ","
                                                                                                                                                                    End If
                                                                                                                                                                End If
                                                                                                                                                            End If
                                                                                                                                                        End If
                                                                                                                                                    End If
                                                                                                                                                End If
                                                                                                                                            End If
                                                                                                                                        End If
                                                                                                                                    End If
                                                                                                                                End If
                                                                                                                            End If
                                                                                                                        End If
                                                                                                                    End If
                                                                                                                End If
                                                                                                            End If
                                                                                                        End If
                                                                                                    End If
                                                                                                End If
                                                                                            End If
                                                                                        End If
                                                                                    End If
                                                                                End If
                                                                            End If
                                                                        End If
                                                                    End If
                                                                End If
                                                            End If
                                                        End If
                                                    End If
                                                End If
                                            End If
                                        End If
                                    End If
                                End If
                            End If
                        End If
                    End If
                End If
                If TimeLeft.Text = 2520 Then
                    If r1sess19.Text = 0 Then
                        r1sess19.Text = r1sess19.Text + 0.01
                    End If
                    If r1sess20.Text = 0 Then
                        r1sess20.Text = r1sess20.Text + 0.02
                    End If
                    If r1sess21.Text = 0 Then
                        r1sess21.Text = r1sess21.Text + 0.03
                    End If
                    If r2sess19.Text = 0 Then
                        r2sess19.Text = r2sess19.Text + 0.01
                    End If
                    If r2sess20.Text = 0 Then
                        r2sess20.Text = r2sess20.Text + 0.02
                    End If
                    If r2sess21.Text = 0 Then
                        r2sess21.Text = r2sess21.Text + 0.03
                    End If
                    If r3sess19.Text = 0 Then
                        r3sess19.Text = r3sess19.Text + 0.01
                    End If
                    If r3sess20.Text = 0 Then
                        r3sess20.Text = r3sess20.Text + 0.02
                    End If
                    If r3sess21.Text = 0 Then
                        r3sess21.Text = r3sess21.Text + 0.03
                    End If
                    If r4sess19.Text = 0 Then
                        r4sess19.Text = r4sess19.Text + 0.01
                    End If
                    If r4sess20.Text = 0 Then
                        r4sess20.Text = r4sess20.Text + 0.02
                    End If
                    If r4sess21.Text = 0 Then
                        r4sess21.Text = r4sess21.Text + 0.03
                    End If
                    If r5sess19.Text = 0 Then
                        r5sess19.Text = r5sess19.Text + 0.01
                    End If
                    If r5sess20.Text = 0 Then
                        r5sess20.Text = r5sess20.Text + 0.02
                    End If
                    If r5sess21.Text = 0 Then
                        r5sess21.Text = r5sess21.Text + 0.03
                    End If
                    If r6sess19.Text = 0 Then
                        r6sess19.Text = r6sess19.Text + 0.01
                    End If
                    If r6sess20.Text = 0 Then
                        r6sess20.Text = r6sess20.Text + 0.02
                    End If
                    If r6sess21.Text = 0 Then
                        r6sess21.Text = r6sess21.Text + 0.03
                    End If
                    'Target response
                    r121.Text = Val(r1sess21.Text) - Val(r1sess20.Text)
                    r132.Text = Val(r1sess20.Text) - Val(r1sess19.Text)
                    Dim sloper1 As Integer
                    sloper1 = (Val(r121.Text) + Val(r132.Text)) / 2
                    r1321Tot.Text = Val(r1sess19.Text) + Val(r1sess20.Text) + Val(r1sess21.Text)
                    r1321slope.Text = sloper1 / Val(r1321Tot.Text)
                    'Alternative 1 response
                    r221.Text = Val(r2sess21.Text) - Val(r2sess20.Text)
                    r232.Text = Val(r2sess20.Text) - Val(r2sess19.Text)
                    Dim sloper2 As Integer
                    sloper2 = (Val(r221.Text) + Val(r232.Text)) / 2
                    r2321Tot.Text = Val(r2sess19.Text) + Val(r2sess20.Text) + Val(r2sess21.Text)
                    r2321slope.Text = sloper2 / Val(r2321Tot.Text)
                    'Alternative 2 response
                    r421.Text = Val(r4sess21.Text) - Val(r4sess20.Text)
                    r432.Text = Val(r4sess20.Text) - Val(r4sess19.Text)
                    Dim sloper4 As Integer
                    sloper4 = (Val(r421.Text) + Val(r432.Text)) / 2
                    r4321Tot.Text = Val(r4sess19.Text) + Val(r4sess20.Text) + Val(r4sess21.Text)
                    r4321slope.Text = sloper4 / Val(r4321Tot.Text)
                    'Alternative 3 response
                    r521.Text = Val(r5sess21.Text) - Val(r5sess20.Text)
                    r532.Text = Val(r5sess20.Text) - Val(r5sess19.Text)
                    Dim sloper5 As Integer
                    sloper5 = (Val(r521.Text) + Val(r532.Text)) / 2
                    r5321Tot.Text = Val(r5sess19.Text) + Val(r5sess20.Text) + Val(r5sess21.Text)
                    r5321slope.Text = sloper5 / Val(r5321Tot.Text)
                    'Alternative 4 response
                    r621.Text = Val(r6sess21.Text) - Val(r6sess20.Text)
                    r632.Text = Val(r6sess20.Text) - Val(r6sess19.Text)
                    Dim sloper6 As Integer
                    sloper6 = (Val(r621.Text) + Val(r632.Text)) / 2
                    r6321Tot.Text = Val(r6sess19.Text) + Val(r6sess20.Text) + Val(r6sess21.Text)
                    r6321slope.Text = sloper6 / Val(r6321Tot.Text)
                    'Inactive control
                    r321.Text = Val(r3sess21.Text) - Val(r3sess20.Text)
                    r332.Text = Val(r3sess20.Text) - Val(r3sess19.Text)
                    Dim sloper3 As Integer
                    sloper3 = (Val(r321.Text) + Val(r332.Text)) / 2
                    r3321Tot.Text = Val(r3sess19.Text) + Val(r3sess20.Text) + Val(r3sess21.Text)
                    r3321slope.Text = sloper3 / Val(r3321Tot.Text)
                    'Code for stability determination. 
                    If r121.Text <= 6 Then
                        If r121.Text >= -6 Then
                            If r132.Text <= 6 Then
                                If r132.Text >= -6 Then
                                    If r221.Text <= 6 Then
                                        If r221.Text >= -6 Then
                                            If r232.Text <= 6 Then
                                                If r232.Text >= -6 Then
                                                    If r321.Text <= 6 Then
                                                        If r321.Text >= -6 Then
                                                            If r332.Text <= 6 Then
                                                                If r332.Text >= -6 Then
                                                                    If r421.Text <= 6 Then
                                                                        If r421.Text >= -6 Then
                                                                            If r432.Text <= 6 Then
                                                                                If r432.Text >= -6 Then
                                                                                    If r521.Text <= 6 Then
                                                                                        If r521.Text >= -6 Then
                                                                                            If r532.Text <= 6 Then
                                                                                                If r532.Text >= -6 Then
                                                                                                    If r621.Text <= 6 Then
                                                                                                        If r621.Text >= -6 Then
                                                                                                            If r632.Text <= 6 Then
                                                                                                                If r632.Text >= -6 Then
                                                                                                                    If r1321slope.Text >= -0.1 Then
                                                                                                                        If r1321slope.Text <= 0.1 Then
                                                                                                                            If r2321slope.Text >= -0.1 Then
                                                                                                                                If r2321slope.Text <= 0.1 Then
                                                                                                                                    If r3321slope.Text >= -0.1 Then
                                                                                                                                        If r3321slope.Text <= 0.1 Then
                                                                                                                                            If r4321slope.Text >= -0.1 Then
                                                                                                                                                If r4321slope.Text <= 0.1 Then
                                                                                                                                                    If r5321slope.Text >= -0.1 Then
                                                                                                                                                        If r5321slope.Text <= 0.1 Then
                                                                                                                                                            If r6321slope.Text >= -0.1 Then
                                                                                                                                                                If r6321slope.Text <= 0.1 Then
                                                                                                                                                                    If phaseNumber.Text = 3 Then
                                                                                                                                                                        SessionTime.Enabled = False
                                                                                                                                                                        sessionEnd.Visible = True
                                                                                                                                                                        debriefLoad.Visible = True
                                                                                                                                                                        csvTextBox.Text = csvTextBox.Text + "Phase 3 ended at 2520-sec" + ","
                                                                                                                                                                    End If
                                                                                                                                                                End If
                                                                                                                                                            End If
                                                                                                                                                        End If
                                                                                                                                                    End If
                                                                                                                                                End If
                                                                                                                                            End If
                                                                                                                                        End If
                                                                                                                                    End If
                                                                                                                                End If
                                                                                                                            End If
                                                                                                                        End If
                                                                                                                    End If
                                                                                                                End If
                                                                                                            End If
                                                                                                        End If
                                                                                                    End If
                                                                                                End If
                                                                                            End If
                                                                                        End If
                                                                                    End If
                                                                                End If
                                                                            End If
                                                                        End If
                                                                    End If
                                                                End If
                                                            End If
                                                        End If
                                                    End If
                                                End If
                                            End If
                                        End If
                                    End If
                                End If
                            End If
                        End If
                    End If
                End If
                If TimeLeft.Text = 2640 Then
                    If r1sess20.Text = 0 Then
                        r1sess20.Text = r1sess20.Text + 0.01
                    End If
                    If r1sess21.Text = 0 Then
                        r1sess21.Text = r1sess21.Text + 0.02
                    End If
                    If r1sess22.Text = 0 Then
                        r1sess22.Text = r1sess22.Text + 0.03
                    End If
                    If r2sess20.Text = 0 Then
                        r2sess20.Text = r2sess20.Text + 0.01
                    End If
                    If r2sess21.Text = 0 Then
                        r2sess21.Text = r2sess21.Text + 0.02
                    End If
                    If r2sess22.Text = 0 Then
                        r2sess22.Text = r2sess22.Text + 0.03
                    End If
                    If r3sess20.Text = 0 Then
                        r3sess20.Text = r3sess20.Text + 0.01
                    End If
                    If r3sess21.Text = 0 Then
                        r3sess21.Text = r3sess21.Text + 0.02
                    End If
                    If r3sess22.Text = 0 Then
                        r3sess22.Text = r3sess22.Text + 0.03
                    End If
                    If r4sess20.Text = 0 Then
                        r4sess20.Text = r4sess20.Text + 0.01
                    End If
                    If r4sess21.Text = 0 Then
                        r4sess21.Text = r4sess21.Text + 0.02
                    End If
                    If r4sess22.Text = 0 Then
                        r4sess22.Text = r4sess22.Text + 0.03
                    End If
                    If r5sess20.Text = 0 Then
                        r5sess20.Text = r5sess20.Text + 0.01
                    End If
                    If r5sess21.Text = 0 Then
                        r5sess21.Text = r5sess21.Text + 0.02
                    End If
                    If r5sess22.Text = 0 Then
                        r5sess22.Text = r5sess22.Text + 0.03
                    End If
                    If r6sess20.Text = 0 Then
                        r6sess20.Text = r6sess20.Text + 0.01
                    End If
                    If r6sess21.Text = 0 Then
                        r6sess21.Text = r6sess21.Text + 0.02
                    End If
                    If r6sess22.Text = 0 Then
                        r6sess22.Text = r6sess22.Text + 0.03
                    End If
                    'Target response
                    r121.Text = Val(r1sess22.Text) - Val(r1sess21.Text)
                    r132.Text = Val(r1sess21.Text) - Val(r1sess20.Text)
                    Dim sloper1 As Integer
                    sloper1 = (Val(r121.Text) + Val(r132.Text)) / 2
                    r1321Tot.Text = Val(r1sess20.Text) + Val(r1sess21.Text) + Val(r1sess22.Text)
                    r1321slope.Text = sloper1 / Val(r1321Tot.Text)
                    'Alternative 1 response
                    r221.Text = Val(r2sess22.Text) - Val(r2sess21.Text)
                    r232.Text = Val(r2sess21.Text) - Val(r2sess20.Text)
                    Dim sloper2 As Integer
                    sloper2 = (Val(r221.Text) + Val(r232.Text)) / 2
                    r2321Tot.Text = Val(r2sess20.Text) + Val(r2sess21.Text) + Val(r2sess22.Text)
                    r2321slope.Text = sloper2 / Val(r2321Tot.Text)
                    'Alternative 2 response
                    r421.Text = Val(r4sess22.Text) - Val(r4sess21.Text)
                    r432.Text = Val(r4sess21.Text) - Val(r4sess20.Text)
                    Dim sloper4 As Integer
                    sloper4 = (Val(r421.Text) + Val(r432.Text)) / 2
                    r4321Tot.Text = Val(r4sess20.Text) + Val(r4sess21.Text) + Val(r4sess22.Text)
                    r4321slope.Text = sloper4 / Val(r4321Tot.Text)
                    'Alternative 3 response
                    r521.Text = Val(r5sess22.Text) - Val(r5sess21.Text)
                    r532.Text = Val(r5sess21.Text) - Val(r5sess20.Text)
                    Dim sloper5 As Integer
                    sloper5 = (Val(r521.Text) + Val(r532.Text)) / 2
                    r5321Tot.Text = Val(r5sess20.Text) + Val(r5sess21.Text) + Val(r5sess22.Text)
                    r5321slope.Text = sloper5 / Val(r5321Tot.Text)
                    'Alternative 4 response
                    r621.Text = Val(r6sess22.Text) - Val(r6sess21.Text)
                    r632.Text = Val(r6sess21.Text) - Val(r6sess20.Text)
                    Dim sloper6 As Integer
                    sloper6 = (Val(r621.Text) + Val(r632.Text)) / 2
                    r6321Tot.Text = Val(r6sess20.Text) + Val(r6sess21.Text) + Val(r6sess22.Text)
                    r6321slope.Text = sloper6 / Val(r6321Tot.Text)
                    'Inactive control
                    r321.Text = Val(r3sess22.Text) - Val(r3sess21.Text)
                    r332.Text = Val(r3sess21.Text) - Val(r3sess20.Text)
                    Dim sloper3 As Integer
                    sloper3 = (Val(r321.Text) + Val(r332.Text)) / 2
                    r3321Tot.Text = Val(r3sess20.Text) + Val(r3sess21.Text) + Val(r3sess22.Text)
                    r3321slope.Text = sloper3 / Val(r3321Tot.Text)
                    'Code for stability determination. 
                    If r121.Text <= 6 Then
                        If r121.Text >= -6 Then
                            If r132.Text <= 6 Then
                                If r132.Text >= -6 Then
                                    If r221.Text <= 6 Then
                                        If r221.Text >= -6 Then
                                            If r232.Text <= 6 Then
                                                If r232.Text >= -6 Then
                                                    If r321.Text <= 6 Then
                                                        If r321.Text >= -6 Then
                                                            If r332.Text <= 6 Then
                                                                If r332.Text >= -6 Then
                                                                    If r421.Text <= 6 Then
                                                                        If r421.Text >= -6 Then
                                                                            If r432.Text <= 6 Then
                                                                                If r432.Text >= -6 Then
                                                                                    If r521.Text <= 6 Then
                                                                                        If r521.Text >= -6 Then
                                                                                            If r532.Text <= 6 Then
                                                                                                If r532.Text >= -6 Then
                                                                                                    If r621.Text <= 6 Then
                                                                                                        If r621.Text >= -6 Then
                                                                                                            If r632.Text <= 6 Then
                                                                                                                If r632.Text >= -6 Then
                                                                                                                    If r1321slope.Text >= -0.1 Then
                                                                                                                        If r1321slope.Text <= 0.1 Then
                                                                                                                            If r2321slope.Text >= -0.1 Then
                                                                                                                                If r2321slope.Text <= 0.1 Then
                                                                                                                                    If r3321slope.Text >= -0.1 Then
                                                                                                                                        If r3321slope.Text <= 0.1 Then
                                                                                                                                            If r4321slope.Text >= -0.1 Then
                                                                                                                                                If r4321slope.Text <= 0.1 Then
                                                                                                                                                    If r5321slope.Text >= -0.1 Then
                                                                                                                                                        If r5321slope.Text <= 0.1 Then
                                                                                                                                                            If r6321slope.Text >= -0.1 Then
                                                                                                                                                                If r6321slope.Text <= 0.1 Then
                                                                                                                                                                    If phaseNumber.Text = 3 Then
                                                                                                                                                                        SessionTime.Enabled = False
                                                                                                                                                                        sessionEnd.Visible = True
                                                                                                                                                                        debriefLoad.Visible = True
                                                                                                                                                                        csvTextBox.Text = csvTextBox.Text + "Phase 3 ended at 2640-sec" + ","
                                                                                                                                                                    End If
                                                                                                                                                                End If
                                                                                                                                                            End If
                                                                                                                                                        End If
                                                                                                                                                    End If
                                                                                                                                                End If
                                                                                                                                            End If
                                                                                                                                        End If
                                                                                                                                    End If
                                                                                                                                End If
                                                                                                                            End If
                                                                                                                        End If
                                                                                                                    End If
                                                                                                                End If
                                                                                                            End If
                                                                                                        End If
                                                                                                    End If
                                                                                                End If
                                                                                            End If
                                                                                        End If
                                                                                    End If
                                                                                End If
                                                                            End If
                                                                        End If
                                                                    End If
                                                                End If
                                                            End If
                                                        End If
                                                    End If
                                                End If
                                            End If
                                        End If
                                    End If
                                End If
                            End If
                        End If
                    End If
                End If
                If TimeLeft.Text = 2760 Then
                    If r1sess21.Text = 0 Then
                        r1sess21.Text = r1sess21.Text + 0.01
                    End If
                    If r1sess22.Text = 0 Then
                        r1sess22.Text = r1sess22.Text + 0.02
                    End If
                    If r1sess23.Text = 0 Then
                        r1sess23.Text = r1sess23.Text + 0.03
                    End If
                    If r2sess21.Text = 0 Then
                        r2sess21.Text = r2sess21.Text + 0.01
                    End If
                    If r2sess22.Text = 0 Then
                        r2sess22.Text = r2sess22.Text + 0.02
                    End If
                    If r2sess23.Text = 0 Then
                        r2sess23.Text = r2sess23.Text + 0.03
                    End If
                    If r3sess21.Text = 0 Then
                        r3sess21.Text = r3sess21.Text + 0.01
                    End If
                    If r3sess22.Text = 0 Then
                        r3sess22.Text = r3sess22.Text + 0.02
                    End If
                    If r3sess23.Text = 0 Then
                        r3sess23.Text = r3sess23.Text + 0.03
                    End If
                    If r4sess21.Text = 0 Then
                        r4sess21.Text = r4sess21.Text + 0.01
                    End If
                    If r4sess22.Text = 0 Then
                        r4sess22.Text = r4sess22.Text + 0.02
                    End If
                    If r4sess23.Text = 0 Then
                        r4sess23.Text = r4sess23.Text + 0.03
                    End If
                    If r5sess21.Text = 0 Then
                        r5sess21.Text = r5sess21.Text + 0.01
                    End If
                    If r5sess22.Text = 0 Then
                        r5sess22.Text = r5sess22.Text + 0.02
                    End If
                    If r5sess23.Text = 0 Then
                        r5sess23.Text = r5sess23.Text + 0.03
                    End If
                    If r6sess21.Text = 0 Then
                        r6sess21.Text = r6sess21.Text + 0.01
                    End If
                    If r6sess22.Text = 0 Then
                        r6sess22.Text = r6sess22.Text + 0.02
                    End If
                    If r6sess23.Text = 0 Then
                        r6sess23.Text = r6sess23.Text + 0.03
                    End If
                    'Target response
                    r121.Text = Val(r1sess23.Text) - Val(r1sess22.Text)
                    r132.Text = Val(r1sess22.Text) - Val(r1sess21.Text)
                    Dim sloper1 As Integer
                    sloper1 = (Val(r121.Text) + Val(r132.Text)) / 2
                    r1321Tot.Text = Val(r1sess21.Text) + Val(r1sess22.Text) + Val(r1sess23.Text)
                    r1321slope.Text = sloper1 / Val(r1321Tot.Text)
                    'Alternative 1 response
                    r221.Text = Val(r2sess23.Text) - Val(r2sess22.Text)
                    r232.Text = Val(r2sess22.Text) - Val(r2sess21.Text)
                    Dim sloper2 As Integer
                    sloper2 = (Val(r221.Text) + Val(r232.Text)) / 2
                    r2321Tot.Text = Val(r2sess21.Text) + Val(r2sess22.Text) + Val(r2sess23.Text)
                    r2321slope.Text = sloper2 / Val(r2321Tot.Text)
                    'Alternative 2 response
                    r421.Text = Val(r4sess23.Text) - Val(r4sess22.Text)
                    r432.Text = Val(r4sess22.Text) - Val(r4sess21.Text)
                    Dim sloper4 As Integer
                    sloper4 = (Val(r421.Text) + Val(r432.Text)) / 2
                    r4321Tot.Text = Val(r4sess21.Text) + Val(r4sess22.Text) + Val(r4sess23.Text)
                    r4321slope.Text = sloper4 / Val(r4321Tot.Text)
                    'Alternative 3 response
                    r521.Text = Val(r5sess23.Text) - Val(r5sess22.Text)
                    r532.Text = Val(r5sess22.Text) - Val(r5sess21.Text)
                    Dim sloper5 As Integer
                    sloper5 = (Val(r521.Text) + Val(r532.Text)) / 2
                    r5321Tot.Text = Val(r5sess21.Text) + Val(r5sess22.Text) + Val(r5sess23.Text)
                    r5321slope.Text = sloper5 / Val(r5321Tot.Text)
                    'Alternative 4 response
                    r621.Text = Val(r6sess23.Text) - Val(r6sess22.Text)
                    r632.Text = Val(r6sess22.Text) - Val(r6sess21.Text)
                    Dim sloper6 As Integer
                    sloper6 = (Val(r621.Text) + Val(r632.Text)) / 2
                    r6321Tot.Text = Val(r6sess21.Text) + Val(r6sess22.Text) + Val(r6sess23.Text)
                    r6321slope.Text = sloper6 / Val(r6321Tot.Text)
                    'Inactive control
                    r321.Text = Val(r3sess23.Text) - Val(r3sess22.Text)
                    r332.Text = Val(r3sess22.Text) - Val(r3sess21.Text)
                    Dim sloper3 As Integer
                    sloper3 = (Val(r321.Text) + Val(r332.Text)) / 2
                    r3321Tot.Text = Val(r3sess21.Text) + Val(r3sess22.Text) + Val(r3sess23.Text)
                    r3321slope.Text = sloper3 / Val(r3321Tot.Text)
                    'Code for stability determination. 
                    If r121.Text <= 6 Then
                        If r121.Text >= -6 Then
                            If r132.Text <= 6 Then
                                If r132.Text >= -6 Then
                                    If r221.Text <= 6 Then
                                        If r221.Text >= -6 Then
                                            If r232.Text <= 6 Then
                                                If r232.Text >= -6 Then
                                                    If r321.Text <= 6 Then
                                                        If r321.Text >= -6 Then
                                                            If r332.Text <= 6 Then
                                                                If r332.Text >= -6 Then
                                                                    If r421.Text <= 6 Then
                                                                        If r421.Text >= -6 Then
                                                                            If r432.Text <= 6 Then
                                                                                If r432.Text >= -6 Then
                                                                                    If r521.Text <= 6 Then
                                                                                        If r521.Text >= -6 Then
                                                                                            If r532.Text <= 6 Then
                                                                                                If r532.Text >= -6 Then
                                                                                                    If r621.Text <= 6 Then
                                                                                                        If r621.Text >= -6 Then
                                                                                                            If r632.Text <= 6 Then
                                                                                                                If r632.Text >= -6 Then
                                                                                                                    If r1321slope.Text >= -0.1 Then
                                                                                                                        If r1321slope.Text <= 0.1 Then
                                                                                                                            If r2321slope.Text >= -0.1 Then
                                                                                                                                If r2321slope.Text <= 0.1 Then
                                                                                                                                    If r3321slope.Text >= -0.1 Then
                                                                                                                                        If r3321slope.Text <= 0.1 Then
                                                                                                                                            If r4321slope.Text >= -0.1 Then
                                                                                                                                                If r4321slope.Text <= 0.1 Then
                                                                                                                                                    If r5321slope.Text >= -0.1 Then
                                                                                                                                                        If r5321slope.Text <= 0.1 Then
                                                                                                                                                            If r6321slope.Text >= -0.1 Then
                                                                                                                                                                If r6321slope.Text <= 0.1 Then
                                                                                                                                                                    If phaseNumber.Text = 3 Then
                                                                                                                                                                        SessionTime.Enabled = False
                                                                                                                                                                        sessionEnd.Visible = True
                                                                                                                                                                        debriefLoad.Visible = True
                                                                                                                                                                        csvTextBox.Text = csvTextBox.Text + "Phase 3 ended at 2760-sec" + ","
                                                                                                                                                                    End If
                                                                                                                                                                End If
                                                                                                                                                            End If
                                                                                                                                                        End If
                                                                                                                                                    End If
                                                                                                                                                End If
                                                                                                                                            End If
                                                                                                                                        End If
                                                                                                                                    End If
                                                                                                                                End If
                                                                                                                            End If
                                                                                                                        End If
                                                                                                                    End If
                                                                                                                End If
                                                                                                            End If
                                                                                                        End If
                                                                                                    End If
                                                                                                End If
                                                                                            End If
                                                                                        End If
                                                                                    End If
                                                                                End If
                                                                            End If
                                                                        End If
                                                                    End If
                                                                End If
                                                            End If
                                                        End If
                                                    End If
                                                End If
                                            End If
                                        End If
                                    End If
                                End If
                            End If
                        End If
                    End If
                End If
                If TimeLeft.Text = 2880 Then
                    SessionTime.Enabled = False
                    sessionEnd.Visible = True
                    debriefLoad.Visible = True
                    csvTextBox.Text = csvTextBox.Text + "Phase 3 ended at 2880-sec" + ","
                End If
            End If
        End If

    End Sub
    Private Sub r1VI_Tick(sender As Object, e As EventArgs) Handles r1VI.Tick
        If r1VIval.Text > 0 Then
            r1VIval.Text = Val(r1VIval.Text) - 1
        End If
    End Sub
    Private Sub r2VI_Tick(sender As Object, e As EventArgs) Handles r2VI.Tick
        If r2VIval.Text > 0 Then
            r2VIval.Text = Val(r2VIval.Text) - 1
        End If
    End Sub

    'Code for inter-phase-intervals. 
    Private Sub interPhaseInterval_Tick(sender As Object, e As EventArgs) Handles interPhaseInterval.Tick
        If IPIvalue.Text > 0 Then
            IPIvalue.Text = Val(IPIvalue.Text) - 1
        End If
        If IPIvalue.Text = 0 Then
            interPhaseInterval.Enabled = False
            IPIvalue.Text = 20
            startNextPhase.Visible = True
        End If
    End Sub
    Private Sub startNextPhase_Click(sender As Object, e As EventArgs) Handles startNextPhase.Click
        startNextPhase.Visible = False
        interPhaseText.Visible = False
        SessionTime.Enabled = True
        phaseNumber.Text = phaseNumber.Text + 1
        r1VIval.Text = r1VIval.Text + 1000
        r1VI.Enabled = False
        r2VIval.Text = r2VIval.Text + 2
        r0101.Visible = True
        r0102.Visible = False
        r0103.Visible = False
        r0104.Visible = False
        r0105.Visible = False
        r0106.Visible = False
        r0201.Visible = True
        r0202.Visible = False
        r0203.Visible = False
        r0204.Visible = False
        r0205.Visible = False
        r0206.Visible = False
        r0301.Visible = True
        r0302.Visible = False
        r0303.Visible = False
        r0304.Visible = False
        r0305.Visible = False
        r0306.Visible = False
        r0401.Visible = True
        r0402.Visible = False
        r0403.Visible = False
        r0404.Visible = False
        r0405.Visible = False
        r0406.Visible = False
        r0501.Visible = True
        r0502.Visible = False
        r0503.Visible = False
        r0504.Visible = False
        r0505.Visible = False
        r0506.Visible = False
        r0601.Visible = True
        r0602.Visible = False
        r0603.Visible = False
        r0604.Visible = False
        r0605.Visible = False
        r0606.Visible = False
        If phaseNumber.Text = 2 Then
            r2CO.Text = 1
            r2VI.Enabled = True
            phaseTwoAltTwoLight.Visible = True
            phaseOneAltTwoLight.Visible = False
            phaseOneAltTwoBlackout.Visible = True
            PhaseOneBank.Visible = False
            PhaseTwoBank.Visible = True
        End If
        If phaseNumber.Text = 3 Then
            r2VI.Enabled = False
            PhaseOneBank.Visible = True
            PhaseTwoBank.Visible = True
        End If
    End Sub

    'Code for reinforcer delivery for VI schedule requirements.
    Private Sub consumResp_Click(sender As Object, e As EventArgs) Handles consumResp.Click
        consumResp.Visible = False
        pointText.Visible = False
        If phaseNumber.Text = 1 Then
            If r1VIval.Text = 0 Then
                Dim r1VIvalue As Integer = CInt(Int((14.5 * Rnd()) + 1))
                r1VIrndVal.Text = r1VIvalue.ToString("##")
                If r1VIrndVal.Text > 0 Then
                    If r1VIrndVal.Text < 1.5 Then
                        r1VIval.Text = 1
                    End If
                End If
                If r1VIrndVal.Text >= 1.5 Then
                    If r1VIrndVal.Text < 2.5 Then
                        r1VIval.Text = 2
                    End If
                End If
                If r1VIrndVal.Text >= 2.5 Then
                    If r1VIrndVal.Text < 3.5 Then
                        r1VIval.Text = 4
                    End If
                End If
                If r1VIrndVal.Text >= 3.5 Then
                    If r1VIrndVal.Text < 4.5 Then
                        r1VIval.Text = 5
                    End If
                End If
                If r1VIrndVal.Text >= 4.5 Then
                    If r1VIrndVal.Text < 5.5 Then
                        r1VIval.Text = 7
                    End If
                End If
                If r1VIrndVal.Text >= 5.5 Then
                    If r1VIrndVal.Text < 6.5 Then
                        r1VIval.Text = 9
                    End If
                End If
                If r1VIrndVal.Text >= 6.5 Then
                    If r1VIrndVal.Text < 7.5 Then
                        r1VIval.Text = 11
                    End If
                End If
                If r1VIrndVal.Text >= 7.5 Then
                    If r1VIrndVal.Text < 8.5 Then
                        r1VIval.Text = 13
                    End If
                End If
                If r1VIrndVal.Text >= 8.5 Then
                    If r1VIrndVal.Text < 9.5 Then
                        r1VIval.Text = 15
                    End If
                End If
                If r1VIrndVal.Text >= 9.5 Then
                    If r1VIrndVal.Text < 10.5 Then
                        r1VIval.Text = 18
                    End If
                End If
                If r1VIrndVal.Text >= 10.5 Then
                    If r1VIrndVal.Text < 11.5 Then
                        r1VIval.Text = 21
                    End If
                End If
                If r1VIrndVal.Text >= 11.5 Then
                    If r1VIrndVal.Text < 12.5 Then
                        r1VIval.Text = 25
                    End If
                End If
                If r1VIrndVal.Text >= 12.5 Then
                    If r1VIrndVal.Text < 13.5 Then
                        r1VIval.Text = 30
                    End If
                End If
                If r1VIrndVal.Text >= 13.5 Then
                    If r1VIrndVal.Text < 14.5 Then
                        r1VIval.Text = 37
                    End If
                End If
                If r1VIrndVal.Text >= 14.5 Then
                    If r1VIrndVal.Text < 15.5 Then
                        r1VIval.Text = 47
                    End If
                End If
                PhaseOneBank.Text = Val(PhaseOneBank.Text) + 5
            End If
        End If
        If phaseNumber.Text = 2 Then
            If r2VIval.Text = 0 Then
                Dim r2VIvalue As Integer = CInt(Int((14.5 * Rnd()) + 1))
                r1VIrndVal.Text = r2VIvalue.ToString("##")
                If r1VIrndVal.Text > 0 Then
                    If r1VIrndVal.Text < 1.5 Then
                        r2VIval.Text = 1
                    End If
                End If
                If r1VIrndVal.Text >= 1.5 Then
                    If r1VIrndVal.Text < 2.5 Then
                        r2VIval.Text = 1
                    End If
                End If
                If r1VIrndVal.Text >= 2.5 Then
                    If r1VIrndVal.Text < 3.5 Then
                        r2VIval.Text = 2
                    End If
                End If
                If r1VIrndVal.Text >= 3.5 Then
                    If r1VIrndVal.Text < 4.5 Then
                        r2VIval.Text = 3
                    End If
                End If
                If r1VIrndVal.Text >= 4.5 Then
                    If r1VIrndVal.Text < 5.5 Then
                        r2VIval.Text = 3
                    End If
                End If
                If r1VIrndVal.Text >= 5.5 Then
                    If r1VIrndVal.Text < 6.5 Then
                        r2VIval.Text = 4
                    End If
                End If
                If r1VIrndVal.Text >= 6.5 Then
                    If r1VIrndVal.Text < 7.5 Then
                        r2VIval.Text = 5
                    End If
                End If
                If r1VIrndVal.Text >= 7.5 Then
                    If r1VIrndVal.Text < 8.5 Then
                        r2VIval.Text = 6
                    End If
                End If
                If r1VIrndVal.Text >= 8.5 Then
                    If r1VIrndVal.Text < 9.5 Then
                        r2VIval.Text = 8
                    End If
                End If
                If r1VIrndVal.Text >= 9.5 Then
                    If r1VIrndVal.Text < 10.5 Then
                        r2VIval.Text = 9
                    End If
                End If
                If r1VIrndVal.Text >= 10.5 Then
                    If r1VIrndVal.Text < 11.5 Then
                        r2VIval.Text = 11
                    End If
                End If
                If r1VIrndVal.Text >= 11.5 Then
                    If r1VIrndVal.Text < 12.5 Then
                        r2VIval.Text = 13
                    End If
                End If
                If r1VIrndVal.Text >= 12.5 Then
                    If r1VIrndVal.Text < 13.5 Then
                        r2VIval.Text = 15
                    End If
                End If
                If r1VIrndVal.Text >= 13.5 Then
                    If r1VIrndVal.Text < 14.5 Then
                        r2VIval.Text = 18
                    End If
                End If
                If r1VIrndVal.Text >= 14.5 Then
                    If r1VIrndVal.Text < 15.5 Then
                        r2VIval.Text = 24
                    End If
                End If
                PhaseTwoBank.Text = Val(PhaseTwoBank.Text) + 5
            End If
        End If
    End Sub

    'End of session code. 
    Private Sub debriefLoad_Click(sender As Object, e As EventArgs) Handles debriefLoad.Click
        Dim saveto As String
        saveto = Environment.GetFolderPath(Environment.SpecialFolder.Desktop)
        csvTextBox.Text = "Three Throughout" + "," + csvTextBox.Text + "," + "Target SR+ Times" + "," + TargetTimeDeliver.Text + "," + "ALT 1 SR+ Times" + "," + Alt1TimeDeliver.Text + "," + "ALT 2 SR+ Times" + "," + Alt2TimeDeliver.Text + "," + "ALT 3 SR+ Times" + "," + Alt3TimeDeliver.Text + "," + "ALT 4 SR+ Times" + "," + Alt4TimeDeliver.Text + "," + "2 Minute Target Data" + "," + r1sess1.Text + "," + r1sess2.Text + "," + r1sess3.Text + "," + r1sess4.Text + "," + r1sess5.Text + "," + r1sess6.Text + "," + r1sess7.Text + "," + r1sess8.Text + "," + r1sess9.Text + "," + r1sess10.Text + "," + r1sess11.Text + "," + r1sess12.Text + "," + r1sess13.Text + "," + r1sess14.Text + "," + r1sess15.Text + "," + r1sess16.Text + "," + r1sess17.Text + "," + r1sess18.Text + "," + r1sess19.Text + "," + r1sess20.Text + "," + r1sess21.Text + "," + r1sess22.Text + "," + r1sess23.Text + "," + r1sess24.Text + "," + "," + "2 Minute Data ALT 1" + "," + r2sess1.Text + "," + r2sess2.Text + "," + r2sess3.Text + "," + r2sess4.Text + "," + r2sess5.Text + "," + r2sess6.Text + "," + r2sess7.Text + "," + r2sess8.Text + "," + r2sess9.Text + "," + r2sess10.Text + "," + r2sess11.Text + "," + r2sess12.Text + "," + r2sess13.Text + "," + r2sess14.Text + "," + r2sess15.Text + "," + r2sess16.Text + "," + r2sess17.Text + "," + r2sess18.Text + "," + r2sess19.Text + "," + r2sess20.Text + "," + r2sess21.Text + "," + r2sess22.Text + "," + r2sess23.Text + "," + r2sess24.Text + "," + "," + "2 Minute Data ALT 2" + "," + r4sess1.Text + "," + r4sess2.Text + "," + r4sess3.Text + "," + r4sess4.Text + "," + r4sess5.Text + "," + r4sess6.Text + "," + r4sess7.Text + "," + r4sess8.Text + "," + r4sess9.Text + "," + r4sess10.Text + "," + r4sess11.Text + "," + r4sess12.Text + "," + r4sess13.Text + "," + r4sess14.Text + "," + r4sess15.Text + "," + r4sess16.Text + "," + r4sess17.Text + "," + r4sess18.Text + "," + r4sess19.Text + "," + r4sess20.Text + "," + r4sess21.Text + "," + r4sess22.Text + "," + r4sess23.Text + "," + r4sess24.Text + "," + "," + "2 Minute Data ALT 3" + "," + r5sess1.Text + "," + r5sess2.Text + "," + r5sess3.Text + "," + r5sess4.Text + "," + r5sess5.Text + "," + r5sess6.Text + "," + r5sess7.Text + "," + r5sess8.Text + "," + r5sess9.Text + "," + r5sess10.Text + "," + r5sess11.Text + "," + r5sess12.Text + "," + r5sess13.Text + "," + r5sess14.Text + "," + r5sess15.Text + "," + r5sess16.Text + "," + r5sess17.Text + "," + r5sess18.Text + "," + r5sess19.Text + "," + r5sess20.Text + "," + r5sess21.Text + "," + r5sess22.Text + "," + r5sess23.Text + "," + r5sess24.Text + "," + "," + "2 Minute Data ALT 4" + "," + r6sess1.Text + "," + r6sess2.Text + "," + r6sess3.Text + "," + r6sess4.Text + "," + r6sess5.Text + "," + r6sess6.Text + "," + r6sess7.Text + "," + r6sess8.Text + "," + r6sess9.Text + "," + r6sess10.Text + "," + r6sess11.Text + "," + r6sess12.Text + "," + r6sess13.Text + "," + r6sess14.Text + "," + r6sess15.Text + "," + r6sess16.Text + "," + r6sess17.Text + "," + r6sess18.Text + "," + r6sess19.Text + "," + r6sess20.Text + "," + r6sess21.Text + "," + r6sess22.Text + "," + r6sess23.Text + "," + r6sess24.Text + "," + "," + "2 Minute Control Data" + "," + r3sess1.Text + "," + r3sess2.Text + "," + r3sess3.Text + "," + r3sess4.Text + "," + r3sess5.Text + "," + r3sess6.Text + "," + r3sess7.Text + "," + r3sess8.Text + "," + r3sess9.Text + "," + r3sess10.Text + "," + r3sess11.Text + "," + r3sess12.Text + "," + r3sess13.Text + "," + r3sess14.Text + "," + r3sess15.Text + "," + r3sess16.Text + "," + r3sess17.Text + "," + r3sess18.Text + "," + r3sess19.Text + "," + r3sess20.Text + "," + r3sess21.Text + "," + r3sess22.Text + "," + r3sess23.Text + "," + r3sess24.Text + "," + "," + "10-sec Data ALT 1" + "," + r1i01.Text + "," + r1i02.Text + "," + r1i03.Text + "," + r1i04.Text + "," + r1i05.Text + "," + r1i06.Text + "," + r1i07.Text + "," + r1i08.Text + "," + r1i09.Text + "," + r1i10.Text + "," + r1i11.Text + "," + r1i12.Text + "," + r1i13.Text + "," + r1i14.Text + "," + r1i15.Text + "," + r1i16.Text + "," + r1i17.Text + "," + r1i18.Text + "," + r1i19.Text + "," + r1i20.Text + "," + r1i21.Text + "," + r1i22.Text + "," + r1i23.Text + "," + r1i24.Text + "," + r1i25.Text + "," + r1i26.Text + "," + r1i27.Text + "," + r1i28.Text + "," + r1i29.Text + "," + r1i30.Text + "," + r1i31.Text + "," + r1i32.Text + "," + r1i33.Text + "," + r1i34.Text + "," + r1i35.Text + "," + r1i36.Text + "," + r1i37.Text + "," + r1i38.Text + "," + r1i39.Text + "," + r1i40.Text + "," + r1i41.Text + "," + r1i42.Text + "," + r1i43.Text + "," + r1i44.Text + "," + r1i45.Text + "," + r1i46.Text + "," + r1i47.Text + "," + r1i48.Text + "," + r1i49.Text + "," + r1i50.Text + "," + r1i51.Text + "," + r1i52.Text + "," + r1i53.Text + "," + r1i54.Text + "," + r1i55.Text + "," + r1i56.Text + "," + r1i57.Text + "," + r1i58.Text + "," + r1i59.Text + "," + r1i60.Text + "," + r1i61.Text + "," + r1i62.Text + "," + r1i63.Text + "," + r1i64.Text + "," + r1i65.Text + "," + r1i66.Text + "," + r1i67.Text + "," + r1i68.Text + "," + r1i69.Text + "," + r1i70.Text + "," + r1i71.Text + "," + r1i72.Text + "," + r1i73.Text + "," + r1i74.Text + "," + r1i75.Text + "," + r1i76.Text + "," + r1i77.Text + "," + r1i78.Text + "," + r1i79.Text + "," + r1i80.Text + "," + r1i81.Text + "," + r1i82.Text + "," + r1i83.Text + "," + r1i84.Text + "," + r1i85.Text + "," + r1i86.Text + "," + r1i87.Text + "," + r1i88.Text + "," + r1i89.Text + "," + r1i90.Text + "," + r1i91.Text + "," + r1i92.Text + "," + r1i93.Text + "," + r1i94.Text + "," + r1i95.Text + "," + r1i96.Text + "," + r1i97.Text + "," + r1i98.Text + "," + r1i99.Text + "," + r1i100.Text + "," + r1i101.Text + "," + r1i102.Text + "," + r1i103.Text + "," + r1i104.Text + "," + r1i105.Text + "," + r1i106.Text + "," + r1i107.Text + "," + r1i108.Text + "," + r1i109.Text + "," + r1i110.Text + "," + r1i111.Text + "," + r1i112.Text + "," + r1i113.Text + "," + r1i114.Text + "," + r1i115.Text + "," + r1i116.Text + "," + r1i117.Text + "," + r1i118.Text + "," + r1i119.Text + "," + r1i120.Text + "," + r1i121.Text + "," + r1i122.Text + "," + r1i123.Text + "," + r1i124.Text + "," + r1i125.Text + "," + r1i126.Text + "," + r1i127.Text + "," + r1i128.Text + "," + r1i129.Text + "," + r1i130.Text + "," + r1i131.Text + "," + r1i132.Text + "," + r1i133.Text + "," + r1i134.Text + "," + r1i135.Text + "," + r1i136.Text + "," + r1i137.Text + "," + r1i138.Text + "," + r1i139.Text + "," + r1i140.Text + "," + r1i141.Text + "," + r1i142.Text + "," + r1i143.Text + "," + r1i144.Text + "," + r1i145.Text + "," + r1i146.Text + "," + r1i147.Text + "," + r1i148.Text + "," + r1i149.Text + "," + r1i150.Text + "," + r1i151.Text + "," + r1i152.Text + "," + r1i153.Text + "," + r1i154.Text + "," + r1i155.Text + "," + r1i156.Text + "," + r1i157.Text + "," + r1i158.Text + "," + r1i159.Text + "," + r1i160.Text + "," + r1i161.Text + "," + r1i162.Text + "," + r1i163.Text + "," + r1i164.Text + "," + r1i165.Text + "," + r1i166.Text + "," + r1i167.Text + "," + r1i168.Text + "," + r1i169.Text + "," + r1i170.Text + "," + r1i171.Text + "," + r1i172.Text + "," + r1i173.Text + "," + r1i174.Text + "," + r1i175.Text + "," + r1i176.Text + "," + r1i177.Text + "," + r1i178.Text + "," + r1i179.Text + "," + r1i180.Text + "," + r1i181.Text + "," + r1i182.Text + "," + r1i183.Text + "," + r1i184.Text + "," + r1i185.Text + "," + r1i186.Text + "," + r1i187.Text + "," + r1i188.Text + "," + r1i189.Text + "," + r1i190.Text + "," + r1i191.Text + "," + r1i192.Text + "," + r1i193.Text + "," + r1i194.Text + "," + r1i195.Text + "," + r1i196.Text + "," + r1i197.Text + "," + r1i198.Text + "," + r1i199.Text + "," + r1i200.Text + "," + r1i201.Text + "," + r1i202.Text + "," + r1i203.Text + "," + r1i204.Text + "," + r1i205.Text + "," + r1i206.Text + "," + r1i207.Text + "," + r1i208.Text + "," + r1i209.Text + "," + r1i210.Text + "," + r1i211.Text + "," + r1i212.Text + "," + r1i213.Text + "," + r1i214.Text + "," + r1i215.Text + "," + r1i216.Text + "," + r1i217.Text + "," + r1i218.Text + "," + r1i219.Text + "," + r1i220.Text + "," + r1i221.Text + "," + r1i222.Text + "," + r1i223.Text + "," + r1i224.Text + "," + r1i225.Text + "," + r1i226.Text + "," + r1i227.Text + "," + r1i228.Text + "," + r1i229.Text + "," +  r1i230.Text + "," + r1i231.Text + "," + r1i232.Text + "," + r1i233.Text + "," + r1i234.Text + "," + r1i235.Text + "," + r1i236.Text + "," + r1i237.Text + "," + r1i238.Text + "," + r1i239.Text + "," + r1i240.Text + "," + r1i241.Text + "," + r1i242.Text + "," + r1i243.Text + "," + r1i244.Text + "," + r1i245.Text + "," + r1i246.Text + "," + r1i247.Text + "," + r1i248.Text + "," + r1i249.Text + "," + r1i250.Text + "," + r1i251.Text + "," + r1i252.Text + "," + r1i253.Text + "," + r1i254.Text + "," + r1i255.Text + "," + r1i256.Text + "," + r1i257.Text + "," + r1i258.Text + "," + r1i259.Text + "," + r1i260.Text + "," + r1i261.Text + "," + r1i262.Text + "," + r1i263.Text + "," + r1i264.Text + "," + r1i265.Text + "," + r1i266.Text + "," + r1i267.Text + "," + r1i268.Text + "," + r1i269.Text + "," + r1i270.Text + "," + r1i271.Text + "," + r1i272.Text + "," + r1i273.Text + "," + r1i274.Text + "," + r1i275.Text + "," + r1i276.Text + "," + r1i277.Text + "," + r1i278.Text + "," + r1i279.Text + "," + r1i280.Text + "," + r1i281.Text + "," + r1i282.Text + "," + r1i283.Text + "," + r1i284.Text + "," + r1i285.Text + "," + r1i286.Text + "," + r1i287.Text + "," + r1i288.Text + "," + "," + "10-sec Data ALT 2" + "," + r2i01.Text + "," + r2i02.Text + "," + r2i03.Text + "," + r2i04.Text + "," + r2i05.Text + "," + r2i06.Text + "," + r2i07.Text + "," + r2i08.Text + "," + r2i09.Text + "," +  r2i10.Text + "," + r2i11.Text + "," + r2i12.Text + "," + r2i13.Text + "," + r2i14.Text + "," + r2i15.Text + "," + r2i16.Text + "," + r2i17.Text + "," + r2i18.Text + "," + r2i19.Text + "," + r2i20.Text + "," + r2i21.Text + "," + r2i22.Text + "," + r2i23.Text + "," + r2i24.Text + "," + r2i25.Text + "," + r2i26.Text + "," + r2i27.Text + "," + r2i28.Text + "," + r2i29.Text + "," + r2i30.Text + "," + r2i31.Text + "," + r2i32.Text + "," + r2i33.Text + "," + r2i34.Text + "," + r2i35.Text + "," + r2i36.Text + "," + r2i37.Text + "," + r2i38.Text + "," + r2i39.Text + "," + r2i40.Text + "," + r2i41.Text + "," + r2i42.Text + "," + r2i43.Text + "," + r2i44.Text + "," + r2i45.Text + "," + r2i46.Text + "," + r2i47.Text + "," + r2i48.Text + "," + r2i49.Text + "," + r2i50.Text + "," + r2i51.Text + "," + r2i52.Text + "," + r2i53.Text + "," + r2i54.Text + "," + r2i55.Text + "," + r2i56.Text + "," + r2i57.Text + "," + r2i58.Text + "," + r2i59.Text + "," + r2i60.Text + "," + r2i61.Text + "," + r2i62.Text + "," + r2i63.Text + "," + r2i64.Text + "," + r2i65.Text + "," + r2i66.Text + "," + r2i67.Text + "," + r2i68.Text + "," + r2i69.Text + "," + r2i70.Text + "," + r2i71.Text + "," + r2i72.Text + "," + r2i73.Text + "," + r2i74.Text + "," + r2i75.Text + "," + r2i76.Text + "," + r2i77.Text + "," + r2i78.Text + "," + r2i79.Text + "," + r2i80.Text + "," + r2i81.Text + "," + r2i82.Text + "," + r2i83.Text + "," + r2i84.Text + "," + r2i85.Text + "," + r2i86.Text + "," + r2i87.Text + "," + r2i88.Text + "," + r2i89.Text + "," + r2i90.Text + "," + r2i91.Text + "," + r2i92.Text + "," + r2i93.Text + "," + r2i94.Text + "," + r2i95.Text + "," + r2i96.Text + "," + r2i97.Text + "," + r2i98.Text + "," + r2i99.Text + "," + r2i100.Text + "," + r2i101.Text + "," + r2i102.Text + "," + r2i103.Text + "," + r2i104.Text + "," + r2i105.Text + "," + r2i106.Text + "," + r2i107.Text + "," + r2i108.Text + "," + r2i109.Text + "," + r2i110.Text + "," + r2i111.Text + "," + r2i112.Text + "," + r2i113.Text + "," + r2i114.Text + "," + r2i115.Text + "," + r2i116.Text + "," + r2i117.Text + "," + r2i118.Text + "," + r2i119.Text + "," + r2i120.Text + "," + r2i121.Text + "," + r2i122.Text + "," + r2i123.Text + "," + r2i124.Text + "," + r2i125.Text + "," + r2i126.Text + "," + r2i127.Text + "," + r2i128.Text + "," + r2i129.Text + "," + r2i130.Text + "," + r2i131.Text + "," + r2i132.Text + "," + r2i133.Text + "," + r2i134.Text + "," + r2i135.Text + "," + r2i136.Text + "," + r2i137.Text + "," + r2i138.Text + "," + r2i139.Text + "," + r2i140.Text + "," + r2i141.Text + "," + r2i142.Text + "," + r2i143.Text + "," + r2i144.Text + "," + r2i145.Text + "," + r2i146.Text + "," + r2i147.Text + "," + r2i148.Text + "," + r2i149.Text + "," + r2i150.Text + "," + r2i151.Text + "," + r2i152.Text + "," + r2i153.Text + "," + r2i154.Text + "," + r2i155.Text + "," + r2i156.Text + "," + r2i157.Text + "," + r2i158.Text + "," + r2i159.Text + "," + r2i160.Text + "," + r2i161.Text + "," + r2i162.Text + "," + r2i163.Text + "," + r2i164.Text + "," + r2i165.Text + "," + r2i166.Text + "," + r2i167.Text + "," + r2i168.Text + "," + r2i169.Text + "," + r2i170.Text + "," + r2i171.Text + "," + r2i172.Text + "," + r2i173.Text + "," + r2i174.Text + "," + r2i175.Text + "," + r2i176.Text + "," + r2i177.Text + "," + r2i178.Text + "," + r2i179.Text + "," + r2i180.Text + "," + r2i181.Text + "," + r2i182.Text + "," + r2i183.Text + "," + r2i184.Text + "," + r2i185.Text + "," + r2i186.Text + "," + r2i187.Text + "," + r2i188.Text + "," + r2i189.Text + "," + r2i190.Text + "," + r2i191.Text + "," + r2i192.Text + "," + r2i193.Text + "," + r2i194.Text + "," + r2i195.Text + "," + r2i196.Text + "," + r2i197.Text + "," + r2i198.Text + "," + r2i199.Text + "," + r2i200.Text + "," + r2i201.Text + "," + r2i202.Text + "," + r2i203.Text + "," + r2i204.Text + "," + r2i205.Text + "," + r2i206.Text + "," + r2i207.Text + "," + r2i208.Text + "," + r2i209.Text + "," + r2i210.Text + "," + r2i211.Text + "," + r2i212.Text + "," + r2i213.Text + "," + r2i214.Text + "," + r2i215.Text + "," + r2i216.Text + "," + r2i217.Text + "," + r2i218.Text + "," + r2i219.Text + "," + r2i220.Text + "," + r2i221.Text + "," + r2i222.Text + "," + r2i223.Text + "," + r2i224.Text + "," + r2i225.Text + "," + r2i226.Text + "," + r2i227.Text + "," + r2i228.Text + "," + r2i229.Text + "," + r2i230.Text + "," + r2i231.Text + "," + r2i232.Text + "," + r2i233.Text + "," + r2i234.Text + "," + r2i235.Text + "," + r2i236.Text + "," + r2i237.Text + "," + r2i238.Text + "," + r2i239.Text + "," + r2i240.Text + "," + r2i241.Text + "," + r2i242.Text + "," + r2i243.Text + "," + r2i244.Text + "," + r2i245.Text + "," + r2i246.Text + "," + r2i247.Text + "," + r2i248.Text + "," + r2i249.Text + "," + r2i250.Text + "," + r2i251.Text + "," + r2i252.Text + "," + r2i253.Text + "," + r2i254.Text + "," + r2i255.Text + "," + r2i256.Text + "," + r2i257.Text + "," + r2i258.Text + "," + r2i259.Text + "," + r2i260.Text + "," + r2i261.Text + "," + r2i262.Text + "," + r2i263.Text + "," + r2i264.Text + "," + r2i265.Text + "," + r2i266.Text + "," + r2i267.Text + "," + r2i268.Text + "," + r2i269.Text + "," + r2i270.Text + "," + r2i271.Text + "," + r2i272.Text + "," + r2i273.Text + "," + r2i274.Text + "," + r2i275.Text + "," + r2i276.Text + "," + r2i277.Text + "," + r2i278.Text + "," + r2i279.Text + "," + r2i280.Text + "," + r2i281.Text + "," + r2i282.Text + "," + r2i283.Text + "," + r2i284.Text + "," + r2i285.Text + "," + r2i286.Text + "," + r2i287.Text + "," + r2i288.Text + "," + "," + "10-sec Data ALT 3" + "," + r3i01.Text + "," + r3i02.Text + "," + r3i03.Text + "," + r3i04.Text + "," + r3i05.Text + "," + r3i06.Text + "," + r3i07.Text + "," + r3i08.Text + "," + r3i09.Text + "," + r3i10.Text + "," + r3i11.Text + "," + r3i12.Text + "," + r3i13.Text + "," + r3i14.Text + "," + r3i15.Text + "," + r3i16.Text + "," + r3i17.Text + "," + r3i18.Text + "," + r3i19.Text + "," + r3i20.Text + "," + r3i21.Text + "," + r3i22.Text + "," + r3i23.Text + "," + r3i24.Text + "," + r3i25.Text + "," + r3i26.Text + "," + r3i27.Text + "," + r3i28.Text + "," + r3i29.Text + "," + r3i30.Text + "," + r3i31.Text + "," + r3i32.Text + "," + r3i33.Text + "," + r3i34.Text + "," + r3i35.Text + "," + r3i36.Text + "," + r3i37.Text + "," + r3i38.Text + "," + r3i39.Text + "," + r3i40.Text + "," + r3i41.Text + "," + r3i42.Text + "," + r3i43.Text + "," + r3i44.Text + "," + r3i45.Text + "," + r3i46.Text + "," + r3i47.Text + "," + r3i48.Text + "," + r3i49.Text + "," + r3i50.Text + "," + r3i51.Text + "," + r3i52.Text + "," + r3i53.Text + "," + r3i54.Text + "," + r3i55.Text + "," + r3i56.Text + "," + r3i57.Text + "," + r3i58.Text + "," + r3i59.Text + "," + r3i60.Text + "," + r3i61.Text + "," + r3i62.Text + "," + r3i63.Text + "," + r3i64.Text + "," + r3i65.Text + "," + r3i66.Text + "," + r3i67.Text + "," + r3i68.Text + "," + r3i69.Text + "," + r3i70.Text + "," + r3i71.Text + "," + r3i72.Text + "," + r3i73.Text + "," + r3i74.Text + "," + r3i75.Text + "," + r3i76.Text + "," + r3i77.Text + "," + r3i78.Text + "," + r3i79.Text + "," + r3i80.Text + "," + r3i81.Text + "," + r3i82.Text + "," + r3i83.Text + "," + r3i84.Text + "," + r3i85.Text + "," + r3i86.Text + "," + r3i87.Text + "," + r3i88.Text + "," + r3i89.Text + "," + r3i90.Text + "," + r3i91.Text + "," + r3i92.Text + "," + r3i93.Text + "," + r3i94.Text + "," + r3i95.Text + "," + r3i96.Text + "," + r3i97.Text + "," + r3i98.Text + "," + r3i99.Text + "," + r3i100.Text + "," + r3i101.Text + "," + r3i102.Text + "," + r3i103.Text + "," + r3i104.Text + "," + r3i105.Text + "," + r3i106.Text + "," + r3i107.Text + "," + r3i108.Text + "," + r3i109.Text + "," + r3i110.Text + "," + r3i111.Text + "," + r3i112.Text + "," + r3i113.Text + "," + r3i114.Text + "," + r3i115.Text + "," + r3i116.Text + "," + r3i117.Text + "," + r3i118.Text + "," + r3i119.Text + "," + r3i120.Text + "," + r3i121.Text + "," + r3i122.Text + "," + r3i123.Text + "," + r3i124.Text + "," + r3i125.Text + "," + r3i126.Text + "," + r3i127.Text + "," + r3i128.Text + "," + r3i129.Text + "," + r3i130.Text + "," + r3i131.Text + "," + r3i132.Text + "," + r3i133.Text + "," + r3i134.Text + "," + r3i135.Text + "," + r3i136.Text + "," + r3i137.Text + "," + r3i138.Text + "," + r3i139.Text + "," + r3i140.Text + "," + r3i141.Text + "," + r3i142.Text + "," + r3i143.Text + "," + r3i144.Text + "," + r3i145.Text + "," + r3i146.Text + "," + r3i147.Text + "," + r3i148.Text + "," + r3i149.Text + "," + r3i150.Text + "," + r3i151.Text + "," + r3i152.Text + "," + r3i153.Text + "," + r3i154.Text + "," + r3i155.Text + "," + r3i156.Text + "," + r3i157.Text + "," + r3i158.Text + "," + r3i159.Text + "," + r3i160.Text + "," + r3i161.Text + "," + r3i162.Text + "," + r3i163.Text + "," + r3i164.Text + "," + r3i165.Text + "," + r3i166.Text + "," + r3i167.Text + "," + r3i168.Text + "," + r3i169.Text + "," + r3i170.Text + "," + r3i171.Text + "," + r3i172.Text + "," + r3i173.Text + "," + r3i174.Text + "," + r3i175.Text + "," + r3i176.Text + "," + r3i177.Text + "," + r3i178.Text + "," + r3i179.Text + "," + r3i180.Text + "," + r3i181.Text + "," + r3i182.Text + "," + r3i183.Text + "," + r3i184.Text + "," + r3i185.Text + "," + r3i186.Text + "," + r3i187.Text + "," + r3i188.Text + "," + r3i189.Text + "," + r3i190.Text + "," + r3i191.Text + "," + r3i192.Text + "," + r3i193.Text + "," + r3i194.Text + "," + r3i195.Text + "," + r3i196.Text + "," + r3i197.Text + "," + r3i198.Text + "," + r3i199.Text + "," + r3i200.Text + "," + r3i201.Text + "," + r3i202.Text + "," + r3i203.Text + "," + r3i204.Text + "," + r3i205.Text + "," + r3i206.Text + "," + r3i207.Text + "," + r3i208.Text + "," + r3i209.Text + "," + r3i210.Text + "," + r3i211.Text + "," + r3i212.Text + "," + r3i213.Text + "," + r3i214.Text + "," + r3i215.Text + "," + r3i216.Text + "," + r3i217.Text + "," + r3i218.Text + "," + r3i219.Text + "," + r3i220.Text + "," + r3i221.Text + "," + r3i222.Text + "," + r3i223.Text + "," + r3i224.Text + "," + r3i225.Text + "," + r3i226.Text + "," + r3i227.Text + "," + r3i228.Text + "," + r3i229.Text + "," + r3i230.Text + "," + r3i231.Text + "," + r3i232.Text + "," + r3i233.Text + "," + r3i234.Text + "," + r3i235.Text + "," + r3i236.Text + "," + r3i237.Text + "," + r3i238.Text + "," + r3i239.Text + "," + r3i240.Text + "," + r3i241.Text + "," + r3i242.Text + "," + r3i243.Text + "," + r3i244.Text + "," + r3i245.Text + "," + r3i246.Text + "," + r3i247.Text + "," + r3i248.Text + "," + r3i249.Text + "," + r3i250.Text + "," + r3i251.Text + "," + r3i252.Text + "," + r3i253.Text + "," + r3i254.Text + "," + r3i255.Text + "," + r3i256.Text + "," + r3i257.Text + "," + r3i258.Text + "," + r3i259.Text + "," + r3i260.Text + "," + r3i261.Text + "," + r3i262.Text + "," + r3i263.Text + "," + r3i264.Text + "," + r3i265.Text + "," + r3i266.Text + "," + r3i267.Text + "," + r3i268.Text + "," + r3i269.Text + "," + r3i270.Text + "," + r3i271.Text + "," + r3i272.Text + "," + r3i273.Text + "," + r3i274.Text + "," + r3i275.Text + "," + r3i276.Text + "," + r3i277.Text + "," + r3i278.Text + "," + r3i279.Text + "," + r3i280.Text + "," + r3i281.Text + "," + r3i282.Text + "," + r3i283.Text + "," + r3i284.Text + "," + r3i285.Text + "," + r3i286.Text + "," + r3i287.Text + "," + r3i288.Text + "," + "10-sec Data ALT 4" + "," + r4i01.Text + "," + r4i02.Text + "," + r4i03.Text + "," + r4i04.Text + "," + r4i05.Text + "," + r4i06.Text + "," + r4i07.Text + "," + r4i08.Text + "," + r4i09.Text + "," + r4i10.Text + "," + r4i11.Text + "," + r4i12.Text + "," + r4i13.Text + "," + r4i14.Text + "," + r4i15.Text + "," + r4i16.Text + "," + r4i17.Text + "," + r4i18.Text + "," + r4i19.Text + "," + r4i20.Text + "," + r4i21.Text + "," + r4i22.Text + "," + r4i23.Text + "," + r4i24.Text + "," + r4i25.Text + "," + r4i26.Text + "," + r4i27.Text + "," + r4i28.Text + "," + r4i29.Text + "," + r4i30.Text + "," + r4i31.Text + "," + r4i32.Text + "," + r4i33.Text + "," + r4i34.Text + "," + r4i35.Text + "," + r4i36.Text + "," + r4i37.Text + "," + r4i38.Text + "," + r4i39.Text + "," + r4i40.Text + "," + r4i41.Text + "," + r4i42.Text + "," + r4i43.Text + "," + r4i44.Text + "," + r4i45.Text + "," + r4i46.Text + "," + r4i47.Text + "," + r4i48.Text + "," + r4i49.Text + "," + r4i50.Text + "," + r4i51.Text + "," + r4i52.Text + "," + r4i53.Text + "," + r4i54.Text + "," + r4i55.Text + "," + r4i56.Text + "," + r4i57.Text + "," + r4i58.Text + "," + r4i59.Text + "," + r4i60.Text + "," + r4i61.Text + "," + r4i62.Text + "," + r4i63.Text + "," + r4i64.Text + "," + r4i65.Text + "," + r4i66.Text + "," + r4i67.Text + "," + r4i68.Text + "," + r4i69.Text + "," + r4i70.Text + "," + r4i71.Text + "," + r4i72.Text + "," + r4i73.Text + "," + r4i74.Text + "," + r4i75.Text + "," + r4i76.Text + "," + r4i77.Text + "," + r4i78.Text + "," + r4i79.Text + "," + r4i80.Text + "," + r4i81.Text + "," + r4i82.Text + "," + r4i83.Text + "," + r4i84.Text + "," + r4i85.Text + "," + r4i86.Text + "," + r4i87.Text + "," + r4i88.Text + "," + r4i89.Text + "," + r4i90.Text + "," + r4i91.Text + "," + r4i92.Text + "," + r4i93.Text + "," + r4i94.Text + "," + r4i95.Text + "," + r4i96.Text + "," + r4i97.Text + "," + r4i98.Text + "," + r4i99.Text + "," + r4i100.Text + "," + r4i101.Text + "," + r4i102.Text + "," + r4i103.Text + "," + r4i104.Text + "," + r4i105.Text + "," + r4i106.Text + "," + r4i107.Text + "," + r4i108.Text + "," + r4i109.Text + "," + r4i110.Text + "," + r4i111.Text + "," + r4i112.Text + "," + r4i113.Text + "," + r4i114.Text + "," + r4i115.Text + "," + r4i116.Text + "," + r4i117.Text + "," + r4i118.Text + "," + r4i119.Text + "," + r4i120.Text + "," + r4i121.Text + "," + r4i122.Text + "," + r4i123.Text + "," + r4i124.Text + "," + r4i125.Text + "," + r4i126.Text + "," + r4i127.Text + "," + r4i128.Text + "," + r4i129.Text + "," + r4i130.Text + "," + r4i131.Text + "," + r4i132.Text + "," + r4i133.Text + "," + r4i134.Text + "," + r4i135.Text + "," + r4i136.Text + "," + r4i137.Text + "," + r4i138.Text + "," + r4i139.Text + "," + r4i140.Text + "," + r4i141.Text + "," + r4i142.Text + "," + r4i143.Text + "," + r4i144.Text + "," + r4i145.Text + "," + r4i146.Text + "," + r4i147.Text + "," + r4i148.Text + "," + r4i149.Text + "," + r4i150.Text + "," + r4i151.Text + "," + r4i152.Text + "," + r4i153.Text + "," + r4i154.Text + "," + r4i155.Text + "," + r4i156.Text + "," + r4i157.Text + "," + r4i158.Text + "," + r4i159.Text + "," + r4i160.Text + "," + r4i161.Text + "," + r4i162.Text + "," + r4i163.Text + "," + r4i164.Text + "," + r4i165.Text + "," + r4i166.Text + "," + r4i167.Text + "," + r4i168.Text + "," + r4i169.Text + "," + r4i170.Text + "," + r4i171.Text + "," + r4i172.Text + "," + r4i173.Text + "," + r4i174.Text + "," + r4i175.Text + "," + r4i176.Text + "," + r4i177.Text + "," + r4i178.Text + "," + r4i179.Text + "," + r4i180.Text + "," + r4i181.Text + "," + r4i182.Text + "," + r4i183.Text + "," + r4i184.Text + "," + r4i185.Text + "," + r4i186.Text + "," + r4i187.Text + "," + r4i188.Text + "," + r4i189.Text + "," + r4i190.Text + "," + r4i191.Text + "," + r4i192.Text + "," + r4i193.Text + "," + r4i194.Text + "," + r4i195.Text + "," + r4i196.Text + "," + r4i197.Text + "," + r4i198.Text + "," + r4i199.Text + "," + r4i200.Text + "," + r4i201.Text + "," + r4i202.Text + "," + r4i203.Text + "," + r4i204.Text + "," + r4i205.Text + "," + r4i206.Text + "," + r4i207.Text + "," + r4i208.Text + "," + r4i209.Text + "," + r4i210.Text + "," + r4i211.Text + "," + r4i212.Text + "," + r4i213.Text + "," + r4i214.Text + "," + r4i215.Text + "," + r4i216.Text + "," + r4i217.Text + "," + r4i218.Text + "," + r4i219.Text + "," + r4i220.Text + "," + r4i221.Text + "," + r4i222.Text + "," + r4i223.Text + "," + r4i224.Text + "," + r4i225.Text + "," + r4i226.Text + "," + r4i227.Text + "," + r4i228.Text + "," + r4i229.Text + "," + r4i230.Text + "," + r4i231.Text + "," + r4i232.Text + "," + r4i233.Text + "," + r4i234.Text + "," + r4i235.Text + "," + r4i236.Text + "," + r4i237.Text + "," + r4i238.Text + "," + r4i239.Text + "," + r4i240.Text + "," + r4i241.Text + "," + r4i242.Text + "," + r4i243.Text + "," + r4i244.Text + "," + r4i245.Text + "," + r4i246.Text + "," + r4i247.Text + "," + r4i248.Text + "," + r4i249.Text + "," + r4i250.Text + "," + r4i251.Text + "," + r4i252.Text + "," + r4i253.Text + "," + r4i254.Text + "," + r4i255.Text + "," + r4i256.Text + "," + r4i257.Text + "," + r4i258.Text + "," + r4i259.Text + "," + r4i260.Text + "," + r4i261.Text + "," + r4i262.Text + "," + r4i263.Text + "," + r4i264.Text + "," + r4i265.Text + "," + r4i266.Text + "," + r4i267.Text + "," + r4i268.Text + "," + r4i269.Text + "," + r4i270.Text + "," + r4i271.Text + "," + r4i272.Text + "," + r4i273.Text + "," + r4i274.Text + "," + r4i275.Text + "," + r4i276.Text + "," + r4i277.Text + "," + r4i278.Text + "," + r4i279.Text + "," + r4i280.Text + "," + r4i281.Text + "," + r4i282.Text + "," + r4i283.Text + "," + r4i284.Text + "," + r4i285.Text + "," + r4i286.Text + "," + r4i287.Text + "," + r4i288.Text + "," + "10-sec Data ALT 5" + "," + r5i01.Text + "," + r5i02.Text + "," + r5i03.Text + "," + r5i04.Text + "," + r5i05.Text + "," + r5i06.Text + "," + r5i07.Text + "," + r5i08.Text + "," + r5i09.Text + "," + r5i10.Text + "," + r5i11.Text + "," + r5i12.Text + "," + r5i13.Text + "," + r5i14.Text + "," + r5i15.Text + "," + r5i16.Text + "," + r5i17.Text + "," + r5i18.Text + "," + r5i19.Text + "," + r5i20.Text + "," + r5i21.Text + "," + r5i22.Text + "," + r5i23.Text + "," + r5i24.Text + "," + r5i25.Text + "," + r5i26.Text + "," + r5i27.Text + "," + r5i28.Text + "," + r5i29.Text + "," + r5i30.Text + "," + r5i31.Text + "," + r5i32.Text + "," + r5i33.Text + "," + r5i34.Text + "," + r5i35.Text + "," + r5i36.Text + "," + r5i37.Text + "," + r5i38.Text + "," + r5i39.Text + "," + r5i40.Text + "," + r5i41.Text + "," + r5i42.Text + "," + r5i43.Text + "," + r5i44.Text + "," + r5i45.Text + "," + r5i46.Text + "," + r5i47.Text + "," + r5i48.Text + "," + r5i49.Text + "," + r5i50.Text + "," + r5i51.Text + "," + r5i52.Text + "," + r5i53.Text + "," + r5i54.Text + "," + r5i55.Text + "," + r5i56.Text + "," + r5i57.Text + "," + r5i58.Text + "," + r5i59.Text + "," + r5i60.Text + "," + r5i61.Text + "," + r5i62.Text + "," + r5i63.Text + "," + r5i64.Text + "," + r5i65.Text + "," + r5i66.Text + "," + r5i67.Text + "," + r5i68.Text + "," + r5i69.Text + "," + r5i70.Text + "," + r5i71.Text + "," + r5i72.Text + "," + r5i73.Text + "," + r5i74.Text + "," + r5i75.Text + "," + r5i76.Text + "," + r5i77.Text + "," + r5i78.Text + "," + r5i79.Text + "," + r5i80.Text + "," + r5i81.Text + "," + r5i82.Text + "," + r5i83.Text + "," + r5i84.Text + "," + r5i85.Text + "," + r5i86.Text + "," + r5i87.Text + "," + r5i88.Text + "," + r5i89.Text + "," + r5i90.Text + "," + r5i91.Text + "," + r5i92.Text + "," + r5i93.Text + "," + r5i94.Text + "," + r5i95.Text + "," + r5i96.Text + "," + r5i97.Text + "," + r5i98.Text + "," + r5i99.Text + "," + r5i100.Text + "," + r5i101.Text + "," + r5i102.Text + "," + r5i103.Text + "," + r5i104.Text + "," + r5i105.Text + "," + r5i106.Text + "," + r5i107.Text + "," + r5i108.Text + "," + r5i109.Text + "," + r5i110.Text + "," + r5i111.Text + "," + r5i112.Text + "," + r5i113.Text + "," + r5i114.Text + "," + r5i115.Text + "," + r5i116.Text + "," + r5i117.Text + "," + r5i118.Text + "," + r5i119.Text + "," + r5i120.Text + "," + r5i121.Text + "," + r5i122.Text + "," + r5i123.Text + "," + r5i124.Text + "," + r5i125.Text + "," + r5i126.Text + "," + r5i127.Text + "," + r5i128.Text + "," + r5i129.Text + "," + r5i130.Text + "," + r5i131.Text + "," + r5i132.Text + "," + r5i133.Text + "," + r5i134.Text + "," + r5i135.Text + "," + r5i136.Text + "," + r5i137.Text + "," + r5i138.Text + "," + r5i139.Text + "," + r5i140.Text + "," + r5i141.Text + "," + r5i142.Text + "," + r5i143.Text + "," + r5i144.Text + "," + r5i145.Text + "," + r5i146.Text + "," + r5i147.Text + "," + r5i148.Text + "," + r5i149.Text + "," + r5i150.Text + "," + r5i151.Text + "," + r5i152.Text + "," + r5i153.Text + "," + r5i154.Text + "," + r5i155.Text + "," + r5i156.Text + "," + r5i157.Text + "," + r5i158.Text + "," + r5i159.Text + "," + r5i160.Text + "," + r5i161.Text + "," + r5i162.Text + "," + r5i163.Text + "," + r5i164.Text + "," + r5i165.Text + "," + r5i166.Text + "," + r5i167.Text + "," + r5i168.Text + "," + r5i169.Text + "," + r5i170.Text + "," + r5i171.Text + "," + r5i172.Text + "," + r5i173.Text + "," + r5i174.Text + "," + r5i175.Text + "," + r5i176.Text + "," + r5i177.Text + "," + r5i178.Text + "," + r5i179.Text + "," + r5i180.Text + "," + r5i181.Text + "," + r5i182.Text + "," + r5i183.Text + "," + r5i184.Text + "," + r5i185.Text + "," + r5i186.Text + "," + r5i187.Text + "," + r5i188.Text + "," + r5i189.Text + "," + r5i190.Text + "," + r5i191.Text + "," + r5i192.Text + "," + r5i193.Text + "," + r5i194.Text + "," + r5i195.Text + "," + r5i196.Text + "," + r5i197.Text + "," + r5i198.Text + "," + r5i199.Text + "," + r5i200.Text + "," + r5i201.Text + "," + r5i202.Text + "," + r5i203.Text + "," + r5i204.Text + "," + r5i205.Text + "," + r5i206.Text + "," + r5i207.Text + "," + r5i208.Text + "," + r5i209.Text + "," + r5i210.Text + "," + r5i211.Text + "," + r5i212.Text + "," + r5i213.Text + "," + r5i214.Text + "," + r5i215.Text + "," + r5i216.Text + "," + r5i217.Text + "," + r5i218.Text + "," + r5i219.Text + "," + r5i220.Text + "," + r5i221.Text + "," + r5i222.Text + "," + r5i223.Text + "," + r5i224.Text + "," + r5i225.Text + "," + r5i226.Text + "," + r5i227.Text + "," + r5i228.Text + "," + r5i229.Text + "," + r5i230.Text + "," + r5i231.Text + "," + r5i232.Text + "," + r5i233.Text + "," + r5i234.Text + "," + r5i235.Text + "," + r5i236.Text + "," + r5i237.Text + "," + r5i238.Text + "," + r5i239.Text + "," + r5i240.Text + "," + r5i241.Text + "," + r5i242.Text + "," + r5i243.Text + "," + r5i244.Text + "," + r5i245.Text + "," + r5i246.Text + "," + r5i247.Text + "," + r5i248.Text + "," + r5i249.Text + "," + r5i250.Text + "," + r5i251.Text + "," + r5i252.Text + "," + r5i253.Text + "," + r5i254.Text + "," + r5i255.Text + "," + r5i256.Text + "," + r5i257.Text + "," + r5i258.Text + "," + r5i259.Text + "," + r5i260.Text + "," + r5i261.Text + "," + r5i262.Text + "," + r5i263.Text + "," + r5i264.Text + "," + r5i265.Text + "," + r5i266.Text + "," + r5i267.Text + "," + r5i268.Text + "," + r5i269.Text + "," + r5i270.Text + "," + r5i271.Text + "," + r5i272.Text + "," + r5i273.Text + "," + r5i274.Text + "," + r5i275.Text + "," + r5i276.Text + "," + r5i277.Text + "," + r5i278.Text + "," + r5i279.Text + "," + r5i280.Text + "," + r5i281.Text + "," + r5i282.Text + "," + r5i283.Text + "," + r5i284.Text + "," + r5i285.Text + "," + r5i286.Text + "," + r5i287.Text + "," + r5i288.Text + "," + "10-sec Data ALT 6" + "," + r6i01.Text + "," + r6i02.Text + "," + r6i03.Text + "," + r6i04.Text + "," + r6i05.Text + "," + r6i06.Text + "," + r6i07.Text + "," + r6i08.Text + "," + r6i09.Text + "," + r6i10.Text + "," + r6i11.Text + "," + r6i12.Text + "," + r6i13.Text + "," + r6i14.Text + "," + r6i15.Text + "," + r6i16.Text + "," + r6i17.Text + "," + r6i18.Text + "," + r6i19.Text + "," + r6i20.Text + "," + r6i21.Text + "," + r6i22.Text + "," + r6i23.Text + "," + r6i24.Text + "," + r6i25.Text + "," + r6i26.Text + "," + r6i27.Text + "," + r6i28.Text + "," + r6i29.Text + "," + r6i30.Text + "," + r6i31.Text + "," + r6i32.Text + "," + r6i33.Text + "," + r6i34.Text + "," + r6i35.Text + "," + r6i36.Text + "," + r6i37.Text + "," + r6i38.Text + "," + r6i39.Text + "," + r6i40.Text + "," + r6i41.Text + "," + r6i42.Text + "," + r6i43.Text + "," + r6i44.Text + "," + r6i45.Text + "," + r6i46.Text + "," + r6i47.Text + "," + r6i48.Text + "," + r6i49.Text + "," + r6i50.Text + "," + r6i51.Text + "," + r6i52.Text + "," + r6i53.Text + "," + r6i54.Text + "," + r6i55.Text + "," + r6i56.Text + "," + r6i57.Text + "," + r6i58.Text + "," + r6i59.Text + "," + r6i60.Text + "," + r6i61.Text + "," + r6i62.Text + "," + r6i63.Text + "," + r6i64.Text + "," + r6i65.Text + "," + r6i66.Text + "," + r6i67.Text + "," + r6i68.Text + "," + r6i69.Text + "," + r6i70.Text + "," + r6i71.Text + "," + r6i72.Text + "," + r6i73.Text + "," + r6i74.Text + "," + r6i75.Text + "," + r6i76.Text + "," + r6i77.Text + "," + r6i78.Text + "," + r6i79.Text + "," + r6i80.Text + "," + r6i81.Text + "," + r6i82.Text + "," + r6i83.Text + "," + r6i84.Text + "," + r6i85.Text + "," + r6i86.Text + "," + r6i87.Text + "," + r6i88.Text + "," + r6i89.Text + "," + r6i90.Text + "," + r6i91.Text + "," + r6i92.Text + "," + r6i93.Text + "," + r6i94.Text + "," + r6i95.Text + "," + r6i96.Text + "," + r6i97.Text + "," + r6i98.Text + "," + r6i99.Text + "," + r6i100.Text + "," + r6i101.Text + "," + r6i102.Text + "," + r6i103.Text + "," + r6i104.Text + "," + r6i105.Text + "," + r6i106.Text + "," + r6i107.Text + "," + r6i108.Text + "," + r6i109.Text + "," + r6i110.Text + "," + r6i111.Text + "," + r6i112.Text + "," + r6i113.Text + "," + r6i114.Text + "," + r6i115.Text + "," + r6i116.Text + "," + r6i117.Text + "," + r6i118.Text + "," + r6i119.Text + "," + r6i120.Text + "," + r6i121.Text + "," + r6i122.Text + "," + r6i123.Text + "," + r6i124.Text + "," + r6i125.Text + "," + r6i126.Text + "," + r6i127.Text + "," + r6i128.Text + "," + r6i129.Text + "," + r6i130.Text + "," + r6i131.Text + "," + r6i132.Text + "," + r6i133.Text + "," + r6i134.Text + "," + r6i135.Text + "," + r6i136.Text + "," + r6i137.Text + "," + r6i138.Text + "," + r6i139.Text + "," + r6i140.Text + "," + r6i141.Text + "," + r6i142.Text + "," + r6i143.Text + "," + r6i144.Text + "," + r6i145.Text + "," + r6i146.Text + "," + r6i147.Text + "," + r6i148.Text + "," + r6i149.Text + "," + r6i150.Text + "," + r6i151.Text + "," + r6i152.Text + "," + r6i153.Text + "," + r6i154.Text + "," + r6i155.Text + "," + r6i156.Text + "," + r6i157.Text + "," + r6i158.Text + "," + r6i159.Text + "," + r6i160.Text + "," + r6i161.Text + "," + r6i162.Text + "," + r6i163.Text + "," + r6i164.Text + "," + r6i165.Text + "," + r6i166.Text + "," + r6i167.Text + "," + r6i168.Text + "," + r6i169.Text + "," + r6i170.Text + "," + r6i171.Text + "," + r6i172.Text + "," + r6i173.Text + "," + r6i174.Text + "," + r6i175.Text + "," + r6i176.Text + "," + r6i177.Text + "," + r6i178.Text + "," + r6i179.Text + "," + r6i180.Text + "," + r6i181.Text + "," + r6i182.Text + "," + r6i183.Text + "," + r6i184.Text + "," + r6i185.Text + "," + r6i186.Text + "," + r6i187.Text + "," + r6i188.Text + "," + r6i189.Text + "," + r6i190.Text + "," + r6i191.Text + "," + r6i192.Text + "," + r6i193.Text + "," + r6i194.Text + "," + r6i195.Text + "," + r6i196.Text + "," + r6i197.Text + "," + r6i198.Text + "," + r6i199.Text + "," + r6i200.Text + "," + r6i201.Text + "," + r6i202.Text + "," + r6i203.Text + "," + r6i204.Text + "," + r6i205.Text + "," + r6i206.Text + "," + r6i207.Text + "," + r6i208.Text + "," + r6i209.Text + "," + r6i210.Text + "," + r6i211.Text + "," + r6i212.Text + "," + r6i213.Text + "," + r6i214.Text + "," + r6i215.Text + "," + r6i216.Text + "," + r6i217.Text + "," + r6i218.Text + "," + r6i219.Text + "," + r6i220.Text + "," + r6i221.Text + "," + r6i222.Text + "," + r6i223.Text + "," + r6i224.Text + "," + r6i225.Text + "," + r6i226.Text + "," + r6i227.Text + "," + r6i228.Text + "," + r6i229.Text + "," + r6i230.Text + "," + r6i231.Text + "," + r6i232.Text + "," + r6i233.Text + "," + r6i234.Text + "," + r6i235.Text + "," + r6i236.Text + "," + r6i237.Text + "," + r6i238.Text + "," + r6i239.Text + "," + r6i240.Text + "," + r6i241.Text + "," + r6i242.Text + "," + r6i243.Text + "," + r6i244.Text + "," + r6i245.Text + "," + r6i246.Text + "," + r6i247.Text + "," + r6i248.Text + "," + r6i249.Text + "," + r6i250.Text + "," + r6i251.Text + "," + r6i252.Text + "," + r6i253.Text + "," + r6i254.Text + "," + r6i255.Text + "," + r6i256.Text + "," + r6i257.Text + "," + r6i258.Text + "," + r6i259.Text + "," + r6i260.Text + "," + r6i261.Text + "," + r6i262.Text + "," + r6i263.Text + "," + r6i264.Text + "," + r6i265.Text + "," + r6i266.Text + "," + r6i267.Text + "," + r6i268.Text + "," + r6i269.Text + "," + r6i270.Text + "," + r6i271.Text + "," + r6i272.Text + "," + r6i273.Text + "," + r6i274.Text + "," + r6i275.Text + "," + r6i276.Text + "," + r6i277.Text + "," + r6i278.Text + "," + r6i279.Text + "," + r6i280.Text + "," + r6i281.Text + "," + r6i282.Text + "," + r6i283.Text + "," + r6i284.Text + "," + r6i285.Text + "," + r6i286.Text + "," + r6i287.Text + "," + r6i288.Text + ","
        My.Computer.FileSystem.WriteAllText(saveto & "\" & "RES.ppmmddyy.csv", csvTextBox.Text, True)
        System.Diagnostics.Process.Start("C:/Users/sara/Desktop/Resurgence/Final Questions")
        Close()
    End Sub
End Class