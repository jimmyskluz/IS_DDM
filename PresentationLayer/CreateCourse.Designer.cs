namespace PresentationLayer
{
    partial class CreateCourse
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.TextBox();
            this.room = new System.Windows.Forms.TextBox();
            this.level = new System.Windows.Forms.TextBox();
            this.lector = new System.Windows.Forms.TextBox();
            this.capacity = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.create = new System.Windows.Forms.Button();
            this.back = new System.Windows.Forms.Button();
            this.validCouse = new System.Windows.Forms.Button();
            this.validClassroom = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(137, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Název";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(137, 137);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ůroveň";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(137, 183);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Lector";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(137, 233);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Kapacita";
            // 
            // name
            // 
            this.name.Location = new System.Drawing.Point(280, 91);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(148, 22);
            this.name.TabIndex = 5;
            // 
            // room
            // 
            this.room.Location = new System.Drawing.Point(280, 281);
            this.room.Name = "room";
            this.room.Size = new System.Drawing.Size(148, 22);
            this.room.TabIndex = 6;
            // 
            // level
            // 
            this.level.Location = new System.Drawing.Point(280, 134);
            this.level.Name = "level";
            this.level.Size = new System.Drawing.Size(148, 22);
            this.level.TabIndex = 7;
            // 
            // lector
            // 
            this.lector.Location = new System.Drawing.Point(280, 180);
            this.lector.Name = "lector";
            this.lector.Size = new System.Drawing.Size(148, 22);
            this.lector.TabIndex = 8;
            // 
            // capacity
            // 
            this.capacity.Location = new System.Drawing.Point(280, 230);
            this.capacity.Name = "capacity";
            this.capacity.Size = new System.Drawing.Size(148, 22);
            this.capacity.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(137, 284);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 17);
            this.label6.TabIndex = 10;
            this.label6.Text = "Trida";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(301, 37);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(86, 17);
            this.label7.TabIndex = 11;
            this.label7.Text = "Vytvořit kurz";
            // 
            // create
            // 
            this.create.Location = new System.Drawing.Point(388, 370);
            this.create.Name = "create";
            this.create.Size = new System.Drawing.Size(102, 33);
            this.create.TabIndex = 12;
            this.create.Text = "Vytvořit";
            this.create.UseVisualStyleBackColor = true;
            this.create.Click += new System.EventHandler(this.create_Click);
            // 
            // back
            // 
            this.back.Location = new System.Drawing.Point(167, 370);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(102, 33);
            this.back.TabIndex = 13;
            this.back.Text = "Zpět";
            this.back.UseVisualStyleBackColor = true;
            // 
            // validCouse
            // 
            this.validCouse.Location = new System.Drawing.Point(489, 130);
            this.validCouse.Name = "validCouse";
            this.validCouse.Size = new System.Drawing.Size(33, 30);
            this.validCouse.TabIndex = 14;
            this.validCouse.Text = "x";
            this.validCouse.UseVisualStyleBackColor = true;
            this.validCouse.Click += new System.EventHandler(this.validCouse_Click);
            // 
            // validClassroom
            // 
            this.validClassroom.Location = new System.Drawing.Point(489, 277);
            this.validClassroom.Name = "validClassroom";
            this.validClassroom.Size = new System.Drawing.Size(33, 30);
            this.validClassroom.TabIndex = 15;
            this.validClassroom.Text = "x";
            this.validClassroom.UseVisualStyleBackColor = true;
            this.validClassroom.Click += new System.EventHandler(this.validClassroom_Click);
            // 
            // CreateCourse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.validClassroom);
            this.Controls.Add(this.validCouse);
            this.Controls.Add(this.back);
            this.Controls.Add(this.create);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.capacity);
            this.Controls.Add(this.lector);
            this.Controls.Add(this.level);
            this.Controls.Add(this.room);
            this.Controls.Add(this.name);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "CreateCourse";
            this.Text = "CreateCourse";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.TextBox room;
        private System.Windows.Forms.TextBox level;
        private System.Windows.Forms.TextBox lector;
        private System.Windows.Forms.TextBox capacity;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button create;
        private System.Windows.Forms.Button back;
        private System.Windows.Forms.Button validCouse;
        private System.Windows.Forms.Button validClassroom;
    }
}