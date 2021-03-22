import sys
import redis

r = redis.Redis(host='redis', port=6379, db=0)

def main():
    while True:
        try:
            message = input('write message and press enter: ')
            if message:
                r.publish('messages', message)
                print(f'message={message}')

        #handle CTRL-C and CTRL-D
        except (KeyboardInterrupt, EOFError) as e:
            print('\nHave a nice day')
            break

if __name__ == '__main__':
    main()