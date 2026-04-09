namespace BurgerKiosk
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            lblBurgerOrderKiosk = new Label();
            rdoHamBurger = new RadioButton();
            rdoBulgogiBurger = new RadioButton();
            rdoChickenBurger = new RadioButton();
            grpMenue = new GroupBox();
            picChickenBurger = new PictureBox();
            picBulgogiBurger = new PictureBox();
            picHamburger = new PictureBox();
            chkPotato = new CheckBox();
            chkCola = new CheckBox();
            chkCheese = new CheckBox();
            chkSauce = new CheckBox();
            grpOption = new GroupBox();
            grpOrder = new GroupBox();
            lblTotalCost = new Label();
            lstOrder = new ListBox();
            btnOrder = new Button();
            btnReset = new Button();
            lblErrorMsg = new Label();
            grpMenue.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picChickenBurger).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picBulgogiBurger).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picHamburger).BeginInit();
            grpOption.SuspendLayout();
            grpOrder.SuspendLayout();
            SuspendLayout();
            // 
            // lblBurgerOrderKiosk
            // 
            lblBurgerOrderKiosk.AutoSize = true;
            lblBurgerOrderKiosk.Font = new Font("맑은 고딕", 36F, FontStyle.Bold, GraphicsUnit.Point, 129);
            lblBurgerOrderKiosk.Location = new Point(162, 61);
            lblBurgerOrderKiosk.Name = "lblBurgerOrderKiosk";
            lblBurgerOrderKiosk.Size = new Size(666, 96);
            lblBurgerOrderKiosk.TabIndex = 0;
            lblBurgerOrderKiosk.Text = "버거 주문 키오스크";
            // 
            // rdoHamBurger
            // 
            rdoHamBurger.AutoSize = true;
            rdoHamBurger.Font = new Font("맑은 고딕", 18F, FontStyle.Regular, GraphicsUnit.Point, 129);
            rdoHamBurger.Location = new Point(37, 84);
            rdoHamBurger.Name = "rdoHamBurger";
            rdoHamBurger.Size = new Size(153, 52);
            rdoHamBurger.TabIndex = 0;
            rdoHamBurger.Text = "햄버거";
            rdoHamBurger.UseVisualStyleBackColor = true;
            // 
            // rdoBulgogiBurger
            // 
            rdoBulgogiBurger.AutoSize = true;
            rdoBulgogiBurger.Font = new Font("맑은 고딕", 18F, FontStyle.Regular, GraphicsUnit.Point, 129);
            rdoBulgogiBurger.Location = new Point(37, 258);
            rdoBulgogiBurger.Name = "rdoBulgogiBurger";
            rdoBulgogiBurger.Size = new Size(225, 52);
            rdoBulgogiBurger.TabIndex = 1;
            rdoBulgogiBurger.Text = "불고기버거";
            rdoBulgogiBurger.UseVisualStyleBackColor = true;
            // 
            // rdoChickenBurger
            // 
            rdoChickenBurger.AutoSize = true;
            rdoChickenBurger.Font = new Font("맑은 고딕", 18F, FontStyle.Regular, GraphicsUnit.Point, 129);
            rdoChickenBurger.Location = new Point(37, 434);
            rdoChickenBurger.Name = "rdoChickenBurger";
            rdoChickenBurger.Size = new Size(189, 52);
            rdoChickenBurger.TabIndex = 2;
            rdoChickenBurger.Text = "치킨버거";
            rdoChickenBurger.UseVisualStyleBackColor = true;
            // 
            // grpMenue
            // 
            grpMenue.Controls.Add(picChickenBurger);
            grpMenue.Controls.Add(picBulgogiBurger);
            grpMenue.Controls.Add(picHamburger);
            grpMenue.Controls.Add(rdoHamBurger);
            grpMenue.Controls.Add(rdoChickenBurger);
            grpMenue.Controls.Add(rdoBulgogiBurger);
            grpMenue.Font = new Font("맑은 고딕", 18F, FontStyle.Bold, GraphicsUnit.Point, 129);
            grpMenue.Location = new Point(23, 204);
            grpMenue.Name = "grpMenue";
            grpMenue.Size = new Size(451, 623);
            grpMenue.TabIndex = 1;
            grpMenue.TabStop = false;
            grpMenue.Text = "메뉴선택";
            // 
            // picChickenBurger
            // 
            picChickenBurger.Image = (Image)resources.GetObject("picChickenBurger.Image");
            picChickenBurger.Location = new Point(251, 434);
            picChickenBurger.Name = "picChickenBurger";
            picChickenBurger.Size = new Size(169, 163);
            picChickenBurger.SizeMode = PictureBoxSizeMode.StretchImage;
            picChickenBurger.TabIndex = 5;
            picChickenBurger.TabStop = false;
            // 
            // picBulgogiBurger
            // 
            picBulgogiBurger.Image = (Image)resources.GetObject("picBulgogiBurger.Image");
            picBulgogiBurger.Location = new Point(251, 265);
            picBulgogiBurger.Name = "picBulgogiBurger";
            picBulgogiBurger.Size = new Size(169, 163);
            picBulgogiBurger.SizeMode = PictureBoxSizeMode.StretchImage;
            picBulgogiBurger.TabIndex = 4;
            picBulgogiBurger.TabStop = false;
            // 
            // picHamburger
            // 
            picHamburger.Image = (Image)resources.GetObject("picHamburger.Image");
            picHamburger.Location = new Point(251, 96);
            picHamburger.Name = "picHamburger";
            picHamburger.Size = new Size(169, 163);
            picHamburger.SizeMode = PictureBoxSizeMode.StretchImage;
            picHamburger.TabIndex = 0;
            picHamburger.TabStop = false;
            // 
            // chkPotato
            // 
            chkPotato.AutoSize = true;
            chkPotato.Font = new Font("맑은 고딕", 18F, FontStyle.Regular, GraphicsUnit.Point, 129);
            chkPotato.Location = new Point(23, 56);
            chkPotato.Name = "chkPotato";
            chkPotato.Size = new Size(190, 52);
            chkPotato.TabIndex = 0;
            chkPotato.Text = "감자튀김";
            chkPotato.UseVisualStyleBackColor = true;
            // 
            // chkCola
            // 
            chkCola.AutoSize = true;
            chkCola.Font = new Font("맑은 고딕", 18F, FontStyle.Regular, GraphicsUnit.Point, 129);
            chkCola.Location = new Point(23, 114);
            chkCola.Name = "chkCola";
            chkCola.Size = new Size(118, 52);
            chkCola.TabIndex = 1;
            chkCola.Text = "콜라";
            chkCola.UseVisualStyleBackColor = true;
            // 
            // chkCheese
            // 
            chkCheese.AutoSize = true;
            chkCheese.Font = new Font("맑은 고딕", 18F, FontStyle.Regular, GraphicsUnit.Point, 129);
            chkCheese.Location = new Point(23, 172);
            chkCheese.Name = "chkCheese";
            chkCheese.Size = new Size(203, 52);
            chkCheese.TabIndex = 2;
            chkCheese.Text = "치즈 추가";
            chkCheese.UseVisualStyleBackColor = true;
            // 
            // chkSauce
            // 
            chkSauce.AutoSize = true;
            chkSauce.Font = new Font("맑은 고딕", 18F, FontStyle.Regular, GraphicsUnit.Point, 129);
            chkSauce.Location = new Point(23, 231);
            chkSauce.Name = "chkSauce";
            chkSauce.Size = new Size(203, 52);
            chkSauce.TabIndex = 3;
            chkSauce.Text = "소스 추가";
            chkSauce.UseVisualStyleBackColor = true;
            // 
            // grpOption
            // 
            grpOption.Controls.Add(chkPotato);
            grpOption.Controls.Add(chkSauce);
            grpOption.Controls.Add(chkCola);
            grpOption.Controls.Add(chkCheese);
            grpOption.Font = new Font("맑은 고딕", 18F, FontStyle.Bold, GraphicsUnit.Point, 129);
            grpOption.Location = new Point(528, 220);
            grpOption.Name = "grpOption";
            grpOption.Size = new Size(300, 412);
            grpOption.TabIndex = 2;
            grpOption.TabStop = false;
            grpOption.Text = "추가옵션";
            // 
            // grpOrder
            // 
            grpOrder.Controls.Add(lblTotalCost);
            grpOrder.Controls.Add(lstOrder);
            grpOrder.Font = new Font("맑은 고딕", 18F, FontStyle.Bold, GraphicsUnit.Point, 129);
            grpOrder.Location = new Point(891, 204);
            grpOrder.Name = "grpOrder";
            grpOrder.Size = new Size(522, 457);
            grpOrder.TabIndex = 3;
            grpOrder.TabStop = false;
            grpOrder.Text = "주문 내역";
            // 
            // lblTotalCost
            // 
            lblTotalCost.AutoSize = true;
            lblTotalCost.Location = new Point(27, 380);
            lblTotalCost.Name = "lblTotalCost";
            lblTotalCost.Size = new Size(272, 48);
            lblTotalCost.TabIndex = 1;
            lblTotalCost.Text = "총　금액：０원";
            // 
            // lstOrder
            // 
            lstOrder.FormattingEnabled = true;
            lstOrder.Location = new Point(27, 72);
            lstOrder.Name = "lstOrder";
            lstOrder.Size = new Size(469, 292);
            lstOrder.TabIndex = 0;
            // 
            // btnOrder
            // 
            btnOrder.Font = new Font("맑은 고딕", 18F, FontStyle.Regular, GraphicsUnit.Point, 129);
            btnOrder.Location = new Point(891, 693);
            btnOrder.Name = "btnOrder";
            btnOrder.Size = new Size(258, 71);
            btnOrder.TabIndex = 4;
            btnOrder.Text = "주문하기";
            btnOrder.UseVisualStyleBackColor = true;
            btnOrder.Click += btnOrder_Click;
            // 
            // btnReset
            // 
            btnReset.Font = new Font("맑은 고딕", 18F, FontStyle.Regular, GraphicsUnit.Point, 129);
            btnReset.Location = new Point(1155, 693);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(258, 71);
            btnReset.TabIndex = 5;
            btnReset.Text = "초기화";
            btnReset.UseVisualStyleBackColor = true;
            btnReset.Click += btnReset_Click;
            // 
            // lblErrorMsg
            // 
            lblErrorMsg.AutoSize = true;
            lblErrorMsg.ForeColor = Color.Red;
            lblErrorMsg.Location = new Point(891, 664);
            lblErrorMsg.Name = "lblErrorMsg";
            lblErrorMsg.Size = new Size(180, 25);
            lblErrorMsg.TabIndex = 6;
            lblErrorMsg.Text = "메뉴를 선택해주세요";
            lblErrorMsg.Visible = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1492, 826);
            Controls.Add(lblErrorMsg);
            Controls.Add(btnReset);
            Controls.Add(btnOrder);
            Controls.Add(grpOrder);
            Controls.Add(grpOption);
            Controls.Add(grpMenue);
            Controls.Add(lblBurgerOrderKiosk);
            Name = "Form1";
            Text = "BurgerKiosk";
            grpMenue.ResumeLayout(false);
            grpMenue.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picChickenBurger).EndInit();
            ((System.ComponentModel.ISupportInitialize)picBulgogiBurger).EndInit();
            ((System.ComponentModel.ISupportInitialize)picHamburger).EndInit();
            grpOption.ResumeLayout(false);
            grpOption.PerformLayout();
            grpOrder.ResumeLayout(false);
            grpOrder.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblBurgerOrderKiosk;
        private RadioButton rdoHamBurger;
        private RadioButton rdoBulgogiBurger;
        private RadioButton rdoChickenBurger;
        private GroupBox grpMenue;
        private CheckBox chkPotato;
        private CheckBox chkCola;
        private CheckBox chkCheese;
        private CheckBox chkSauce;
        private GroupBox grpOption;
        private GroupBox grpOrder;
        private PictureBox picHamburger;
        private PictureBox picChickenBurger;
        private PictureBox picBulgogiBurger;
        private Label lblTotalCost;
        private ListBox lstOrder;
        private Button btnOrder;
        private Button btnReset;
        private Label lblErrorMsg;
    }
}
