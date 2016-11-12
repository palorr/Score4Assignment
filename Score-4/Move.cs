//Νικόλαος Παπαδογούλας 3130160, Αρχοντέλλης Ραφαήλ Σωτηρχέλλης 3130198

namespace Score_4
{
    class Move
    {
        private int col;
        private int value;

        public Move()
        {
            col = -1;
            value = 0;
        }

        public Move(bool ul, int col)
        {
            this.col = col;
            this.value = 0;
        }

        public Move(int value)
        {
            this.col = -1;
            this.value = value;
        }

        public Move(int col, int value)
        {
            this.col = col;
            this.value = value;
        }

        public int getCol()
        {
            return col;
        }

        public int getValue()
        {
            return value;
        }

        public void setCol(int col)
        {
            this.col = col;
        }

        public void setValue(int value)
        {
            this.value = value;
        }
    }
}
