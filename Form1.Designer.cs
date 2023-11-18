namespace CourseWork89
{
    partial class FormMain
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
            pictureBoxMain = new PictureBox();
            TakeFigure = new CheckBox();
            SelectColorComboBox = new ComboBox();
            SelectTMOComboBox = new ComboBox();
            SelectFigureComboBox = new ComboBox();
            GTComboBox = new ComboBox();
            ButtonForTMO = new Button();
            PaintCubSpline = new Button();
            ToPaint = new Button();
            ButtonClear_ = new Button();
            DeleteFigure_ = new Button();
            label1 = new Label();
            numericForPolinom = new NumericUpDown();
            label2 = new Label();
            Angle = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBoxMain).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericForPolinom).BeginInit();
            SuspendLayout();
            // 
            // pictureBoxMain
            // 
            pictureBoxMain.BackColor = SystemColors.HighlightText;
            pictureBoxMain.Location = new Point(-1, 0);
            pictureBoxMain.Name = "pictureBoxMain";
            pictureBoxMain.Size = new Size(981, 480);
            pictureBoxMain.TabIndex = 0;
            pictureBoxMain.TabStop = false;
            pictureBoxMain.MouseDown += PictureBoxMouseDown;
            pictureBoxMain.MouseMove += PictureBoxMouseMove;
            // 
            // TakeFigure
            // 
            TakeFigure.AutoSize = true;
            TakeFigure.Location = new Point(856, 490);
            TakeFigure.Name = "TakeFigure";
            TakeFigure.Size = new Size(124, 19);
            TakeFigure.TabIndex = 1;
            TakeFigure.Text = "Фигура выбрана";
            TakeFigure.UseVisualStyleBackColor = true;
            // 
            // SelectColorComboBox
            // 
            SelectColorComboBox.FormattingEnabled = true;
            SelectColorComboBox.Items.AddRange(new object[] { "Черный", "Синий", "Зеленый", "Красный" });
            SelectColorComboBox.Location = new Point(12, 486);
            SelectColorComboBox.Name = "SelectColorComboBox";
            SelectColorComboBox.Size = new Size(121, 23);
            SelectColorComboBox.TabIndex = 2;
            SelectColorComboBox.Text = "Цвет";
            SelectColorComboBox.SelectedIndexChanged += SelectColor;
            // 
            // SelectTMOComboBox
            // 
            SelectTMOComboBox.FormattingEnabled = true;
            SelectTMOComboBox.Items.AddRange(new object[] { "Объединение", "Пересечение", "Симметрическая разность", "Разность А/В", "Разность В/А" });
            SelectTMOComboBox.Location = new Point(139, 486);
            SelectTMOComboBox.Name = "SelectTMOComboBox";
            SelectTMOComboBox.Size = new Size(142, 23);
            SelectTMOComboBox.TabIndex = 3;
            SelectTMOComboBox.Text = "Операция ТМО";
            SelectTMOComboBox.SelectedIndexChanged += SelectTMOComboBox_;
            // 
            // SelectFigureComboBox
            // 
            SelectFigureComboBox.FormattingEnabled = true;
            SelectFigureComboBox.Items.AddRange(new object[] { "Равнобедренная трапеция", "Флаг" });
            SelectFigureComboBox.Location = new Point(287, 486);
            SelectFigureComboBox.Name = "SelectFigureComboBox";
            SelectFigureComboBox.Size = new Size(121, 23);
            SelectFigureComboBox.TabIndex = 3;
            SelectFigureComboBox.Text = "Выбор фигуры";
            SelectFigureComboBox.SelectedIndexChanged += SelectFigure;
            // 
            // GTComboBox
            // 
            GTComboBox.FormattingEnabled = true;
            GTComboBox.Items.AddRange(new object[] { "Перемещение", "Поворот вокруг заданного центра на произвольный угол", "Масштабирование по оси Х относительно центра", "Зеркальное отражение относительно прямой общего положения" });
            GTComboBox.Location = new Point(414, 486);
            GTComboBox.Name = "GTComboBox";
            GTComboBox.Size = new Size(267, 23);
            GTComboBox.TabIndex = 3;
            GTComboBox.Text = "Геометрическое преобразование";
            GTComboBox.SelectedIndexChanged += SelectGt;
            // 
            // ButtonForTMO
            // 
            ButtonForTMO.Location = new Point(986, 12);
            ButtonForTMO.Name = "ButtonForTMO";
            ButtonForTMO.Size = new Size(133, 33);
            ButtonForTMO.TabIndex = 4;
            ButtonForTMO.Text = "Выполнить ТМО";
            ButtonForTMO.UseVisualStyleBackColor = true;
            ButtonForTMO.Click += ButtonForTMO_Click;
            // 
            // PaintCubSpline
            // 
            PaintCubSpline.Location = new Point(986, 121);
            PaintCubSpline.Name = "PaintCubSpline";
            PaintCubSpline.Size = new Size(133, 72);
            PaintCubSpline.TabIndex = 4;
            PaintCubSpline.Text = "Нарисовать кубический сплайн";
            PaintCubSpline.UseVisualStyleBackColor = true;
            PaintCubSpline.Click += PaintCubeSpline_Click;
            // 
            // ToPaint
            // 
            ToPaint.Location = new Point(986, 216);
            ToPaint.Name = "ToPaint";
            ToPaint.Size = new Size(133, 58);
            ToPaint.TabIndex = 4;
            ToPaint.Text = "Перейти в режим свободного рисования";
            ToPaint.UseVisualStyleBackColor = true;
            ToPaint.Click += ToPaint_Click;
            // 
            // ButtonClear_
            // 
            ButtonClear_.Location = new Point(986, 447);
            ButtonClear_.Name = "ButtonClear_";
            ButtonClear_.Size = new Size(133, 33);
            ButtonClear_.TabIndex = 4;
            ButtonClear_.Text = "Очистка экрана";
            ButtonClear_.UseVisualStyleBackColor = true;
            ButtonClear_.Click += ButtonClear_Click;
            // 
            // DeleteFigure_
            // 
            DeleteFigure_.Location = new Point(986, 315);
            DeleteFigure_.Name = "DeleteFigure_";
            DeleteFigure_.Size = new Size(133, 33);
            DeleteFigure_.TabIndex = 4;
            DeleteFigure_.Text = "Удаление фигур";
            DeleteFigure_.UseVisualStyleBackColor = true;
            DeleteFigure_.Click += DeleteFigure_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 537);
            label1.Name = "label1";
            label1.Size = new Size(245, 15);
            label1.TabIndex = 5;
            label1.Text = "Размер ребра для создания полинома";
            // 
            // numericForPolinom
            // 
            numericForPolinom.Location = new Point(263, 534);
            numericForPolinom.Maximum = new decimal(new int[] { 250, 0, 0, 0 });
            numericForPolinom.Minimum = new decimal(new int[] { 50, 0, 0, 0 });
            numericForPolinom.Name = "numericForPolinom";
            numericForPolinom.Size = new Size(49, 23);
            numericForPolinom.TabIndex = 6;
            numericForPolinom.Value = new decimal(new int[] { 50, 0, 0, 0 });
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(318, 537);
            label2.Name = "label2";
            label2.Size = new Size(98, 15);
            label2.TabIndex = 7;
            label2.Text = "Угол поворота";
            // 
            // Angle
            // 
            Angle.Location = new Point(422, 536);
            Angle.Name = "Angle";
            Angle.ReadOnly = true;
            Angle.Size = new Size(100, 23);
            Angle.TabIndex = 8;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ScrollBar;
            ClientSize = new Size(1122, 555);
            Controls.Add(Angle);
            Controls.Add(label2);
            Controls.Add(numericForPolinom);
            Controls.Add(label1);
            Controls.Add(DeleteFigure_);
            Controls.Add(ButtonClear_);
            Controls.Add(ToPaint);
            Controls.Add(PaintCubSpline);
            Controls.Add(ButtonForTMO);
            Controls.Add(GTComboBox);
            Controls.Add(SelectFigureComboBox);
            Controls.Add(SelectTMOComboBox);
            Controls.Add(SelectColorComboBox);
            Controls.Add(TakeFigure);
            Controls.Add(pictureBoxMain);
            Font = new Font("Consolas", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            Name = "FormMain";
            Text = "Курсовая работа";
            ((System.ComponentModel.ISupportInitialize)pictureBoxMain).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericForPolinom).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBoxMain;
        private CheckBox TakeFigure;
        private ComboBox SelectColorComboBox;
        private ComboBox SelectTMOComboBox;
        private ComboBox SelectFigureComboBox;
        private ComboBox GTComboBox;
        private Button ButtonForTMO;
        private Button PaintCubSpline;
        private Button ToPaint;
        private Button ButtonClear_;
        private Button DeleteFigure_;
        private Label label1;
        private NumericUpDown numericForPolinom;
        private Label label2;
        private TextBox Angle;
    }
}