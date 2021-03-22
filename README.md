# instant_message_deliver

## Up containers:
`docker-compose up`

## Write message.
Attach local standard input, output, and error streams to a running container and type your messages.
`docker attach instant_message_deliver_app_1`

## Get messages.
Attach local standard input, output, and error streams to a running container and wait for messages.
`docker attach instant_message_deliver_client_1`

> Note that you have to attach app and client to separatet outputs
