﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLapDanhMucPhong
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cboTenLoaiPhong = New System.Windows.Forms.ComboBox()
        Me.txtDonGia = New System.Windows.Forms.TextBox()
        Me.txtTenPhong = New System.Windows.Forms.TextBox()
        Me.txtGhiChu = New System.Windows.Forms.TextBox()
        Me.txtMaPhong = New System.Windows.Forms.TextBox()
        Me.lblDonGia = New System.Windows.Forms.Label()
        Me.lblTenPhong = New System.Windows.Forms.Label()
        Me.lblGhiChu = New System.Windows.Forms.Label()
        Me.lblTenLoaiPhong = New System.Windows.Forms.Label()
        Me.lblMaPhong = New System.Windows.Forms.Label()
        Me.btnLapPhong = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btnXoaPhong = New System.Windows.Forms.Button()
        Me.btnCapNhat = New System.Windows.Forms.Button()
        Me.btnTimPhong = New System.Windows.Forms.Button()
        Me.btnThoat = New System.Windows.Forms.Button()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.grpMaPhong = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.grpTenPhong = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.grpLoaiPhong = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.grpDonGia = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.grpGhiChu = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnNhapLai = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cboTenLoaiPhong)
        Me.GroupBox1.Controls.Add(Me.txtDonGia)
        Me.GroupBox1.Controls.Add(Me.txtTenPhong)
        Me.GroupBox1.Controls.Add(Me.txtGhiChu)
        Me.GroupBox1.Controls.Add(Me.txtMaPhong)
        Me.GroupBox1.Controls.Add(Me.lblDonGia)
        Me.GroupBox1.Controls.Add(Me.lblTenPhong)
        Me.GroupBox1.Controls.Add(Me.lblGhiChu)
        Me.GroupBox1.Controls.Add(Me.lblTenLoaiPhong)
        Me.GroupBox1.Controls.Add(Me.lblMaPhong)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(607, 170)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "LẬP DANH MỤC PHÒNG"
        '
        'cboTenLoaiPhong
        '
        Me.cboTenLoaiPhong.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.cboTenLoaiPhong.FormattingEnabled = True
        Me.cboTenLoaiPhong.Location = New System.Drawing.Point(143, 80)
        Me.cboTenLoaiPhong.Name = "cboTenLoaiPhong"
        Me.cboTenLoaiPhong.Size = New System.Drawing.Size(140, 21)
        Me.cboTenLoaiPhong.TabIndex = 10
        '
        'txtDonGia
        '
        Me.txtDonGia.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.txtDonGia.Location = New System.Drawing.Point(392, 83)
        Me.txtDonGia.Name = "txtDonGia"
        Me.txtDonGia.ReadOnly = True
        Me.txtDonGia.Size = New System.Drawing.Size(140, 20)
        Me.txtDonGia.TabIndex = 9
        '
        'txtTenPhong
        '
        Me.txtTenPhong.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.txtTenPhong.Location = New System.Drawing.Point(392, 46)
        Me.txtTenPhong.Name = "txtTenPhong"
        Me.txtTenPhong.Size = New System.Drawing.Size(140, 20)
        Me.txtTenPhong.TabIndex = 8
        '
        'txtGhiChu
        '
        Me.txtGhiChu.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.txtGhiChu.Location = New System.Drawing.Point(143, 118)
        Me.txtGhiChu.Name = "txtGhiChu"
        Me.txtGhiChu.Size = New System.Drawing.Size(140, 20)
        Me.txtGhiChu.TabIndex = 7
        '
        'txtMaPhong
        '
        Me.txtMaPhong.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.txtMaPhong.Location = New System.Drawing.Point(143, 46)
        Me.txtMaPhong.Name = "txtMaPhong"
        Me.txtMaPhong.Size = New System.Drawing.Size(140, 20)
        Me.txtMaPhong.TabIndex = 5
        '
        'lblDonGia
        '
        Me.lblDonGia.AutoSize = True
        Me.lblDonGia.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.lblDonGia.Location = New System.Drawing.Point(317, 83)
        Me.lblDonGia.Name = "lblDonGia"
        Me.lblDonGia.Size = New System.Drawing.Size(47, 13)
        Me.lblDonGia.TabIndex = 4
        Me.lblDonGia.Text = "Đơn giá:"
        '
        'lblTenPhong
        '
        Me.lblTenPhong.AutoSize = True
        Me.lblTenPhong.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.lblTenPhong.Location = New System.Drawing.Point(317, 46)
        Me.lblTenPhong.Name = "lblTenPhong"
        Me.lblTenPhong.Size = New System.Drawing.Size(62, 13)
        Me.lblTenPhong.TabIndex = 3
        Me.lblTenPhong.Text = "Tên phòng:"
        '
        'lblGhiChu
        '
        Me.lblGhiChu.AutoSize = True
        Me.lblGhiChu.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.lblGhiChu.Location = New System.Drawing.Point(43, 121)
        Me.lblGhiChu.Name = "lblGhiChu"
        Me.lblGhiChu.Size = New System.Drawing.Size(47, 13)
        Me.lblGhiChu.TabIndex = 2
        Me.lblGhiChu.Text = "Ghi chú:"
        '
        'lblTenLoaiPhong
        '
        Me.lblTenLoaiPhong.AutoSize = True
        Me.lblTenLoaiPhong.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.lblTenLoaiPhong.Location = New System.Drawing.Point(43, 80)
        Me.lblTenLoaiPhong.Name = "lblTenLoaiPhong"
        Me.lblTenLoaiPhong.Size = New System.Drawing.Size(81, 13)
        Me.lblTenLoaiPhong.TabIndex = 1
        Me.lblTenLoaiPhong.Text = "Tên loại phòng:"
        '
        'lblMaPhong
        '
        Me.lblMaPhong.AutoSize = True
        Me.lblMaPhong.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.lblMaPhong.Location = New System.Drawing.Point(43, 46)
        Me.lblMaPhong.Name = "lblMaPhong"
        Me.lblMaPhong.Size = New System.Drawing.Size(58, 13)
        Me.lblMaPhong.TabIndex = 0
        Me.lblMaPhong.Text = "Mã phòng:"
        '
        'btnLapPhong
        '
        Me.btnLapPhong.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.btnLapPhong.Location = New System.Drawing.Point(368, 45)
        Me.btnLapPhong.Name = "btnLapPhong"
        Me.btnLapPhong.Size = New System.Drawing.Size(90, 23)
        Me.btnLapPhong.TabIndex = 1
        Me.btnLapPhong.Text = "&Lập phòng"
        Me.btnLapPhong.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btnNhapLai)
        Me.GroupBox2.Controls.Add(Me.btnXoaPhong)
        Me.GroupBox2.Controls.Add(Me.btnCapNhat)
        Me.GroupBox2.Controls.Add(Me.btnTimPhong)
        Me.GroupBox2.Controls.Add(Me.btnThoat)
        Me.GroupBox2.Controls.Add(Me.btnLapPhong)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 339)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(607, 102)
        Me.GroupBox2.TabIndex = 2
        Me.GroupBox2.TabStop = False
        '
        'btnXoaPhong
        '
        Me.btnXoaPhong.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.btnXoaPhong.Location = New System.Drawing.Point(31, 63)
        Me.btnXoaPhong.Name = "btnXoaPhong"
        Me.btnXoaPhong.Size = New System.Drawing.Size(90, 23)
        Me.btnXoaPhong.TabIndex = 6
        Me.btnXoaPhong.Text = "Xóa phòng"
        Me.btnXoaPhong.UseVisualStyleBackColor = True
        '
        'btnCapNhat
        '
        Me.btnCapNhat.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.btnCapNhat.Location = New System.Drawing.Point(31, 28)
        Me.btnCapNhat.Name = "btnCapNhat"
        Me.btnCapNhat.Size = New System.Drawing.Size(90, 23)
        Me.btnCapNhat.TabIndex = 5
        Me.btnCapNhat.Text = "Cập nhật"
        Me.btnCapNhat.UseVisualStyleBackColor = True
        '
        'btnTimPhong
        '
        Me.btnTimPhong.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.btnTimPhong.Location = New System.Drawing.Point(143, 28)
        Me.btnTimPhong.Name = "btnTimPhong"
        Me.btnTimPhong.Size = New System.Drawing.Size(90, 23)
        Me.btnTimPhong.TabIndex = 3
        Me.btnTimPhong.Text = "Tìm  phòng"
        Me.btnTimPhong.UseVisualStyleBackColor = True
        '
        'btnThoat
        '
        Me.btnThoat.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.btnThoat.Location = New System.Drawing.Point(480, 45)
        Me.btnThoat.Name = "btnThoat"
        Me.btnThoat.Size = New System.Drawing.Size(90, 23)
        Me.btnThoat.TabIndex = 2
        Me.btnThoat.Text = "&Thoát"
        Me.btnThoat.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.DataGridView1)
        Me.GroupBox3.Location = New System.Drawing.Point(12, 188)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(607, 148)
        Me.GroupBox3.TabIndex = 3
        Me.GroupBox3.TabStop = False
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.grpMaPhong, Me.grpTenPhong, Me.grpLoaiPhong, Me.grpDonGia, Me.grpGhiChu})
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView1.Location = New System.Drawing.Point(3, 16)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(601, 129)
        Me.DataGridView1.TabIndex = 0
        '
        'grpMaPhong
        '
        Me.grpMaPhong.HeaderText = "Mã Phòng"
        Me.grpMaPhong.Name = "grpMaPhong"
        '
        'grpTenPhong
        '
        Me.grpTenPhong.HeaderText = "Tên Phòng"
        Me.grpTenPhong.Name = "grpTenPhong"
        '
        'grpLoaiPhong
        '
        Me.grpLoaiPhong.HeaderText = "Loại Phòng"
        Me.grpLoaiPhong.Name = "grpLoaiPhong"
        '
        'grpDonGia
        '
        Me.grpDonGia.HeaderText = "Đơn Giá"
        Me.grpDonGia.Name = "grpDonGia"
        '
        'grpGhiChu
        '
        Me.grpGhiChu.HeaderText = "Ghi Chú"
        Me.grpGhiChu.Name = "grpGhiChu"
        Me.grpGhiChu.Width = 150
        '
        'btnNhapLai
        '
        Me.btnNhapLai.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.btnNhapLai.Location = New System.Drawing.Point(143, 63)
        Me.btnNhapLai.Name = "btnNhapLai"
        Me.btnNhapLai.Size = New System.Drawing.Size(90, 23)
        Me.btnNhapLai.TabIndex = 7
        Me.btnNhapLai.Text = "Nhập lại"
        Me.btnNhapLai.UseVisualStyleBackColor = True
        '
        'frmLapDanhMucPhong
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(631, 453)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "frmLapDanhMucPhong"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmLapDanhMucPhong"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents lblDonGia As System.Windows.Forms.Label
    Friend WithEvents lblTenPhong As System.Windows.Forms.Label
    Friend WithEvents lblGhiChu As System.Windows.Forms.Label
    Friend WithEvents lblTenLoaiPhong As System.Windows.Forms.Label
    Friend WithEvents lblMaPhong As System.Windows.Forms.Label
    Friend WithEvents txtMaPhong As System.Windows.Forms.TextBox
    Friend WithEvents txtDonGia As System.Windows.Forms.TextBox
    Friend WithEvents txtTenPhong As System.Windows.Forms.TextBox
    Friend WithEvents txtGhiChu As System.Windows.Forms.TextBox
    Friend WithEvents cboTenLoaiPhong As System.Windows.Forms.ComboBox
    Friend WithEvents btnLapPhong As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents btnThoat As System.Windows.Forms.Button
    Friend WithEvents btnCapNhat As System.Windows.Forms.Button
    Friend WithEvents btnTimPhong As System.Windows.Forms.Button
    Friend WithEvents btnXoaPhong As System.Windows.Forms.Button
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents grpMaPhong As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents grpTenPhong As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents grpLoaiPhong As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents grpDonGia As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents grpGhiChu As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents btnNhapLai As System.Windows.Forms.Button
End Class
