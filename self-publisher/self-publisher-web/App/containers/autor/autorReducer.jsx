import { GET_AUTORS_SUCCESS, GET_AUTORS_ERROR } from './autorConstants.jsx'

const initialState = {
    data: { currentPage: 0, totalPages: 0, pageSize: 0, records: [] },
    error: ''
}

export default function autor(state = initialState, action) {
    switch (action.type) {
        case GET_AUTORS_SUCCESS:
            return { ...state, data: action.autors, error: '' }

        case GET_AUTORS_ERROR:
            return { ...state, error: action.error }

        default:
            return state;
    }
}