using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalCountdown
{
    class GeneralNotes
    {

    }
}

/*
 PubSub (message broker)
- aysynchronous integartion of applications (microservices)
        -ex: poster shipping service:
            - packing service
            - delivery service
            - notification service
            - order manager service (payments)

*** BEST FOR: data streams OR Work flows
*
- if one service fails, or a new service is introduced,
    testing, scaling.. it should not affect the other services

- Cloud Pub/Sub allows messegaes to be sent between fully 
    independent applications
            - this way all apps that need to react to a specific 
                event can do so, independent of other apps
            - reduces dependencies
            - resiliant, scalable & managed
- Popular message queue servers
        - RabbitMQ, Kafka, Amazon SQS, Redis

-Deeper
    -messages can be pushed or pulled
        - one to many fan out
        - many to one fan in
        - many to many 
    - subscribers and publishers are any app that can make
        and recieve https requests
 
 
 
 
 
 
 
 
 
 
 */