
namespace FormsApp
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.Nome = new System.Windows.Forms.TextBox();
            this.DataNascimento = new System.Windows.Forms.TextBox();
            this.Salario = new System.Windows.Forms.TextBox();
            this.Estado = new System.Windows.Forms.TextBox();
            this.Cadastrar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Sexo = new System.Windows.Forms.TextBox();
            this.Ativo = new System.Windows.Forms.TextBox();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.EditarCliente = new System.Windows.Forms.Button();
            this.ExcluirCliente = new System.Windows.Forms.Button();
            this.Id_Cliente = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.MostrarClientePorID = new System.Windows.Forms.Button();
            this.desafio_RafaDataSet = new FormsApp.Desafio_RafaDataSet();
            this.clienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clienteTableAdapter = new FormsApp.Desafio_RafaDataSetTableAdapters.clienteTableAdapter();
            this.MostrarTodos = new System.Windows.Forms.Button();
            this.ObtendoPorNome = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.desafio_RafaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // Nome
            // 
            this.Nome.Location = new System.Drawing.Point(121, 35);
            this.Nome.Name = "Nome";
            this.Nome.Size = new System.Drawing.Size(100, 20);
            this.Nome.TabIndex = 0;
            // 
            // DataNascimento
            // 
            this.DataNascimento.Location = new System.Drawing.Point(121, 61);
            this.DataNascimento.Name = "DataNascimento";
            this.DataNascimento.Size = new System.Drawing.Size(100, 20);
            this.DataNascimento.TabIndex = 1;
            // 
            // Salario
            // 
            this.Salario.Location = new System.Drawing.Point(121, 87);
            this.Salario.Name = "Salario";
            this.Salario.Size = new System.Drawing.Size(100, 20);
            this.Salario.TabIndex = 2;
            // 
            // Estado
            // 
            this.Estado.Location = new System.Drawing.Point(121, 139);
            this.Estado.Name = "Estado";
            this.Estado.Size = new System.Drawing.Size(100, 20);
            this.Estado.TabIndex = 4;
            // 
            // Cadastrar
            // 
            this.Cadastrar.Location = new System.Drawing.Point(258, 6);
            this.Cadastrar.Name = "Cadastrar";
            this.Cadastrar.Size = new System.Drawing.Size(99, 23);
            this.Cadastrar.TabIndex = 6;
            this.Cadastrar.Text = "Cadastrar";
            this.Cadastrar.UseVisualStyleBackColor = true;
            this.Cadastrar.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(80, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Nome";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Data de Nascimento";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(80, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Salário";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(80, 113);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Sexo";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(80, 142);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Estado";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(80, 172);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Átivo?";
            // 
            // Sexo
            // 
            this.Sexo.Location = new System.Drawing.Point(121, 113);
            this.Sexo.Name = "Sexo";
            this.Sexo.Size = new System.Drawing.Size(100, 20);
            this.Sexo.TabIndex = 16;
            // 
            // Ativo
            // 
            this.Ativo.Location = new System.Drawing.Point(121, 169);
            this.Ativo.Name = "Ativo";
            this.Ativo.Size = new System.Drawing.Size(100, 20);
            this.Ativo.TabIndex = 17;
            // 
            // dataGridView
            // 
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(507, 20);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.Size = new System.Drawing.Size(437, 222);
            this.dataGridView.TabIndex = 18;
            this.dataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellClick);
            // 
            // EditarCliente
            // 
            this.EditarCliente.Location = new System.Drawing.Point(258, 35);
            this.EditarCliente.Name = "EditarCliente";
            this.EditarCliente.Size = new System.Drawing.Size(99, 23);
            this.EditarCliente.TabIndex = 19;
            this.EditarCliente.Text = "Editar";
            this.EditarCliente.UseVisualStyleBackColor = true;
            this.EditarCliente.Click += new System.EventHandler(this.button2_Click);
            // 
            // ExcluirCliente
            // 
            this.ExcluirCliente.Location = new System.Drawing.Point(258, 64);
            this.ExcluirCliente.Name = "ExcluirCliente";
            this.ExcluirCliente.Size = new System.Drawing.Size(99, 23);
            this.ExcluirCliente.TabIndex = 20;
            this.ExcluirCliente.Text = "Excluir";
            this.ExcluirCliente.UseVisualStyleBackColor = true;
            this.ExcluirCliente.Click += new System.EventHandler(this.button3_Click);
            // 
            // Id_Cliente
            // 
            this.Id_Cliente.Location = new System.Drawing.Point(121, 9);
            this.Id_Cliente.Name = "Id_Cliente";
            this.Id_Cliente.Size = new System.Drawing.Size(100, 20);
            this.Id_Cliente.TabIndex = 21;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(45, 12);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 13);
            this.label7.TabIndex = 22;
            this.label7.Text = "Id do Cliente";
            // 
            // MostrarClientePorID
            // 
            this.MostrarClientePorID.Location = new System.Drawing.Point(258, 103);
            this.MostrarClientePorID.Name = "MostrarClientePorID";
            this.MostrarClientePorID.Size = new System.Drawing.Size(99, 23);
            this.MostrarClientePorID.TabIndex = 23;
            this.MostrarClientePorID.Text = "Obter Por ID";
            this.MostrarClientePorID.UseVisualStyleBackColor = true;
            this.MostrarClientePorID.Click += new System.EventHandler(this.button4_Click);
            // 
            // desafio_RafaDataSet
            // 
            this.desafio_RafaDataSet.DataSetName = "Desafio_RafaDataSet";
            this.desafio_RafaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // clienteBindingSource
            // 
            this.clienteBindingSource.DataMember = "cliente";
            this.clienteBindingSource.DataSource = this.desafio_RafaDataSet;
            // 
            // clienteTableAdapter
            // 
            this.clienteTableAdapter.ClearBeforeFill = true;
            // 
            // MostrarTodos
            // 
            this.MostrarTodos.Location = new System.Drawing.Point(258, 172);
            this.MostrarTodos.Name = "MostrarTodos";
            this.MostrarTodos.Size = new System.Drawing.Size(99, 23);
            this.MostrarTodos.TabIndex = 24;
            this.MostrarTodos.Text = "Mostrar todos";
            this.MostrarTodos.UseVisualStyleBackColor = true;
            this.MostrarTodos.Click += new System.EventHandler(this.MostrarTodos_Click);
            // 
            // ObtendoPorNome
            // 
            this.ObtendoPorNome.Location = new System.Drawing.Point(258, 142);
            this.ObtendoPorNome.Name = "ObtendoPorNome";
            this.ObtendoPorNome.Size = new System.Drawing.Size(99, 23);
            this.ObtendoPorNome.TabIndex = 25;
            this.ObtendoPorNome.Text = "Obter Por  Nome";
            this.ObtendoPorNome.UseVisualStyleBackColor = true;
            this.ObtendoPorNome.Click += new System.EventHandler(this.ObtendoPorNome_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(968, 248);
            this.Controls.Add(this.ObtendoPorNome);
            this.Controls.Add(this.MostrarTodos);
            this.Controls.Add(this.MostrarClientePorID);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.Id_Cliente);
            this.Controls.Add(this.ExcluirCliente);
            this.Controls.Add(this.EditarCliente);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.Ativo);
            this.Controls.Add(this.Sexo);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Cadastrar);
            this.Controls.Add(this.Estado);
            this.Controls.Add(this.Salario);
            this.Controls.Add(this.DataNascimento);
            this.Controls.Add(this.Nome);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.desafio_RafaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Nome;
        private System.Windows.Forms.TextBox DataNascimento;
        private System.Windows.Forms.TextBox Salario;
        private System.Windows.Forms.TextBox Estado;
        private System.Windows.Forms.Button Cadastrar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox Sexo;
        private System.Windows.Forms.TextBox Ativo;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Button EditarCliente;
        private System.Windows.Forms.Button ExcluirCliente;
        private System.Windows.Forms.TextBox Id_Cliente;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button MostrarClientePorID;
        private Desafio_RafaDataSet desafio_RafaDataSet;
        private System.Windows.Forms.BindingSource clienteBindingSource;
        private Desafio_RafaDataSetTableAdapters.clienteTableAdapter clienteTableAdapter;
        private System.Windows.Forms.Button MostrarTodos;
        private System.Windows.Forms.Button ObtendoPorNome;
    }
}

