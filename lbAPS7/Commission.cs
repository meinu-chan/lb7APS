using System;
using System.Collections.Generic;
using System.Text;

namespace lbAPS7
{
    class WestUnionHandler: AbsHandler
    {
        public override float Handle(float request)
        {
            if (request > 0 && request - 15 >= 0)
            {
                if (request <= 1500f)
                    request -= 15f;
                else
                    request -= request * .01f;
                return base.Handle(request);
            }
            else throw new Exception("Invalid Request at Western Union");
        }
    }

    class SwiftHandler : AbsHandler
    {
        public override float Handle(float request)
        {
            request -= 12 + request * .05f;
            if (request < 0)
                throw new Exception("Invalid Request at Swift");
            else
                return base.Handle(request);
        }
    }

    class BankSender: AbsHandler
    {
        public override float Handle(float request)
        {
            request -= request * .05f;
            if (request < 0)
                throw new Exception("Invalid Request at Sender");
            else
                return base.Handle(request);
        }
    }

    class BankRecipient: AbsHandler
    {
        public override float Handle(float request)
        {
            request -= 3;
            if (request < 0)
                throw new Exception("Invalid Request at Recipient");
            else
                return base.Handle(request);
        }
    }
}
