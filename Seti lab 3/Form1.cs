namespace Seti_lab_3
{
    public partial class Form1 : Form
    {
        private string[] communicationLine = {"Проводная", "Беспроводная", "Витая пара"};
        private string[] cabelType = { "wifi 2.4", "wifi 5", "cat 5", "cat 5e", "cat 6", "cat 6e", "cat 7", "om1", "om2", "om3", "om4", "os1", "os2" };
        private enum CommunicationLine
        {
            Wired,
            Wireless,
            TwistedPair
        }
        private enum CabelType 
        {
           wifi24,
           wifi5,
           cat5,
           cat5e,
           cat6,
           cat6e,
           cat7,
           om1,
           om2,
           om3,
           om4,
           os1,
           os2
        }

        private int cabelTypeFind(CabelType cabelTypeV) // возвращает тип связи в зависимости от вида кабеля
        {
            switch (cabelTypeV)
            {
                case CabelType.wifi24:
                    return 1;
                case CabelType.wifi5:
                    return 1;
                case CabelType.cat5:
                    return 0;
                case CabelType.cat6:
                    return 0;
                case CabelType.cat6e:
                    return 0;
                case CabelType.cat7:
                    return 0;
                case CabelType.om1:
                    return 2;
                case CabelType.om2:
                    return 2;
                case CabelType.om3:
                    return 2;
                case CabelType.om4:
                    return 2;
                case CabelType.os1:
                    return 2;
                case CabelType.os2:
                    return 2;
            }
            return -1;
        }
        private int cabelSpeed(CabelType cabelType)
        {
            switch (cabelType)
            {
                case CabelType.wifi24:
                    return 150;
                case CabelType.wifi5:
                    return 1000;
                case CabelType.cat5:
                    return 1;
                case CabelType.cat6:
                    return 10000;
                case CabelType.cat6e:
                    return 10000;
                case CabelType.cat7:
                    return 10000;
                case CabelType.om1:
                    return 10000;
                case CabelType.om2:
                    return 10000;
                case CabelType.om3:
                    return 10000;
                case CabelType.om4:
                    return 10000;
                case CabelType.os1:
                    return 40000;
                case CabelType.os2:
                    return 40000;
            }
            return -1;
        }


        private int cabelLenght(CabelType cabelType)
        {
            switch (cabelType)
            {
                case CabelType.wifi24:
                    return 150;
                case CabelType.wifi5:
                    return 50;
                case CabelType.cat5:
                    return 100;
                case CabelType.cat6:
                    return 55;
                case CabelType.cat6e:
                    return 55;
                case CabelType.cat7:
                    return 55;
                case CabelType.om1:
                    return 550;
                case CabelType.om2:
                    return 550;
                case CabelType.om3:
                    return 550;
                case CabelType.om4:
                    return 550;
                case CabelType.os1:
                    return 500000;
                case CabelType.os2:
                    return 500000;
            }
            return -1;
        }
        public Form1()
        {
            InitializeComponent();
            comboBoxCabelType.Items.AddRange(cabelType);
            comboBoxCommunicationLine.Items.AddRange(communicationLine);
        }

        private bool isConnectionPosible(CommunicationLine comunicationLineV, CabelType cabelTypeV, int lenght, int speed)
        {
            if (comunicationLineV == (CommunicationLine)cabelTypeFind(cabelTypeV) && lenght <= cabelLenght(cabelTypeV) && speed <= cabelSpeed(cabelTypeV))
                return true;
            else
                return false;
        }
        private void buttonSubmit_Click(object sender, EventArgs e)
        {
            CommunicationLine communicationLineV = (CommunicationLine)comboBoxCommunicationLine.SelectedIndex;
            CabelType cabelTypeV = (CabelType)comboBoxCabelType.SelectedIndex;
            int lenght = int.Parse(textBoxCabelLenght.Text);
            int speed = int.Parse(textBoxCabelSpeed.Text);
            if (isConnectionPosible(communicationLineV, cabelTypeV, lenght, speed))
            {
                labelResultValue.Text = "Да!";
                labelResultValue.BackColor = Color.Green;
            }
            else
            {
                labelResultValue.Text = "Нет!";
                labelResultValue.BackColor = Color.Red;
            }
        }
    }
}