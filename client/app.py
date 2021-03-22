import sys
import redis
import time

r = redis.Redis(host='redis', port=6379, db=0)

def main():
    sub = r.pubsub()
    sub.subscribe('messages')
    while True:
        message = sub.get_message()
        
        if message:
            data = message['data']
            if isinstance(data, bytes):
                print(data.decode("utf-8"))
            else:
                print(data)
            time.sleep(0.01)  # be nice to the system :)

if __name__ == '__main__':
    main()
