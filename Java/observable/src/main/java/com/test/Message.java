package com.test;

import java.util.ArrayList;
import java.util.List;

public class Message implements Subject {

    private List<Observer> observers = new ArrayList<>();

    private String value = "value";

    public void readMessage(String value) {
        /* lettura messaggio */
        this.value = value;
        notifyObservers();
    }

    @Override
    public void register(Observer observer) {
        observers.add(observer);
    }

    @Override
    public void unregister(Observer observer) {
        observers.remove(observer);
    }

    @Override
    public void notifyObservers() {
        for (Observer observer : observers) {
            observer.update(this.value);
        }
    }
}
