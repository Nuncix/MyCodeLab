package com.test;

/**
 * Hello world!
 *
 */
public class App {
    public static void main(String[] args) {
        Message message = new Message();
        DataSender ds = new DataSender("reader 1");
        message.register(ds);
        message.readMessage("pollo");
    }
}
