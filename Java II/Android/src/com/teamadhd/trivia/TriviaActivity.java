package com.teamadhd.trivia;

import android.app.Activity;
import android.os.Bundle;
import android.graphics.Color;
import android.os.Bundle;


public class TriviaActivity extends Activity {
	   DrawView drawView;

	    @Override
	    public void onCreate(Bundle savedInstanceState) {
	        super.onCreate(savedInstanceState);

	        drawView = new DrawView(this);
	        drawView.setBackgroundColor(Color.WHITE);
	        setContentView(drawView);

	    }
	}
