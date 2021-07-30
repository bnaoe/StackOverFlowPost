using System;

namespace StackOverFlowPost
{
    public class StackPost
    {
        private readonly string _title;
        private readonly DateTime _dateTimeStamp;

        private int _upVotes;
        private int _downVotes;

        public string Description { get; set; }
        //{
        //    set { _description = value; }
        //    get { return _description; }
        //}

        public string Title { get => _title; }

        public DateTime DateTimestamp { get => _dateTimeStamp; }

        public StackPost(string title, DateTime dateTimeStamp)
        {
            this._title = title;
            this._dateTimeStamp = dateTimeStamp;
        }

        public string ValidateEntry(string input)
        {
            if (input.ToLower() == "up")
            {
                UpVote();
                return "up";
            }
            else if (input.ToLower() == "down")
            {
                DownVote();
                return "down";
            }
            else if (input.ToLower() == "exit")
            {
                return "exit";
            }
            else return "try";
        }

        public void UpVote()
        {
            this._upVotes++;
        }

        public void DownVote()
        {
            this._downVotes++;
        }

        public int GetUpVotes { get => _upVotes; }

        public int GetDownVotes { get => _downVotes; }

        public int GetVotes { get => _upVotes + _downVotes; }
    }
}