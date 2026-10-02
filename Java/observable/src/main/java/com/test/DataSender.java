package com.test;

public class DataSender implements Observer {

    private final String name;

    DataSender(String readerName) {
        name = readerName;
    }

    @Override
    public void update(String data) {
        /* trigger update */
        System.out.println(String.format("Received message %s", data));
    }

}
