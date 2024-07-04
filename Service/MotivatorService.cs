using System;
using LiftDepression.Helpers;
using LiftDepression.Interface;

namespace LiftDepression.Service
{
	public class MotivatorService :IMotivatorAction

	{
		public MotivatorService()
		{

		}

        public Task GetAllPictures()
        {
            try {

            }catch(Exception Ex)
            {
                throw new ErrorHelper(Ex.Message);
            }
           
        }

        public Task GetAllQuotes()
        {
            throw new NotImplementedException();
        }

        public Task GetSinglePicture()
        {
            throw new NotImplementedException();
        }

        public Task GetSingleQuote()
        {
            throw new NotImplementedException();
        }
    }
}

