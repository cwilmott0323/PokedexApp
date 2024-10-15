
namespace Pokedex
{
    partial class PokedexModel
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
            components = new System.ComponentModel.Container();
            WeaknessLabel = new Label();
            Weakness = new TextBox();
            Immunity = new TextBox();
            Resistance = new TextBox();
            PokemonInfo = new FlowLayoutPanel();
            Sprite = new PictureBox();
            PokemonName = new Label();
            Type = new Label();
            colorDialog1 = new ColorDialog();
            colorDialog2 = new ColorDialog();
            Defense = new Label();
            HP = new Label();
            SPAttack = new Label();
            SPDefense = new Label();
            Stats = new FlowLayoutPanel();
            Attack = new Label();
            Speed = new Label();
            HPText = new Label();
            AttackText = new Label();
            DefenseText = new Label();
            SPAttackText = new Label();
            SPDefenseText = new Label();
            SpeedText = new Label();
            toolTipSpeed = new ToolTip(components);
            toolTipSPDefense = new ToolTip(components);
            toolTipSPAttack = new ToolTip(components);
            toolTipDefense = new ToolTip(components);
            toolTipAttack = new ToolTip(components);
            toolTipHP = new ToolTip(components);
            Resistances = new Label();
            Immunities = new Label();
            ((System.ComponentModel.ISupportInitialize)Sprite).BeginInit();
            Stats.SuspendLayout();
            SuspendLayout();
            // 
            // WeaknessLabel
            // 
            WeaknessLabel.AutoSize = true;
            WeaknessLabel.Font = new Font("Segoe UI", 13.875F, FontStyle.Regular, GraphicsUnit.Point);
            WeaknessLabel.ForeColor = SystemColors.HighlightText;
            WeaknessLabel.Location = new Point(804, 89);
            WeaknessLabel.Name = "WeaknessLabel";
            WeaknessLabel.Size = new Size(184, 50);
            WeaknessLabel.TabIndex = 9;
            WeaknessLabel.Text = "Weakness";
            WeaknessLabel.Visible = false;
            // 
            // Weakness
            // 
            Weakness.BackColor = Color.DimGray;
            Weakness.BorderStyle = BorderStyle.None;
            Weakness.Font = new Font("Segoe UI", 10.875F, FontStyle.Regular, GraphicsUnit.Point);
            Weakness.ForeColor = SystemColors.Window;
            Weakness.Location = new Point(804, 143);
            Weakness.Margin = new Padding(40, 5, 3, 3);
            Weakness.Multiline = true;
            Weakness.Name = "Weakness";
            Weakness.ReadOnly = true;
            Weakness.Size = new Size(250, 163);
            Weakness.TabIndex = 12;
            // 
            // Immunity
            // 
            Immunity.BackColor = Color.DimGray;
            Immunity.BorderStyle = BorderStyle.None;
            Immunity.Font = new Font("Segoe UI", 10.875F, FontStyle.Regular, GraphicsUnit.Point);
            Immunity.ForeColor = SystemColors.Window;
            Immunity.Location = new Point(999, 354);
            Immunity.Margin = new Padding(40, 5, 3, 3);
            Immunity.Multiline = true;
            Immunity.Name = "Immunity";
            Immunity.ReadOnly = true;
            Immunity.Size = new Size(295, 181);
            Immunity.TabIndex = 13;
            // 
            // Resistance
            // 
            Resistance.BackColor = Color.DimGray;
            Resistance.BorderStyle = BorderStyle.None;
            Resistance.Font = new Font("Segoe UI", 10.875F, FontStyle.Regular, GraphicsUnit.Point);
            Resistance.ForeColor = SystemColors.Window;
            Resistance.Location = new Point(639, 354);
            Resistance.Margin = new Padding(40, 5, 3, 3);
            Resistance.Multiline = true;
            Resistance.Name = "Resistance";
            Resistance.ReadOnly = true;
            Resistance.Size = new Size(284, 181);
            Resistance.TabIndex = 14;
            // 
            // PokemonInfo
            // 
            PokemonInfo.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            PokemonInfo.AutoSize = true;
            PokemonInfo.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            PokemonInfo.FlowDirection = FlowDirection.TopDown;
            PokemonInfo.Location = new Point(27, 13);
            PokemonInfo.Name = "PokemonInfo";
            PokemonInfo.Size = new Size(0, 0);
            PokemonInfo.TabIndex = 16;
            // 
            // Sprite
            // 
            Sprite.BackColor = Color.WhiteSmoke;
            Sprite.BorderStyle = BorderStyle.Fixed3D;
            Sprite.Location = new Point(39, 50);
            Sprite.Name = "Sprite";
            Sprite.Size = new Size(385, 368);
            Sprite.SizeMode = PictureBoxSizeMode.StretchImage;
            Sprite.TabIndex = 10;
            Sprite.TabStop = false;
            Sprite.Visible = false;
            // 
            // PokemonName
            // 
            PokemonName.BackColor = Color.Turquoise;
            PokemonName.Font = new Font("Segoe UI", 13.875F, FontStyle.Bold, GraphicsUnit.Point);
            PokemonName.Location = new Point(39, 421);
            PokemonName.Name = "PokemonName";
            PokemonName.Size = new Size(385, 64);
            PokemonName.TabIndex = 19;
            PokemonName.TextAlign = ContentAlignment.MiddleCenter;
            PokemonName.Visible = false;
            // 
            // Type
            // 
            Type.Font = new Font("Segoe UI", 13.875F, FontStyle.Regular, GraphicsUnit.Point);
            Type.Location = new Point(39, 498);
            Type.Name = "Type";
            Type.Size = new Size(385, 64);
            Type.TabIndex = 20;
            Type.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // colorDialog2
            // 
            colorDialog2.Color = SystemColors.ActiveCaptionText;
            // 
            // Defense
            // 
            Defense.BackColor = Color.Transparent;
            Defense.Location = new Point(3, 92);
            Defense.Name = "Defense";
            Defense.Size = new Size(44, 46);
            Defense.TabIndex = 22;
            toolTipDefense.SetToolTip(Defense, "Defense");
            Defense.Paint += Attack_Paint;
            // 
            // HP
            // 
            HP.BackColor = Color.Transparent;
            HP.Location = new Point(3, 0);
            HP.Name = "HP";
            HP.Size = new Size(44, 46);
            HP.TabIndex = 23;
            toolTipHP.SetToolTip(HP, "HP");
            HP.Paint += Defense_Paint;
            // 
            // SPAttack
            // 
            SPAttack.BackColor = Color.Transparent;
            SPAttack.Location = new Point(3, 138);
            SPAttack.Name = "SPAttack";
            SPAttack.Size = new Size(44, 46);
            SPAttack.TabIndex = 24;
            toolTipSPAttack.SetToolTip(SPAttack, "SPAttack");
            SPAttack.Paint += SPAttack_Paint;
            // 
            // SPDefense
            // 
            SPDefense.BackColor = Color.Transparent;
            SPDefense.Location = new Point(3, 184);
            SPDefense.Name = "SPDefense";
            SPDefense.Size = new Size(44, 46);
            SPDefense.TabIndex = 25;
            toolTipSPDefense.SetToolTip(SPDefense, "SPDefense");
            SPDefense.Paint += SPDefense_Paint;
            // 
            // Stats
            // 
            Stats.Controls.Add(HP);
            Stats.Controls.Add(Attack);
            Stats.Controls.Add(Defense);
            Stats.Controls.Add(SPAttack);
            Stats.Controls.Add(SPDefense);
            Stats.Controls.Add(Speed);
            Stats.Controls.Add(HPText);
            Stats.Controls.Add(AttackText);
            Stats.Controls.Add(DefenseText);
            Stats.Controls.Add(SPAttackText);
            Stats.Controls.Add(SPDefenseText);
            Stats.Controls.Add(SpeedText);
            Stats.FlowDirection = FlowDirection.TopDown;
            Stats.Location = new Point(455, 103);
            Stats.Name = "Stats";
            Stats.Size = new Size(151, 278);
            Stats.TabIndex = 26;
            // 
            // Attack
            // 
            Attack.BackColor = Color.Transparent;
            Attack.Location = new Point(3, 46);
            Attack.Name = "Attack";
            Attack.Size = new Size(44, 46);
            Attack.TabIndex = 33;
            toolTipAttack.SetToolTip(Attack, "Attack");
            Attack.Paint += Attack_Paint;
            // 
            // Speed
            // 
            Speed.BackColor = Color.Transparent;
            Speed.Location = new Point(3, 230);
            Speed.Name = "Speed";
            Speed.Size = new Size(44, 46);
            Speed.TabIndex = 26;
            toolTipSpeed.SetToolTip(Speed, "Speed");
            Speed.Paint += Speed_Paint;
            // 
            // HPText
            // 
            HPText.BackColor = Color.Transparent;
            HPText.Location = new Point(50, 0);
            HPText.Margin = new Padding(0, 0, 3, 0);
            HPText.Name = "HPText";
            HPText.Size = new Size(101, 46);
            HPText.TabIndex = 27;
            // 
            // AttackText
            // 
            AttackText.BackColor = Color.Transparent;
            AttackText.Location = new Point(50, 46);
            AttackText.Margin = new Padding(0, 0, 3, 0);
            AttackText.Name = "AttackText";
            AttackText.Size = new Size(101, 46);
            AttackText.TabIndex = 28;
            // 
            // DefenseText
            // 
            DefenseText.BackColor = Color.Transparent;
            DefenseText.Location = new Point(50, 92);
            DefenseText.Margin = new Padding(0, 0, 3, 0);
            DefenseText.Name = "DefenseText";
            DefenseText.Size = new Size(101, 46);
            DefenseText.TabIndex = 29;
            // 
            // SPAttackText
            // 
            SPAttackText.BackColor = Color.Transparent;
            SPAttackText.Location = new Point(50, 138);
            SPAttackText.Margin = new Padding(0, 0, 3, 0);
            SPAttackText.Name = "SPAttackText";
            SPAttackText.Size = new Size(101, 46);
            SPAttackText.TabIndex = 30;
            // 
            // SPDefenseText
            // 
            SPDefenseText.BackColor = Color.Transparent;
            SPDefenseText.Location = new Point(50, 184);
            SPDefenseText.Margin = new Padding(0, 0, 3, 0);
            SPDefenseText.Name = "SPDefenseText";
            SPDefenseText.Size = new Size(101, 46);
            SPDefenseText.TabIndex = 31;
            // 
            // SpeedText
            // 
            SpeedText.BackColor = Color.Transparent;
            SpeedText.Location = new Point(50, 230);
            SpeedText.Margin = new Padding(0, 0, 3, 0);
            SpeedText.Name = "SpeedText";
            SpeedText.Size = new Size(101, 46);
            SpeedText.TabIndex = 32;
            // 
            // Resistances
            // 
            Resistances.AutoSize = true;
            Resistances.Font = new Font("Segoe UI", 13.875F, FontStyle.Regular, GraphicsUnit.Point);
            Resistances.ForeColor = SystemColors.Window;
            Resistances.Location = new Point(639, 299);
            Resistances.Name = "Resistances";
            Resistances.Size = new Size(208, 50);
            Resistances.TabIndex = 27;
            Resistances.Text = "Resistances";
            Resistances.Visible = false;
            // 
            // Immunities
            // 
            Immunities.AutoSize = true;
            Immunities.Font = new Font("Segoe UI", 13.875F, FontStyle.Regular, GraphicsUnit.Point);
            Immunities.ForeColor = SystemColors.Window;
            Immunities.Location = new Point(999, 299);
            Immunities.Name = "Immunities";
            Immunities.Size = new Size(204, 50);
            Immunities.TabIndex = 28;
            Immunities.Text = "Immunities";
            Immunities.Visible = false;
            // 
            // PokedexModel
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DimGray;
            ClientSize = new Size(1354, 632);
            Controls.Add(Immunities);
            Controls.Add(Resistances);
            Controls.Add(Stats);
            Controls.Add(Type);
            Controls.Add(PokemonName);
            Controls.Add(Sprite);
            Controls.Add(PokemonInfo);
            Controls.Add(Resistance);
            Controls.Add(Immunity);
            Controls.Add(Weakness);
            Controls.Add(WeaknessLabel);
            Name = "PokedexModel";
            Text = "Pokedex";
            Load += PokedexModel_Load;
            ((System.ComponentModel.ISupportInitialize)Sprite).EndInit();
            Stats.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label WeaknessLabel;
        private TextBox Weakness;
        private TextBox Immunity;
        private TextBox Resistance;
        private FlowLayoutPanel PokemonInfo;
        private PictureBox Sprite;
        private Label PokemonName;
        private Label Type;
        private ColorDialog colorDialog1;
        private ColorDialog colorDialog2;
        private Label Defense;
        private Label HP;
        private Label SPAttack;
        private Label SPDefense;
        private FlowLayoutPanel Stats;
        private Label Speed;
        private Label HPText;
        private Label AttackText;
        private Label DefenseText;
        private Label SPAttackText;
        private Label SPDefenseText;
        private Label SpeedText;
        private ToolTip toolTipSpeed;
        private ToolTip toolTipSPDefense;
        private ToolTip toolTipAttack;
        private ToolTip toolTipDefense;
        private ToolTip toolTipHP;
        private ToolTip toolTipSPAttack;
        private Label Attack;
        private Label Resistances;
        private Label Immunities;
    }
}