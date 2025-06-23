package com.example.fap;

import android.view.View;
import android.widget.TextView;

import androidx.annotation.NonNull;
import androidx.recyclerview.widget.RecyclerView;

public class Test_ApplicationTestingAdapter {

    class ApplicationHolder extends RecyclerView.ViewHolder {

        TextView tv_status;
        TextView tv_type;
        TextView tv_date_create;
        TextView tv_response_message;
        TextView tv_request_message;

        public ApplicationHolder(@NonNull View itemView) {
            super(itemView);
            tv_status = itemView.findViewById(R.id.tv_status);
            tv_type = itemView.findViewById(R.id.tv_type);
            tv_date_create = itemView.findViewById(R.id.tv_date_create);
            tv_response_message = itemView.findViewById(R.id.tv_response_message);
            tv_request_message = itemView.findViewById(R.id.tv_request_message);
        }
    }

}
