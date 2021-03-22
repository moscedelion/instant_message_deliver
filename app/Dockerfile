# set base image (host OS)
FROM python:3.8
# set the working directory in the container
WORKDIR .

COPY . /app
# copy the dependencies file to the working directory


# install dependencies
RUN pip install -r /app/requirements.txt

# copy the content of the local src directory to the working directory

# command to run on container start
CMD [ "python", "/app/app.py" ]