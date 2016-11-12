//Νικόλαος Παπαδογούλας 3130160, Αρχοντέλλης Ραφαήλ Σωτηρχέλλης 3130198

using System;
using System.Collections.Generic;

namespace Score_4
{
    class Player
    {
        private int maxDepth;
        private int player; //the player we want to autoplay (1 for red , 2 for yellow)
        //
        public Player(int maxDepth, int player)//ctor
        {
            this.maxDepth = maxDepth;
            this.player = player;
        }
        //
        public Move MiniMax(State state)
        {
            //If the RED plays then it wants to MAXimize the heuristics value
            if (player == 1)
            {
                return max(new State(state), 0);
            }
            //If the YELLOW plays then it wants to MINimize the heuristics value
            else
            {
                return min(new State(state), 0);
            }
        }
        //
        public Move max(State state, int depth)
        {
            Random r = new Random();

            if ((state.isTerminal()) || (depth == this.maxDepth))
            {
                Move lastMove = new Move(state.getLastCol(), state.getScore());
                return lastMove;
            }
            List<State> children = new List<State>(state.GetChildren());
            Move maxMove = new Move(Int32.MinValue);
            foreach (State child in children)
            {
                Move move = min(child, depth + 1);
                if (move.getValue() >= maxMove.getValue())
                {
                    if ((move.getValue() == maxMove.getValue()))
                    {
                        if (r.Next(2) == 0)
                        {
                            maxMove.setCol(child.getLastCol());
                            maxMove.setValue(move.getValue());
                        }
                    }
                    else
                    {
                        maxMove.setCol(child.getLastCol());
                        maxMove.setValue(move.getValue());
                    }
                }
            }
            return maxMove;
        }
        public Move min(State state, int depth)
        {
            Random r = new Random();

            if ((state.isTerminal()) || (depth == this.maxDepth))
            {
                Move lastMove = new Move(state.getLastCol(), state.getScore());
                return lastMove;
            }
            List<State> children = new List<State>(state.GetChildren());
            Move minMove = new Move(Int32.MaxValue);
            foreach (State child in children)
            {
                Move move = max(child, depth + 1);
                if (move.getValue() <= minMove.getValue())
                {
                    if ((move.getValue() == minMove.getValue()))
                    {
                        if (r.Next(2) == 0)
                        {
                            minMove.setCol(child.getLastCol());
                            minMove.setValue(move.getValue());
                        }
                    }
                    else
                    {
                        minMove.setCol(child.getLastCol());
                        minMove.setValue(move.getValue());
                    }
                }
            }
            return minMove;
        }

    }
}
