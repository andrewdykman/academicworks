package com.teamadhd.trivia;

import android.content.Context;
import android.graphics.Canvas;
import android.graphics.Color;
import android.graphics.Paint;
import android.view.View;

public class DrawView extends View {
    Paint paint = new Paint();

    public DrawView(Context context) {
        super(context);           
    }

    @Override
    public void onDraw(Canvas canvas) {
        paint.setColor(Color.BLUE);
        paint.setStrokeWidth(3);
        canvas.drawRect(10, 430, 233, 673, paint);
        paint.setStrokeWidth(0);
        paint.setColor(Color.CYAN);
        canvas.drawRect(13, 433, 230, 670, paint );
        paint.setColor(Color.DKGRAY);
        paint.setStrokeWidth(3);
        canvas.drawRect(240, 430, 470, 673, paint);
        paint.setStrokeWidth(0);
        paint.setColor(Color.GREEN);
        canvas.drawRect(243, 433, 467, 670, paint );
        paint.setColor(Color.DKGRAY);
        paint.setStrokeWidth(3);
        canvas.drawRect(10, 170, 233, 423, paint);
        paint.setStrokeWidth(0);
        paint.setColor(Color.GREEN);
        canvas.drawRect(13, 173, 230, 420, paint );
    }

}